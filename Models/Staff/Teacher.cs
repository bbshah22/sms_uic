using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using sms_uic.Models.School;

namespace sms_uic.Models.Staff
{
    class Teacher:IdentityUser{
        [Key]
        public int TeacherId{get;set;}
        public DateTime DateOfBirth {get;set;}
        [NotMapped]
        public List<int> GradeLevels; //between 0 < level < 13
        [ForeignKey("School")]
        [Column(Order = 1)]
        public int SchoolId {get;set;}
        [NotMapped]
        public List<Course.Subject> Subjects{get;set;}
    }
}