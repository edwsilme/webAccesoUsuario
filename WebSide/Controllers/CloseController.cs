using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSide.Controllers
{
    public class CloseController : Controller
    {
        public ActionResult Logoff()
        {
            Session["User"] = null;
            return RedirectToAction("Login", "Acceso");
        }
    }
}