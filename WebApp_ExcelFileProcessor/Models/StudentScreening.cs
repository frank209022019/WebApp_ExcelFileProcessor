﻿using System;
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
        public Boolean GeneralSenseWellbeing { get; set; }
        public Boolean WearingAMask { get; set; }
        public Boolean HighRiskTravel14Days { get; set; }
        public Boolean CloseContactInfectedPerson { get; set; }
        public Boolean CloseContactProbableInfectedPerson { get; set; }
        public Boolean AttendHealthFacility14Days { get; set; }
        public Boolean AdmittedSeverPneumonia { get; set; }
        public Boolean SufferFromChronicDisease { get; set; }
        public Boolean AnyOfTheFollowingSymptoms { get; set; }
        public DateTime ScrenningTimeStamp { get; set; }

        public Guid StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }
    }
}