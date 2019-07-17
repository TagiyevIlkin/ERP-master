using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.HRM.Entities
{
    [Table("PersonApplicationType")]
    public class PersonApplicationType
    {      
        [Key]
        public int Id { get; set; }

        [StringLength(50), MinLength(3), Required]
        public string Name { get; set; }
       
        public string FilePath { get; set; }
    }
}
