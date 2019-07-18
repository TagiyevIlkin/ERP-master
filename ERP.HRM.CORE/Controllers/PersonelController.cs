using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ERP.HRM.CORE.ViewModels;
using ERP.HRM.DTO;
using ERP.HRM.Services.Interfaces;
using ERP.HRM.Utility;
using ERP.Repositories.Interfaces;
using ERP.Shared.Entities;
using ERP.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ERP.HRM.CORE.Controllers
{
    public class PersonelController : Controller
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

        public IActionResult Index()
        {
            return View();
        }

        #region Create Person
        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }



        [HttpPost]
        public IActionResult Create(PersonelViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!_unitOfWork.Repository<Personel>().Exist(x => x.SerialNumber == model.SerialNumber))
                {
                    if (!_unitOfWork.Repository<Personel>().Exist(x => x.PinCode == model.PinCode))
                    {
                        var person = _mapper.Map<Personel>(model);

                        var result = _unitOfWork.Repository<Personel>().Add(person);
                        if (result.IsSuccess)
                        {
                            return Json(new { success = true, message = ApiResultConst.EditSuccess });
                        }
                        ModelState.AddModelError("CummonValidation", ApiResultConst.Error);
                        return View(model);
                    }
                    ModelState.AddModelError("PinCode", ApiResultConst.AleadyTakenPin);

                    return View(model);
                }
                ModelState.AddModelError("SerialNumber", ApiResultConst.AleadyHaveSerialNumber);
                return View(model);
            }

            ModelState.AddModelError("CummonValidation", ApiResultConst.ModelNotValid);

            return View(model);
        }
        #endregion

        #region Edit Person
        [HttpGet]
        public IActionResult Edit(int id)
        {

            var person = _unitOfWork.Repository<Personel>().GetById(id);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }

        [HttpPost]
        public IActionResult Edit(PersonelViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!_unitOfWork.Repository<Personel>().Exist(x => x.SerialNumber == model.SerialNumber))
                {
                    if (!_unitOfWork.Repository<Personel>().Exist(x => x.PinCode == model.PinCode))
                    {
                        var person = _mapper.Map<Personel>(model);

                        var result = _unitOfWork.Repository<Personel>().Update(person);

                        if (result.IsSuccess)
                        {
                            return Json(new { success = true, message = ApiResultConst.AddSuccess });
                        }
                        return View(model);
                    }
                    ModelState.AddModelError("PinCode", ApiResultConst.AleadyTakenPin);
                    return View(model);
                }
                ModelState.AddModelError("SerialNumber", ApiResultConst.AleadyHaveSerialNumber);
                return View(model);
            }
            ModelState.AddModelError("CummonValidation", ApiResultConst.ModelNotValid);

            return View(model);
        }
        #endregion

        #region Delete Person
        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var person = await _unitOfWork.Repository<Personel>().GetByIdAsync(id);
            if (person == null)
            {
                return NotFound();
            }

            var result = await _unitOfWork.Repository<Personel>().DeleteAsync(person);

            if (result.IsSuccess)
            {
                return Json(new { success = true, message = ApiResultConst.DdeleteSuccess });
            }

              return Json(new { success = true, message = ApiResultConst.Error });
        }
        #endregion

    }
}