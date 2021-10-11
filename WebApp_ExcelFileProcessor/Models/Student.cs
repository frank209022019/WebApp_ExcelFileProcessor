using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ExcelFileProcessor.Models
{
    [Table("Students")]
    public class Student : ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StudentId { get; set; }

        [Display(Name = "Student #")]
        [Required]
        public Int32 StudentNr { get; set; }

        [Display(Name = "QR Code")]
        [Required]
        public String QRCode { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public String LastName { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public String FirstName { get; set; }

        [Display(Name = "Gender")]
        [Required]
        public Guid GenderId { get; set; }

        [ForeignKey("GenderId")]
        [Required]
        public virtual Gender Gender { get; set; }

        [Display(Name = "Color")]
        [Required]
        public Guid StudentColorId { get; set; }

        [ForeignKey("StudentColorId")]
        public virtual StudentColor StudentColor { get; set; }

        [Display(Name = "Class")]
        [Required]
        public Guid StudentClassId { get; set; }

        [ForeignKey("StudentClassId")]
        public virtual StudentClass StudentClass { get; set; }

        [Display(Name = "Group")]
        [Required]
        public Guid StudentGroupId { get; set; }

        [ForeignKey("StudentGroupId")]
        public virtual StudentGroup StudentGroup { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> GenderList { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> ClassList { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> ColorList { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> GroupList { get; set; }
    }
}