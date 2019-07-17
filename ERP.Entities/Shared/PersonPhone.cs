using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ERP.Shared.Entities
{
    [Table("PersonPhone")]
    public class PersonPhone
    {
        public PersonPhone()
        {
            PhoneTypes = new HashSet<PhoneType>();
        }

        [Key] public int Id { get; set; }

        public int CountryId { get; set; }

        public virtual ICollection<PhoneType> PhoneTypes { get; set; }

        [StringLength(50), MinLength(3), Required]
        public string Number { get; set; }

        public virtual Country Country { get; set; }
    }
}
