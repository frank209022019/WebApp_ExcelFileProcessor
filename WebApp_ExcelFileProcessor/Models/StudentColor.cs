using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ExcelFileProcessor.Models
{
    [Table("StudentColors")]
    public class StudentColor : ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StudentColorId { get; set; }

        [Display(Name = "Color")]
        public String ColorName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}