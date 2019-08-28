using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet1.Controllers
{
    public class coursesController : Controller
    {
        // GET: courses
        public ActionResult Index()
        {
            return View();
        }
    }
}