﻿using RentalProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RentalProject.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() {Name = "Deadpool !!" };
            return View(movie);
        }
        public ActionResult Edit(int Id)
        {
            return Content("Id = " +Id);
        }
    }
}