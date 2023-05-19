using ASPDemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPDemoMVC.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            //Return only that message inside brackets
            //return Content("Hello test");

            //Retrun error 404 not found
            //return HttpNotFound();

            //Redirect to specify action (controller and route) 
            //return RedirectToAction("Index","Home", new { page=1, sortyBy = "Name" });

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        [Route("movies/realeased/{year}/{month:regex(\\d{2}:range(1,12))}")]
        public ActionResult ByReleaseYear(int year, int month) 
        {
            return Content(year + "/" + month);
        }
    }
}