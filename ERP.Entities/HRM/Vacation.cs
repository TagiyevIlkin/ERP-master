using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ERP.Shared.Entities;

namespace ERP.HRM.Entities
{
    [Table("Vacation")]
    public class Vacation
    {
        [Key]
        public int Id { get; set; }

        public int VacationTypeId { get; set; }
        public int DepartmentPositionId { get; set; }

        public int PersonId { get; set; }

        public int ReplacementPersonId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime BeginDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public bool Status { get; set; }

        public virtual VacationType VacationType { get; set; }

        public virtual DepartmentPosition DepartmentPosition { get; set; }

        public virtual Personel Personel { get; set; }
    }
}
