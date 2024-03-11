using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TWebProject.Models;

namespace TWebProject.Web.Controllers
{
    public class HomeController : Controller
    {
    // GET: Home
    public ActionResult Index()
        {
            UserData u = new UserData();
            u.Username = ;
            u.Products = new List<string> {};
        
        return View(u);
        }
    }
