using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace sms_uic.Models.Student
{
    class StudentCourse{
        [Key]
        public int StudentCourseId{get;set;}
        [ForeignKey("Student")]
        [Column(Order = 1)]
        public int StudentId {get;set;}
        [ForeignKey("Course")]
        [Column(Order = 1)]
        public int CourseId {get;set;}
    }
}