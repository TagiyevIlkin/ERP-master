using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ERP.Shared.Entities;

namespace ERP.HRM.Entities
{
    [Table("ContractType")]
    public class ContractType
    {
        public ContractType()
        {
            DepartmentPositions = new HashSet<DepartmentPosition>();
        }
        [Key]
        public int Id { get; set; }

        [StringLength(50), MinLength(3), Required]
        public string Name { get; set; }

        public virtual ICollection <DepartmentPosition> DepartmentPositions { get; set; }
    }
}
