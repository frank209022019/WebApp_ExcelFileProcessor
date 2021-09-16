using System;
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
        public DateTime ScrenningTimeStamp { get; set; }

        public Guid StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}