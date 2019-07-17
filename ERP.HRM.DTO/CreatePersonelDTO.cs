using System;
using System.ComponentModel.DataAnnotations;

namespace ERP.HRM.DTO
{
    public class CreatePersonelDTO
    {

        [Key] public int Id { get; set; }

        [Required]
        [StringLength(50), MinLength(3)]
        public string Firstname { get; set; }

        [Required]
        [StringLength(50), MinLength(3)]
        public string Lastname { get; set; }


        [Required]
        [StringLength(50), MinLength(3)]
        public string FatherName { get; set; }

        public string Fullname
        {
            get { return $"{Firstname} {Lastname} {FatherName}"; }
        }

        public DateTime Birthdate { get; set; }

        [Required]
        [StringLength(100), MinLength(3)]
        public string Residence { get; set; }

        [DataType(DataType.PostalCode)]
        public string PinCode { get; set; }

        [DataType(DataType.PostalCode)]
        public string SerialNumber { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        public int CityId { get; set; }

        public int GenderId { get; set; }

        public int FamilyStatusId { get; set; }

    }
}
