using PersonalWebPageProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PersonalWebPageProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        Context context = new Context();

        [Authorize]
        public ActionResult Index()
        {
            var value = context.Homepages.ToList();
            return View(value);
        }
        public ActionResult GetHomePage(int id)
        {
            var hp = context.Homepages.Find(id);
            return View("GetHomePage", hp);
        }
        public ActionResult UpdateHomePage(Homepage hPage)
        {
            var hpNew = context.Homepages.Find(hPage.ID);
            hpNew.Name = hPage.Name;
            hpNew.Profile = hPage.Profile;
            hpNew.Title = hPage.Title;
            hpNew.Definition = hPage.Definition;
            hpNew.Contact = hPage.Contact;

            context.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult GetIcons()
        {
            var value = context.Icons.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult AddIcon()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddIcon(Icon icon)
        {
            context.Icons.Add(icon);
            context.SaveChanges();
            return RedirectToAction("GetIcons");
        }
        public ActionResult GetanIcon(int id)
        {
            var ic = context.Icons.Find(id);
            return View("GetanIcon", ic);
        }
        public ActionResult UpdateIcon(Icon icon)
        {
            var iconNew = context.Icons.Find(icon.ID);
            iconNew.IconPic = icon.IconPic;
            iconNew.Link = icon.Link;

            context.SaveChanges();

            return RedirectToAction("GetIcons");
        }

        public ActionResult DeleteIcon(int id)
        {
            var value = context.Icons.Find(id);
            context.Icons.Remove(value);

            context.SaveChanges();

            return RedirectToAction("GetIcons");
        }
    }
}