using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP.Shared.Entities
{
    [Table("PersonelFile")]
    public class PersonelFile
    {
        [Key] public int Id { get; set; }

        public int PersonelId { get; set; }

        public int PersonelFileTypeId { get; set; }

        public string FilePath { get; set; }

        public string FileName { get; set; }

        public virtual Personel Personel { get; set; }

        public virtual PersonelFileType PersonelFileType { get; set; }
    }
}
