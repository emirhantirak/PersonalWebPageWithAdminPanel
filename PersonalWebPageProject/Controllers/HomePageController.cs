using PersonalWebPageProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebPageProject.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage

        Context context = new Context();
        public ActionResult Index()
        {
            var value = context.Homepages.ToList();
            return View(value);
        }
        public PartialViewResult IconList()
        {
            var value = context.Icons.ToList();
            return PartialView(value);
        }
    }
}