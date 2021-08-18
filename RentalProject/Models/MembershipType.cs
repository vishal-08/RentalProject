﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentalProject.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public short SignUpfee { get; set; }
        public byte DurationInMonth { get; set; }
        public byte DiscountRate { get; set; }
    }
}