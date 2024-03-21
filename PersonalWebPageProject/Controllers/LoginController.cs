using PersonalWebPageProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace PersonalWebPageProject.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        Context context = new Context();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin user)
        {
            var info = context.Admins.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.Username, false);
                Session["Username"] = info.Username.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}