using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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