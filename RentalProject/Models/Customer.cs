﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RentalProject.Models
{
    public class Customer
    {   

        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public String Name { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime? BirthDate { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}