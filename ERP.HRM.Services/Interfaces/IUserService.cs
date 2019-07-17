using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERP.HRM.DTO;

namespace ERP.HRM.Services.Interfaces
{
    public interface IUserService
    {
        IQueryable<UserListDTO> GetUserPersonList();

        IQueryable<UserForComboBoxDTO> GetUsers();
    }
}
