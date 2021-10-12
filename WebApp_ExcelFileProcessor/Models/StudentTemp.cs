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

        public Int32? RowNumber { get; set; }
        public Char? RowType { get; set; }
    }
}