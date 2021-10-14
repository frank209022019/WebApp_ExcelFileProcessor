using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp_ExcelFileProcessor.Models
{
    [Table("StudentTemps")]
    public class StudentTemp : ModelBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid StudentTempId { get; set; }

        public String GradeString { get; set; }
        public Int32? StudentNr { get; set; }
        public String QRCode { get; set; }
        public String LastName { get; set; }
        public String FirstName { get; set; }

        public Guid? GenderId { get; set; }

        [ForeignKey("GenderId")]
        public virtual Gender Gender { get; set; }

        public Guid? StudentClassId { get; set; }

        [ForeignKey("StudentClassId")]
        public virtual StudentClass StudentClass { get; set; }

        public Guid? StudentGroupId { get; set; }

        [ForeignKey("StudentGroupId")]
        public virtual StudentGroup StudentGroup { get; set; }

        public Guid? MondayModuleCodeId { get; set; }

        [ForeignKey("MondayModuleCodeId")]
        public virtual ModuleCode MondayModuleCode { get; set; }

        public String MondaySubjString { get; set; }

        public Guid? TuesdayModuleCodeId { get; set; }

        [ForeignKey("TuesdayModuleCodeId")]
        public virtual ModuleCode TuesdayModuleCode { get; set; }

        public String TuesdaySubjString { get; set; }

        public Guid? WednesdayModuleCodeId { get; set; }

        [ForeignKey("WednesdayModuleCodeId")]
        public virtual ModuleCode WednesdayModuleCode { get; set; }

        public String WednesdaySubjString { get; set; }

        public Guid? ThursdayModuleCodeId { get; set; }

        [ForeignKey("ThursdayModuleCodeId")]
        public virtual ModuleCode ThursdayModuleCode { get; set; }

        public String ThursdaySubjString { get; set; }

        public Guid? FridayModuleCodeId { get; set; }

        [ForeignKey("FridayModuleCodeId")]
        public virtual ModuleCode FridayModuleCode { get; set; }

        public String FridaySubjString { get; set; }

        public Guid? Extra1ModuleCodeId { get; set; }

        [ForeignKey("Extra1ModuleCodeId")]
        public virtual ModuleCode Extra1ModuleCode { get; set; }

        public String Extra1SubjString { get; set; }

        public Guid? Extra2ModuleCodeId { get; set; }

        [ForeignKey("Extra2ModuleCodeId")]
        public virtual ModuleCode Extra2ModuleCode { get; set; }

        public String Extra2SubjString { get; set; }

        public Guid? Extra3ModuleCodeId { get; set; }

        [ForeignKey("Extra3ModuleCodeId")]
        public virtual ModuleCode Extra3ModuleCode { get; set; }

        public String Extra3SubjString { get; set; }

        public Int32? RowNumber { get; set; }
        public Char? RowType { get; set; }
    }
}