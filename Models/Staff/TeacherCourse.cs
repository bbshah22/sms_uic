using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sms_uic.Models.Staff
{
    class TeacherCourse{
        [Key]
        public int TeacherCourseId{get;set;}
        [ForeignKey("Teacher")]
        [Column(Order = 1)]
        public int TeacherId {get;set;}
        [ForeignKey("Course")]
        [Column(Order = 1)]
        public int CourseId {get;set;}
    }
}