using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Shared.Entities
{
    [Table("Organization")]
    public class Organization
    {
        [Key] public int Id { get; set; }

        public int OrganizationLegalFormId { get; set; }
        public int OrganizationLegalTypeId { get; set; }
        public int? TopOrganizationId { get; set; }

        [ForeignKey("OrganizationLegalFormId")]
        public virtual OrganizationLegalForm OrganizationLegalForm { get; set; }
        [ForeignKey("OrganizationLegalTypeId")]
        public virtual OrganizationLegalType OrganizationLegalType { get; set; }
 

        [StringLength(50), MinLength(3), Required]
        public string Name { get; set; }

        [StringLength(50), MinLength(1), Required]
        public string ShortName { get; set; }

        [Phone]
        public string MobileNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(10)]
        public string VORN { get; set; }

        [StringLength(10)]
        public string Index { get; set; }
    }
}
