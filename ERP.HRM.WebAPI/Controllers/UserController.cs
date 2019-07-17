using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ERP.HRM.DTO;
using ERP.HRM.Services.Interfaces;
using ERP.HRM.Utility;
using ERP.Repositories.Interfaces;
using ERP.Shared.Entities;
using ERP.Utility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ERP.HRM.WebAPI.Controllers
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUserService _userService;

        public UserController(IConfiguration configuration, IMapper mapper, IUnitOfWork unitOfWork, IUserService userService)
        {
            _configuration = configuration;
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _userService = userService;
        }

        #region Get /Users
        //// GET: api/Users
        [HttpGet]
        [Route("UsersList")]
        public IActionResult GetUserForPaging()
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
        #region GET/USER return Id,Username

        [HttpGet]
        [Route("GetUsers")]
        public IActionResult GetUsers()
        {
            ApiResult apiResult = new ApiResult() { ResultCode = (int)ResultCode.Success };

            var model = _userService.GetUsers();

            apiResult.Model = model;

            return new ObjectResult(apiResult);
        }
        #endregion
        #region GET: api/User/5

        //// GET: api/User/5
        [HttpGet]
        [Route("User/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ApiResult apiResult = new ApiResult() { ResultCode = (int)ResultCode.Success };

            var user = await _unitOfWork.Repository<User>().GetByIdAsync(id);

            if (user == null)
            {
                apiResult.ResultCode = (int)ResultCode.NotFound;
                apiResult.Description = ApiResultConst.NotFoundUser;

                return new ObjectResult(apiResult);
            }

            //apiResult.Description = ApiResultConst.NotFounduser;
            return new ObjectResult(apiResult);
        }

        #endregion

        #region Post/Create User
        //POST:api/Users
        [HttpPost]
        [Route("Create")]
        public IActionResult Create([FromBody] CreateUserDTO model)
        {
            ApiResult apiResult = new ApiResult() { ResultCode = (int)ResultCode.Success };

            if (ModelState.IsValid)
            {
                if (_unitOfWork.Repository<User>().Find(x => x.Username != model.Username) != null)
                {
                    var user = _mapper.Map<User>(model);

                    var result = _unitOfWork.Repository<User>().Add(user);

                    if (result.IsSuccess)
                    {
                        apiResult.Model = user.Id;
                        apiResult.Description = ApiResultConst.Success;
                        return new ObjectResult(apiResult);
                    }


                    apiResult.ResultCode = (int)ResultCode.Error;
                    apiResult.Model = user;
                    apiResult.Description = ApiResultConst.Error;
                    return new ObjectResult(apiResult);
                }

                apiResult.ResultCode = (int)ResultCode.Error;
                apiResult.Description = ApiResultConst.AleadyTakenUsername;
                return new ObjectResult(apiResult);
            }

            apiResult.ResultCode = (int)ResultCode.Error;
            apiResult.Description = ApiResultConst.ModelNotValid;
            return new ObjectResult(apiResult);
        }
        #endregion


        #region Edit/User

        [HttpPost]
        [Route("Edit")]
        public IActionResult Edit([FromBody] CreateUserDTO model)
        {
            ApiResult apiResult = new ApiResult() { ResultCode = (int)ResultCode.Success };

            if (ModelState.IsValid)
            {
                var userDb = _unitOfWork.Repository<User>().GetById(model.Id);

                if (userDb != null)
                {
                    var user = _mapper.Map<User>(model);


                    //same pin code condition
                    if (_unitOfWork.Repository<User>()
                        .Exist(x => x.Username == userDb.Username && x.Id != userDb.Id))
                    {
                        apiResult.ResultCode = (int)ResultCode.Error;
                        apiResult.Model = model;
                        apiResult.Description = ApiResultConst.AleadyTakenUsername;
                        return new ObjectResult(apiResult);
                    }

                    var result = _unitOfWork.Repository<User>().Update(userDb);

                    //person update success
                    if (result.IsSuccess)
                    {
                        apiResult.Model = user.Id;
                        apiResult.Description = ApiResultConst.Success;
                        return new ObjectResult(apiResult);
                    }
                }

            }

            //model state not valid 
            apiResult.ResultCode = (int)ResultCode.Error;
            apiResult.Description = ApiResultConst.ModelNotValid;
            return new ObjectResult(apiResult);
        }
        #endregion

        #region DELETE/user

        //// DELETE: api/ApiWithActions/5
        [HttpPost]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            ApiResult apiResult = new ApiResult() { ResultCode = (int)ResultCode.Success };

            var user = await _unitOfWork.Repository<User>().GetByIdAsync(id);

            if (user == null)
            {
                apiResult.ResultCode = (int)ResultCode.NotFound;
                apiResult.Description = ApiResultConst.NotFoundPersonel;
                return new ObjectResult(apiResult);
            }

            var result = await _unitOfWork.Repository<User>().DeleteAsync(user);


            if (result.IsSuccess)
            {
                apiResult.Model = user.Id;
                apiResult.Description = ApiResultConst.Success;
                return new ObjectResult(apiResult);
            }

            apiResult.ResultCode = (int)ResultCode.Error;
            apiResult.Description = ApiResultConst.Error;
            return new ObjectResult(apiResult);
        }

        #endregion
    }
}