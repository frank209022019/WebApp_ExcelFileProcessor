using System;
using System.ComponentModel.DataAnnotations.Schema;
using WebApp_ExcelFileProcessor.Models;

namespace WebApp_ExcelFileProcessor.ViewModels
{
    public class AbsenteeViewModel
    {
        public Guid StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Student { get; set; }

        public DateTime AbsentDateTime { get; set; }
    }
}