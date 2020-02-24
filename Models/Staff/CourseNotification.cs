using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace sms_uic.Models.Student
{
    class CourseNotifiation{
        [Key]
        public int CourseNotifiationId{get;set;}
        [ForeignKey("Course")]
        [Column(Order = 1)]
        public int CourseId {get;set;}
        public DateTime Time {get;set;}
        public String Notification {get;set;}
    }
}