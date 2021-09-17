using System.Collections.Generic;
using WebApp_ExcelFileProcessor.Models;

namespace WebApp_ExcelFileProcessor.ViewModels
{
    public class UploadStudentScreeningResultViewModel
    {
        public List<StudentScreeningTemp> CreateList { get; set; }
        public List<StudentScreeningTemp> ExisitingList { get; set; }
        public List<StudentScreeningTemp> ErrorList { get; set; }
    }
}