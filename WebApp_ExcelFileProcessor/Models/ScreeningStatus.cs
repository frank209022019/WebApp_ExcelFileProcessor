using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ExcelFileProcessor.Models
{
    [Table("ScreeningStatuses")]
    public class ScreeningStatus : ModelBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid ScreeningStatusId { get; set; }

        public String ScreeningStatusName { get; set; }
    }
}