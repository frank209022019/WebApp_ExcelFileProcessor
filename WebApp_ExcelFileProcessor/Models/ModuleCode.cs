using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ExcelFileProcessor.Models
{
    [Table("ModuleCodes")]
    public class ModuleCode : ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ModuleCodeId { get; set; }

        [Display(Name = "Module Code")]
        public String ModuleCodeName { get; set; }
    }
}