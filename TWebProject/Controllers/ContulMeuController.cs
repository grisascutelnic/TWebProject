using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TWebProject.Controllers
{
    public class ContulMeuController : Controller
    {
        // GET: ContulMeu
        public ActionResult Index()
        {
            ViewBag.ActivePage = "ContulMeu";
            return View();
        }
    }
}