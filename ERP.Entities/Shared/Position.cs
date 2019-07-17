using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Shared.Entities
{
    [Table("Position")]
    public class Position
    {
        [Key] public int Id { get; set; }

        [Required]
        [StringLength(50), MinLength(3)]
        public string Name { get; set; }
    }
}
