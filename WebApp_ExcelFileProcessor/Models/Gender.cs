using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ExcelFileProcessor.Models
{
    [Table("Genders")]
    public class Gender : ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid GenderId { get; set; }

        [Display(Name = "Gender")]
        public String GenderName { get; set; }
        public Char GenderChar { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}