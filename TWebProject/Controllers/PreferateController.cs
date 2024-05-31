using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TWebProject.Controllers
{
    public class PreferateController : Controller
    {
        // GET: Preferate
        public ActionResult Index()
        {
            ViewBag.ActivePage = "Preferate";
            return View();
        }
    }
}