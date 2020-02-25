using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace sms_uic.Models.Student
{
    public class StudentRecords{
        [Key]
        public int StudentRecordsId{get;set;}
        [ForeignKey("Student")]
        [Column(Order = 1)]
        public int StudentId {get;set;}
        public String Records {get;set;}
        public String EncodingVersion {get;set;}
    }
}