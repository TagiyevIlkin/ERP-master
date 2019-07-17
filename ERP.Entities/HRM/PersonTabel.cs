using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ERP.Shared.Entities;

namespace ERP.HRM.Entities
{
    [Table("PersonTabel")]
    public class PersonTabel
    {
        [Key]
        public int Id { get; set; }

        public int DepartmentPositionId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime BeginTime { get; set; }

        [DataType(DataType.Time)]
        public DateTime EndTime { get; set; }

        public virtual DepartmentPosition DepartmentPosition { get; set; }
    }
}
