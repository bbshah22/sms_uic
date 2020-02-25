using System.ComponentModel.DataAnnotations;
using System;


namespace sms_uic.Models.Schools
{
    public class School{
        [Key]
        public int SchoolId{get;set;}
        public String Name{get;set;}
        public String Description{get;set;}
        public String Location{get;set;}
        
    }
}