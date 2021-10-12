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

        public Guid? MondayModuleCodeId { get; set; }

        [ForeignKey("MondayModuleCodeId")]
        public virtual ModuleCode MondayModuleCode { get; set; }

        public String MondaySubjString { get; set; }

        public Guid? TuesdayModuleCodeId { get; set; }

        [ForeignKey("TuesdayModuleCodeId")]
        public virtual ModuleCode TuesdayModuleCode { get; set; }

        public String TuesdaySubjString { get; set; }

        public Guid? WednesdayModuleCodeId { get; set; }

        [ForeignKey("WednesdayModuleCodeId")]
        public virtual ModuleCode WednesdayModuleCode { get; set; }

        public String WednesdaySubjString { get; set; }

        public Guid? ThursdayModuleCodeId { get; set; }

        [ForeignKey("ThursdayModuleCodeId")]
        public virtual ModuleCode ThursdayModuleCode { get; set; }

        public String ThursdaySubjString { get; set; }

        public Guid? FridayModuleCodeId { get; set; }

        [ForeignKey("FridayModuleCodeId")]
        public virtual ModuleCode FridayModuleCode { get; set; }

        public String FridaySubjString { get; set; }

        public Guid? Extra1ModuleCodeId { get; set; }

        [ForeignKey("Extra1ModuleCodeId")]
        public virtual ModuleCode Extra1ModuleCode { get; set; }

        public String Extra1SubjString { get; set; }

        public Guid? Extra2ModuleCodeId { get; set; }

        [ForeignKey("Extra2ModuleCodeId")]
        public virtual ModuleCode Extra2ModuleCode { get; set; }

        public String Extra2SubjString { get; set; }

        public Guid? Extra3ModuleCodeId { get; set; }

        [ForeignKey("Extra3ModuleCodeId")]
        public virtual ModuleCode Extra3ModuleCode { get; set; }

        public String Extra3SubjString { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> GenderList { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> ClassList { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> ModuleList { get; set; }

        [NotMapped]
        public IEnumerable<SelectListItem> GroupList { get; set; }
    }
}