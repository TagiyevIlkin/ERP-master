using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ERP.HRM.DTO;
using ERP.HRM.DTO.PersonelDTOS;
using ERP.HRM.Services.Interfaces;
using ERP.HRM.Utility;
using ERP.Repositories.Interfaces;
using ERP.Shared.Entities;
using ERP.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ERP.HRM.WebAPI.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;

        public PersonelController(IConfiguration configuration, IMapper mapper, IUnitOfWork unitOfWork,
            IUserService userService)
        {
            _configuration = configuration;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userService = userService;
        }

       


        #region Get /Personels

        //// GET: api/Personels
        [HttpGet]
        [Route("PersonelList")]
        public IActionResult GetPersonelForPaging()
        {
            var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
            // Skiping number of Rows count
            var start = Request.Form["start"].FirstOrDefault();
            // Paging Length 10,20
            var length = Request.Form["length"].FirstOrDefault();
            // Sort Column Name
            var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
            // Sort Column Direction ( asc ,desc)
            var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
            // Search Value from (Search box)
            var searchValue = Request.Form["search[value]"].FirstOrDefault();

            //Paging Size (10,20,50,100)
            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;

            var model = _userService.GetUserPersonList();

            
            if (!string.IsNullOrEmpty(searchValue))
            {
                model = model.Where(m => m.Fullname == searchValue
                                             || (m.Fullname != null && m.Fullname.StartsWith(searchValue))
                                             || (m.UserName != null && m.UserName.StartsWith(searchValue)));
            }


            //total number of rows count 
            recordsTotal = model.Count();
            //Paging 
            var data = model.Skip(skip).Take(pageSize).ToList();
            //Returning Json Data
            return new JsonResult(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });
        }

        #endregion

        #region GET: api/Personels/5
        //// GET: api/Personels/5
        [HttpGet]
        [Route("GetById/{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            ApiResult apiResult = new ApiResult() {ResultCode = (int) ResultCode.Success};

            var personel = await _unitOfWork.Repository<Personel>().GetByIdAsync(id);

            if (personel == null)
            {
                apiResult.ResultCode = (int) ResultCode.NotFound;
                apiResult.Description = ApiResultConst.NotFoundPersonel;

                return new ObjectResult(apiResult);
            }

            apiResult.Model = _mapper.Map<PersonelGetByIdDTO>(personel);
            apiResult.Description = ApiResultConst.OperationSuccessed;
            return new ObjectResult(apiResult);
        }
        #endregion

        #region Post/Create Personel  

        // POST: api/Personels
        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] CreatePersonelDTO model)
        {
            ApiResult apiResult = new ApiResult() {ResultCode = (int) ResultCode.Success};

            if (ModelState.IsValid)
            {
                if (!_unitOfWork.Repository<Personel>().Exist(x => x.PinCode == model.PinCode&& x.SerialNumber ==model.SerialNumber) )
                {
                    var person = _mapper.Map<Personel>(model);

                    var result = _unitOfWork.Repository<Personel>().Add(person);

                    if (result.IsSuccess)
                    {
                        apiResult.Model = person.Id;
                        apiResult.Description = ApiResultConst.Success;
                        return new ObjectResult(apiResult);
                    }

                    apiResult.ResultCode = (int) ResultCode.Error;
                    apiResult.Model = person;
                    apiResult.Description = ApiResultConst.Error;
                    return new ObjectResult(apiResult);
                }

                apiResult.ResultCode = (int) ResultCode.Error;
                apiResult.Description = ApiResultConst.AleadyTakenPin;
                return new ObjectResult(apiResult);
            }

            apiResult.ResultCode = (int) ResultCode.Error;
            apiResult.Description = ApiResultConst.ModelNotValid;
            return new ObjectResult(apiResult);
        }

        #endregion

        #region PUT: api/Personels/5

        //// PUT: api/Personels/5
        [HttpPost]
        [Route("Edit")]
        public IActionResult Edit([FromBody] CreatePersonelDTO model)
        {
            ApiResult apiResult = new ApiResult() {ResultCode = (int) ResultCode.Success};

            if (ModelState.IsValid)
            {
                var personDb = _unitOfWork.Repository<Personel>().GetById(model.Id);

                if (personDb != null)
                {
                    var person = _mapper.Map<Personel>(model);


                    //same pin code condition
                    if (!_unitOfWork.Repository<Personel>()
                        .Exist(x => x.PinCode == personDb.PinCode && x.SerialNumber == model.SerialNumber && x.Id != personDb.Id))
                    {
                        var result = _unitOfWork.Repository<Personel>().Update(personDb);

                        //person update success
                        if (result.IsSuccess)
                        {
                            apiResult.Model = person.Id;
                            apiResult.Description = ApiResultConst.Success;
                            return new ObjectResult(apiResult);
                        }
                    }
                    apiResult.ResultCode = (int)ResultCode.Error;
                    apiResult.Model = model;
                    apiResult.Description = ApiResultConst.AleadyTakenPin;
                    return new ObjectResult(apiResult);
                    
                }
                
            }

            //model state not valid 
            apiResult.ResultCode = (int) ResultCode.Error;
            apiResult.Description = ApiResultConst.ModelNotValid;
            return new ObjectResult(apiResult);
        }

        #endregion

        #region DELETE: api/ApiWithActions/5

        //// DELETE: api/ApiWithActions/5
        [HttpPost]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            ApiResult apiResult = new ApiResult() {ResultCode = (int) ResultCode.Success};

            var person = await _unitOfWork.Repository<Personel>().GetByIdAsync(id);

            if (person == null)
            {
                apiResult.ResultCode = (int) ResultCode.NotFound;
                apiResult.Description = ApiResultConst.NotFoundPersonel;
                return new ObjectResult(apiResult);
            }

            var result = await _unitOfWork.Repository<Personel>().DeleteAsync(person);


            if (result.IsSuccess)
            {
                apiResult.Model = person.Id;
                apiResult.Description = ApiResultConst.Success;
                return new ObjectResult(apiResult);
            }

            apiResult.ResultCode = (int) ResultCode.Error;
            apiResult.Description = ApiResultConst.Error;
            return new ObjectResult(apiResult);
        }

        #endregion
    }
}