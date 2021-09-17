using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_ExcelFileProcessor.ViewModels
{
    public class StudentScreeningViewModel
    {
        public String StudentScreeningId { get; set; }
        public String QRCodeId { get; set; }

        public String StudentId { get; set; }
        public String StudentDisplayName { get; set; }
        public String StudentClass { get; set; }
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
        public String ScreeningTimeStamp { get; set; }
    }
}
