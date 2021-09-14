using System.Collections.Generic;
using WebApp_ExcelFileProcessor.Models;

namespace WebApp_ExcelFileProcessor.ViewModels
{
    public class UploadBaseClassResultViewModel
    {
        public List<StudentTemp> CreateList { get; set; }
        public List<StudentTemp> UpdateList { get; set; }
        public List<StudentTemp> ErrorList { get; set; }

        public UploadBaseClassResultViewModel()
        {
            CreateList = new List<StudentTemp>();
            UpdateList = new List<StudentTemp>();
            ErrorList = new List<StudentTemp>();
        }
    }
}