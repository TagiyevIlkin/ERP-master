using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Shared.Entities
{
    [Table("WorkBook")]
    public class WorkBook
    {
        [Key] public int Id { get; set; }

        public int PositionId { get; set; }

        public int OrganizationId { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime BeginDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public virtual Position Position { get; set; }

        public virtual Organization Organization { get; set; }
    }
}
