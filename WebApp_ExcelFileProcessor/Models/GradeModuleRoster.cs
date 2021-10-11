using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_ExcelFileProcessor.Models
{
    [Table("GradeModuleRoster")]
    public class GradeModuleRoster: ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid GradeModuleRosterId { get; set; }

        [Required]
        public DayOfWeek DayOfWeek { get; set; }

        [Required]
        public Int32 GradeInt { get; set; }

        [Required]
        public Guid ModuleCodeId { get; set; }
       [ForeignKey("ModuleCodeId")]
       public virtual ModuleCode ModuleCode { get; set; }
    }
}
