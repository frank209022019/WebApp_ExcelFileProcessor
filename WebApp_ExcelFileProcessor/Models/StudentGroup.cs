using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ExcelFileProcessor.Models
{
    [Table("StudentGroups")]
    public class StudentGroup : ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StudentGroupId { get; set; }

        public Char GroupChar { get; set; }
        public Int32 GroupInt { get; set; }

        [Display(Name = "Group")]
        public String DisplayName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}