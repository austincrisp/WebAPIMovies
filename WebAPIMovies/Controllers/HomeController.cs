using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebAPIMovies.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Movie()
        {
            ViewBag.Title = "Movie List";

            return View();
        }

        public ActionResult Review()
        {
            ViewBag.Title = "Review List";

            return View();
        }

        public ActionResult Person()
        {
            ViewBag.Title = "User List";

            return View();
        }
    }
}
