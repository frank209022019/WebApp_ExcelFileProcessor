using Microsoft.AspNetCore.Mvc.Rendering;
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

        [Display(Name = "Day of Week")]
        [Required]
        public DayOfWeek DayOfWeek { get; set; }

        [Display(Name = "Grade")]
        [Required]
        public Int32 GradeInt { get; set; }

        [Display(Name = "Module Code")]
        [Required]
        public Guid ModuleCodeId { get; set; }
       [ForeignKey("ModuleCodeId")]
       public virtual ModuleCode ModuleCode { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> ModuleCodeList { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> GradeList { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> DayOfWeekList { get; set; }
    }
}
