using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ERP.HRM.CORE.ViewModels
{
    public class UserViewModel
    {
        [Key]
        public int Id { get; set; }

        public int PersonelId { get; set; }


        [StringLength(50), MinLength(3), Required]
        public string Username { get; set; }

        [Required, MinLength(6)]
        public string Password { get; set; }

        public bool Status { get; set; }
    }
}
