using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ERP.Shared.Entities
{
    [Table("User")]
    public class User
    {
        public User()
        {
            UserRoles=new HashSet<UserRole>();
        }
        [Key]
        public int Id { get; set; }
                    
        public int PersonelId { get; set; }
        public virtual Personel Personel { get; set; }

        [StringLength(50),MinLength(3),Required]
        public string Username { get; set; }

        [Required,MinLength(6)]
        public string Password { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }
        public bool Status { get; set; }
    }
}
