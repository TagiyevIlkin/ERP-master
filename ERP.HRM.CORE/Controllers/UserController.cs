using ERP.HRM.CORE.ViewModels;
using ERP.HRM.Services.Interfaces;
using ERP.HRM.Utility;
using ERP.Repositories.Interfaces;
using ERP.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.HRM.CORE.Controllers
{
    public class UserController : Controller
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
        public IActionResult Index()
        {
            return View();
        }


        #region  Create User
        public IActionResult Create()
        {
            return View();
        }

    
        [HttpPost]
        public IActionResult Create(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (_unitOfWork.Repository<User>().Exist(x=>x.Username==model.Username))
                {
                    var user = _mapper.Map<User>(model);
                    var result = _unitOfWork.Repository<User>().Add(user);
                    if (result.IsSuccess)
                    {
                        return Json(new { success = true, message = ApiResultConst.AddSuccess });
                    }
                    ModelState.AddModelError("CummonValidation", ApiResultConst.Error);
                    return View(model);
                }

                ModelState.AddModelError("Username", ApiResultConst.AleadyTakenUsername);
                return View(model);
        
            }
            ModelState.AddModelError("CummonValidation", ApiResultConst.ModelNotValid);
            return View(model);
        }
        #endregion

        #region  Edit User

        public IActionResult Edit(int id)
        {

            if (id>0)
            {
                var user = _unitOfWork.Repository<User>().GetById(id);
                if (user!=null)
                {
                    return View(user);
                }
            }
            return View();

        }

        [HttpPost]
        public IActionResult Edit(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!_unitOfWork.Repository<User>().Exist(x=>x.Username==model.Username))
                {
                    var user = _mapper.Map<User>(model);
                   var result= _unitOfWork.Repository<User>().Update(user);
                    if (result.IsSuccess)
                    {
                        return Json(new { success = true, message = ApiResultConst.EditSuccess });
                    }
                    ModelState.AddModelError("CummonValidation", ApiResultConst.Error);
                    return View(model);
                }
                ModelState.AddModelError("Username", ApiResultConst.AleadyTakenUsername);
            }
            ModelState.AddModelError("CummonValidation", ApiResultConst.ModelNotValid);

            return View(model);
        }


        #endregion

        #region  Delete User
        [HttpPost]
        public  async Task< IActionResult> Delete(int id)
        {
            
          var user = await _unitOfWork.Repository<User>().GetByIdAsync(id);
            if (user ==null)
            {
                return NotFound();
            }
            var result = await _unitOfWork.Repository<User>().DeleteAsync(user);

            if (result.IsSuccess)
            {
                return Json(new { success = true, message = ApiResultConst.DdeleteSuccess });
            }

            return Json(new { success = true, message = ApiResultConst.Error});
        }



        #endregion
    }
}
