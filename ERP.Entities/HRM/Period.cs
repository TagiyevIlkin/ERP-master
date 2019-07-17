﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.HRM.Entities
{
    [Table("Period")]
    public class Period
    {
        public Period()
        {
            ApplicationNumbers = new HashSet<ApplicationNumber>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(50), MinLength(3), Required]
        public string Name { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime BeginDate { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime EndDate { get; set; }

        public virtual ICollection<ApplicationNumber> ApplicationNumbers { get; set; }
    }
}
