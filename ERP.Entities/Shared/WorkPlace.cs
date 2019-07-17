using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ERP.Shared.Entities
{
    [Table("WorkPlace")]
    public class WorkPlace
    {
        [Key] public int Id { get; set; }

        public int UserId { get; set; }
        public int DepartmentPositionId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        [ForeignKey("DepartmentPositionId")]
        public virtual DepartmentPosition DepartmentPosition { get; set; }
    }
}
