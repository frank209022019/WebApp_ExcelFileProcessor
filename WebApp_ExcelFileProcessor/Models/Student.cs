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

        [Display(Name = "Monday Module Code")]
        public Guid? MondayModuleCodeId { get; set; }

        [ForeignKey("MondayModuleCodeId")]
        public virtual ModuleCode MondayModuleCode { get; set; }

        [Display(Name = "Monday Subject")]
        public String MondaySubjString { get; set; }

        [Display(Name = "Tuesday Module Code")]
        public Guid? TuesdayModuleCodeId { get; set; }

        [ForeignKey("TuesdayModuleCodeId")]
        public virtual ModuleCode TuesdayModuleCode { get; set; }

        [Display(Name = "Tuesday Subject")]
        public String TuesdaySubjString { get; set; }

        [Display(Name = "Wednesday Module Code")]
        public Guid? WednesdayModuleCodeId { get; set; }

        [ForeignKey("WednesdayModuleCodeId")]
        public virtual ModuleCode WednesdayModuleCode { get; set; }

        [Display(Name = "Wedneday Subject")]
        public String WednesdaySubjString { get; set; }

        [Display(Name = "Thursday Module Code")]
        public Guid? ThursdayModuleCodeId { get; set; }

        [ForeignKey("ThursdayModuleCodeId")]
        public virtual ModuleCode ThursdayModuleCode { get; set; }

        [Display(Name = "Thursday Subject")]
        public String ThursdaySubjString { get; set; }

        [Display(Name = "Friday Module Code")]
        public Guid? FridayModuleCodeId { get; set; }

        [ForeignKey("FridayModuleCodeId")]
        public virtual ModuleCode FridayModuleCode { get; set; }

        [Display(Name = "Friday Subject")]
        public String FridaySubjString { get; set; }

        [Display(Name = "Extra 1 Module Code")]
        public Guid? Extra1ModuleCodeId { get; set; }

        [ForeignKey("Extra1ModuleCodeId")]
        public virtual ModuleCode Extra1ModuleCode { get; set; }

        [Display(Name = "Extra 1 Subject")]
        public String Extra1SubjString { get; set; }

        [Display(Name = "Extra 2 Module Code")]
        public Guid? Extra2ModuleCodeId { get; set; }

        [ForeignKey("Extra2ModuleCodeId")]
        public virtual ModuleCode Extra2ModuleCode { get; set; }

        [Display(Name = "Extra 2 Subject")]
        public String Extra2SubjString { get; set; }

        [Display(Name = "Extra 3 Module Code")]
        public Guid? Extra3ModuleCodeId { get; set; }

        [ForeignKey("Extra3ModuleCodeId")]
        public virtual ModuleCode Extra3ModuleCode { get; set; }

        [Display(Name = "Extra 3 Subject")]
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