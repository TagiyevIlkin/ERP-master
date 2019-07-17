using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Shared.Entities
{


    [Table("Role")]
    public class Role
    {
        public Role()
        {
            UserRoles=new HashSet<UserRole>();
        }
        [Key] public int Id { get; set; }

        [Required]
        [StringLength(50), MinLength(3)]
        public string Name { get; set; }

        [StringLength(50), MinLength(3)]
        public string Description { get; set; }

        public virtual ICollection<UserRole> UserRoles { get; set; }      
    }
}