using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_ExcelFileProcessor.ViewModels
{
    public class FileDetailsViewModel
    {
        public String FileName { get; set; }
        public String TotalRows { get; set; }
        public String TotalColumns { get; set; }
        public DateTime DateUploaded { get; set; } = DateTime.Now;
    }
}
