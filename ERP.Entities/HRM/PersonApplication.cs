using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ERP.Shared.Entities;

namespace ERP.HRM.Entities
{
    [Table("PersonApplication")]
    public class PersonApplication
    {
        [Key]
        public int Id { get; set; }

        public int FromDepartmentPositionId { get; set; }

        public int ToDepartmentPositionId { get; set; }

        public int PersonApplicationTypeId { get; set; }

        public int PersonId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Date { get; set; }

        public virtual PersonApplicationType PersonApplicationType { get; set; }

        public virtual DepartmentPosition DepartmentPosition { get; set; }

        public virtual Personel Personel { get; set; }

    }
}
