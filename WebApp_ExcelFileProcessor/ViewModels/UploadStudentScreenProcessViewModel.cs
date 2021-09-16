using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp_ExcelFileProcessor.Models;

namespace WebApp_ExcelFileProcessor.ViewModels
{
    public class UploadStudentScreenProcessViewModel
    {
        public String ResponseId { get; set; }

        public Boolean ResponseValid { get; set; }

        public DateTime ResponseDateTime { get; set; }

        public String ResponseMessage { get; set; }

        public List<StudentScreeningTemp> NewScreeningList { get; set; }
        public List<StudentScreeningTemp> ExisitingScreeningList { get; set; }
        public List<StudentScreeningTemp> ErrorScreeningList { get; set; }
    }
}
