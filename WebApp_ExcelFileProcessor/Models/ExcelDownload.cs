using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_ExcelFileProcessor.Models
{

    [Table("ExcelDownload")]
    public class ExcelDownload : ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ExcelDownloadId { get; set; }

        public String FileName { get; set; }
       public Byte[] FileByteArray { get; set; }
    }
}
