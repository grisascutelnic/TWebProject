using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TWebProject.Controllers
{
    public class ManagementController : Controller
    {
        // GET: Management
        public ActionResult Index()
        {
            ViewBag.ActivePage = "Management";
            return View();
        }

        public ActionResult Edit()
        {
            ViewBag.ActivePage = "Management";
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.ActivePage = "Management";
            return View();
        }

        public ActionResult Delete(string name)
        {
            ViewBag.ActivePage = "Management";
            ViewBag.Name = name;
            return View();
        }

    }
}