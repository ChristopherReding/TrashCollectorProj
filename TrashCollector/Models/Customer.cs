using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string WeeklyPickupDay { get; set; }
        public DateTime? OneTimePickup { get; set; }
        public DateTime? StartServiceHold { get; set; }
        public DateTime? EndServiceHold { get; set; }
        public string StreetAddress { get; set; }
        public int ZipCode { get; set; }
        public bool ServiceIsActive { get; set; }
        public double AccountBalance { get; set; }

        [ForeignKey("IdentityUser")]
        public string IdentityUserId { get; set; }
        public IdentityUser IdentityUser { get; set; }

        
        
        
    }
}
