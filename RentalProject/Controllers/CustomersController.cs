﻿using RentalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalProject.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customer = GetCustomers();

            return View(customer);
        }
        public ActionResult Detail(int Id)
        {
           
            var customer = GetCustomers().SingleOrDefault(c => c.Id == Id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer {Id = 1,Name = "Ramji Kasuddin"},
                new Customer {Id = 2,Name = "Yuvraj"}
            };
        }
    }
}