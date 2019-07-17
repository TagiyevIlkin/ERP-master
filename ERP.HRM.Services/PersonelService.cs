using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERP.HRM.DTO.PersonelDTOS;
using ERP.HRM.Services.Interfaces;
using ERP.Repositories.Interfaces;
using ERP.Shared.Entities;

namespace ERP.HRM.Services
{
    public class PersonelService
    {
        private readonly IUnitOfWork _unitOfWork;
        public PersonelService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
    }
}
