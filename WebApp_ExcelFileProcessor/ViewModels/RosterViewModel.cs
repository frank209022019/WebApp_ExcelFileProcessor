using System;

namespace WebApp_ExcelFileProcessor.ViewModels
{
    public class RosterViewModel
    {
        public String RosterItemId { get; set; }
        public Int32 GradeNumber { get; set; }
        public String Grade { get; set; }
        public Int32 DayNumber { get; set; }
        public String DayOfWeek { get; set; }
        public String ModuleCode { get; set; }
        public String DateCreated { get; set; }
    }
}