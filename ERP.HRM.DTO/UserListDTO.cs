using System;
using System.Collections.Generic;
using System.Text;

namespace ERP.HRM.DTO
{
    public class UserListDTO
    {
        public int Id { get; set; }

        public int PersonelId { get; set; }

        public string UserName { get; set; }

        public string Fullname { get; set; }

        public bool Status { get; set; }
    }
}
