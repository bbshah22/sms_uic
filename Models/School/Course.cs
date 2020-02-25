using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace sms_uic.Models.Schools
{
    public class Course{
        public enum Subject{
            /**/
        }

        [Key]
        public int CourseId{get;set;}
        public String Name{get;set;}
        public String Description{get;set;}
        [NotMapped]
        public List<Course.Subject> Subjects {get;set;}
        [NotMapped]
        public List< Tuple<DateTime, DateTime>> Schedule{get;set;}
        public double Length{get;set;}//length in hours
        public DateTime Exam1{get;set;}
        public DateTime Exam2{get;set;}
        public DateTime Exam3{get;set;}
        public DateTime Exam4{get;set;}
        
    }
}