using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ERP.Shared.Entities
{
    [Table("Country")]
    public  class Country
    {
        [Key] public int Id { get; set; }

        [Phone]
        public int MobilePhonePin { get; set; }
    }
}
