using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace sms_uic.Models.Schools
{
    public class Guardia :IdentityUser{
        [Key]
        public int GuardiaId{get;set;}
        public DateTime DateOfBirth {get;set;}
        public String Location{get;set;}
        public double Balance{get;set;}

    }
}