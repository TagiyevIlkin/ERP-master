
using System.ComponentModel.DataAnnotations;


namespace ERP.HRM.DTO
{
    public class UserLoginDTO
    {
        [StringLength(50), MinLength(3), Required]
        public string Username { get; set; }

        [Required, MinLength(6)]
        public string Password { get; set; }

    }
}
