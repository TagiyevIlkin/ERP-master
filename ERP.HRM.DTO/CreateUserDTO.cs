using System.ComponentModel.DataAnnotations;

namespace ERP.HRM.DTO
{
    public class CreateUserDTO
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
