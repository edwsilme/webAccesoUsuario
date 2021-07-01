using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSide.Filters;

namespace WebSide.Controllers
{
    public class HomeController : Controller
    {

        [AuthorizeUser(idrolUsuario: 1)]
        public ActionResult Index()
        {
            return View();
        }

        [AuthorizeUser(idrolUsuario: 2)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [AuthorizeUser(idrolUsuario: 3)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}