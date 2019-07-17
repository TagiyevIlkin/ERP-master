using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ERP.Shared.Entities
{
    [Table("PhoneType")]
    public class PhoneType
    {
        [Key] public int Id { get; set; }

        [RegularExpression(@"^\+[0 - 9]{3}-\s+[0-9]{3}-[0-9]{3}[0-9]{2}[0-9]{2}$")]
        public string HomeNumber { get; set; }

        [RegularExpression(@"^\+[0 - 9]{3}-\s+[0-9]{3}-[0-9]{3}[0-9]{2}[0-9]{2}$")]
        public string JobNumber { get; set; }

        [RegularExpression(@"^\+[0 - 9]{3}\s+[0-9]{9}$")]
        public string MobileNumber { get; set; }

        [Phone]
        public string AdditionalNumber { get; set; }
    }
}
