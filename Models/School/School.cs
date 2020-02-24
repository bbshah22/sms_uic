using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;

namespace sms_uic.Models.School
{
    class School{
        [Key]
        public int SchoolId{get;set;}
        public String Name{get;set;}
        public String Description{get;set;}
        public String Location{get;set;}
        
    }
}