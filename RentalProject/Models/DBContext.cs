﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace RentalProject.Models
{
    public class DBContext : DbContext
    {
        public DBContext() : base("dbconnection")
        {

        }
        public DbSet<Customer> Customers { get; set; } // My domain models
        public DbSet<Movie> Movies { get; set; }// My domain models
        public DbSet<MembershipType> MembershipTypes { get; set; }

        public DbSet<Genre> Genres { get; set; }
    }
}