using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ERP.Shared.Entities
{
    [Table("Department")]
    public class Department
    {
        public Department()
        {
            StructureTypes = new HashSet<StructureType>();
            TopDepartments = new HashSet<Department>();
            DepartmentPositions = new HashSet<DepartmentPosition>();
        }
        [Key] public int Id { get; set; }

        [StringLength(50), MinLength(3), Required]
        public string Name { get; set; }

        [StringLength(50), MinLength(1), Required]
        public string ShortName { get; set; }

        public int Index { get; set; }

        //[ForeignKey("StructureType")]
        public virtual ICollection<StructureType> StructureTypes { get; set; }

        //[ForeignKey("TopDepartmentId")]
        public virtual ICollection<Department> TopDepartments { get; set; }

        public virtual ICollection<DepartmentPosition> DepartmentPositions { get; set; }
    }
}
