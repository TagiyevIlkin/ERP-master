using System;
using System.Collections.Generic;
using System.Text;
using ERP.HRM.DTO.PersonelDTOS;

namespace ERP.HRM.Services.Interfaces
{
    public interface IPersonelService
    {
        PersonelGetByIdDTO GetById();
    }
}
