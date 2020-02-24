using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace sms_uic.Models.School
{
    class Student{
        [Key]
        public int StudentId{get;set;}
        public String FirstName{get;set;}
        public String LastName{get;set;}
        [ForeignKey("Guardian")]
        [Column(Order = 1)]
        public int GuardianId{get;set;}
        public DateTime DateOfBirth {get;set;}
        public int GradeLevel; //between 0 < level < 13
        [ForeignKey("School")]
        [Column(Order = 1)]
        public int SchoolId {get;set;}
    }
}