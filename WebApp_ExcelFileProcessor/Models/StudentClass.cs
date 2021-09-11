using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ExcelFileProcessor.Models
{
    [Table("StudentClasses")]
    public class StudentClass : ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StudentClassId { get; set; }

        public Int32 GradeInt { get; set; }
        public Char ClassChar { get; set; }
        public String DisplayName { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}