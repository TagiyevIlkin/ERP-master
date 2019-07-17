using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.HRM.Entities
{
    [Table("ApplicationNumber")]
    public class ApplicationNumber
    {
        [Key]
        public int Id { get; set; }

        public int PersonApplicationTypeId { get; set; }

        public int PeriodId { get; set; }

        public string Prefix { get; set; }

        public string LastNumber { get; set; }

        public virtual PersonApplicationType PersonApplicationType { get; set; }

        public virtual Period Period { get; set; }
    }
}
