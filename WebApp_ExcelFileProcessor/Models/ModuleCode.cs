using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_ExcelFileProcessor.Models
{
    [Table("ModuleCodes")]
    public class ModuleCode : ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ModuleCodeId { get; set; }

        public String ModuleCodeName { get; set; }
    }
}
