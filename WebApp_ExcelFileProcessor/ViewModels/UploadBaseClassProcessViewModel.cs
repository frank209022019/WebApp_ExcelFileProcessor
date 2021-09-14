using System;
using System.Collections.Generic;
using WebApp_ExcelFileProcessor.Models;

namespace WebApp_ExcelFileProcessor.ViewModels
{
    public class UploadBaseClassProcessViewModel
    {
        public String ResponseId { get; set; }

        public Boolean ResponseValid { get; set; }

        public DateTime ResponseDateTime { get; set; }

        public String ResponseMessage { get; set; }

        public List<StudentTemp> SuccessList { get; set; }
        public List<StudentTemp> ErrorList { get; set; }
    }
}