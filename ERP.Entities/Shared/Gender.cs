using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ERP.Shared.Entities
{
    [Table("Gender")]
    public class Gender
    {
        public Gender()
        {
            Personels = new HashSet<Personel>();
        }
        [Key] public int Id { get; set; }

        [StringLength(10)]
        public string Type { get; set; }

        public virtual ICollection<Personel> Personels { get; set; }
    }
}
