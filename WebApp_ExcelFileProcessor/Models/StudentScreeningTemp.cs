using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ExcelFileProcessor.Models
{
    [Table("StudentScreeningTemps")]
    public class StudentScreeningTemp : ModelBase
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid StudentScreeningTempId { get; set; }

        public String QRCodeId { get; set; }
        public String Temp { get; set; }
        public String GeneralSenseWellbeing { get; set; }
        public String WearingAMask { get; set; }
        public String HighRiskTravel14Days { get; set; }
        public String CloseContactInfectedPerson { get; set; }
        public String CloseContactProbableInfectedPerson { get; set; }
        public String AttendHealthFacility14Days { get; set; }
        public String AdmittedSeverPneumonia { get; set; }
        public String SufferFromChronicDisease { get; set; }
        public String AnyOfTheFollowingSymptoms { get; set; }
        public DateTime? ScreeningTimeStamp { get; set; }

        public Int32? RowNumber { get; set; }
        public Char? RowType { get; set; }

        public Guid? StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}