using System.ComponentModel.DataAnnotations;
using System;

namespace sms_uic.Models.School
{
    class Classroom{
        [Key]
        public int ClassroomId{get;set;}
        public String Name{get;set;}
        public String Address{get;set;}
        public String location{get;set;}
        
    }
}