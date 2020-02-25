using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using sms_uic.Models.Staff;

namespace sms_uic.Models.Schools
{
    public class TeacherAttendance{
        [Key]
        public int TeacherAttendanceId{get;set;}

        [ForeignKey("Teacher")]
        [Column(Order = 1)]
        public int TeachertId {get;set;}
        public DateTime Time {get;set;}
    }
}