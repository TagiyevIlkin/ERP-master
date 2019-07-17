using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ERP.Shared.Entities
{
    [Table("StuctureType")]
    public class StructureType
    {
        [Key] public int Id { get; set; }

        [StringLength(50), MinLength(3), Required]
        public string Name { get; set; }
    }
}
