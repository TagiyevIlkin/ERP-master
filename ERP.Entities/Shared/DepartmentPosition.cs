using ERP.HRM.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ERP.Shared.Entities
{
    [Table("DepartmentPosition")]
    public class DepartmentPosition
    {
        [Key] public int Id { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public int ContractTypeId { get; set; }

        [StringLength(50), MinLength(3), Required]
        public string Name { get; set; }

        public string VacationDayCount { get; set; }

        public string MaterialResponsibilityFile { get; set; }

        public virtual Department Department { get; set; }

        public virtual ContractType ContractType { get; set; }
    }
}
