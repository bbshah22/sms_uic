using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace sms_uic.Models.Student
{
    public class StudentAttendance{
        [Key]
        public int StudentAttendanceId{get;set;}
        [ForeignKey("Student")]
        [Column(Order = 1)]
        public int StudentId {get;set;}
        public DateTime Time {get;set;}
    }
}