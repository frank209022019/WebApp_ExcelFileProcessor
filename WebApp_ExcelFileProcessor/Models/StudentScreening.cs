using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ExcelFileProcessor.Models
{
    [Table("StudentScreening")]
    public class StudentScreening : ModelBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid StudentScreeningId { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        public String QRCodeId { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        public String Temp { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        public String GeneralSenseWellbeing { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        public String WearingAMask { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        public String HighRiskTravel14Days { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        public String CloseContactInfectedPerson { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        public String CloseContactProbableInfectedPerson { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        public String AttendHealthFacility14Days { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        public String AdmittedSeverPneumonia { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        public String SufferFromChronicDisease { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        public String AnyOfTheFollowingSymptoms { get; set; }

        [Required(ErrorMessage = "This is a required field.")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = false)]
        public DateTime ScreeningTimeStamp { get; set; }

        public Guid StudentId { get; set; }
        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        [NotMapped]
        public String StudentDisplayName { get; set; }

        [NotMapped]
        public List<SelectListItem> StudentList { get; set; }
    }
}