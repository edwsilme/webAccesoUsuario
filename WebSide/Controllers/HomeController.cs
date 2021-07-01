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


        [AuthorizeUser(idOperacion: 1)]
        public ActionResult Index()
        {
            return View();
        }

        [AuthorizeUser(idOperacion: 1)]
        public ActionResult About()
        {
            return View();
        }

        [AuthorizeUser(idOperacion: 2)]
        public ActionResult Users()
        {
            return View();
        }

        [AuthorizeUser(idOperacion: 1)]
        public ActionResult Client()
        {
            return View();
        }


        [AuthorizeUser(idOperacion: 1)]
        public ActionResult Contact()
        {
            return View();
        }


    }

}