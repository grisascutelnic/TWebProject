using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TWebProject.Web.Models;

namespace TWebProject.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            UserData u = new UserData();

            u.Username = "UserName";
            u.Animals = new List<Animal>
            {
                new Animal { Name = "Animal #1", ImageUrl = "/img/pisi1.png" },
                new Animal { Name = "Animal #2", ImageUrl = "/img/pisi2.png" },
                new Animal { Name = "Animal #3", ImageUrl = "/img/griCat.png" },
                new Animal { Name = "Animal #4", ImageUrl = "/img/retvierCaine.png" }
            };

            return View(u);
        }

        public ActionResult Animal()
        {

            var animal = Request.QueryString["a"];
            UserData u = TempData["UserData"] as UserData;
            if (u == null)
            {
                u = new UserData();
                u.Username = "UserName";
                u.Animals = new List<Animal>
                {
                    new Animal { Name = "Animal #1", ImageUrl = "/img/pisi1.png" },
                    new Animal { Name = "Animal #2", ImageUrl = "/img/pisi2.png" },
                    new Animal { Name = "Animal #3", ImageUrl = "/img/griCat.png" },
                    new Animal { Name = "Animal #4", ImageUrl = "/img/retvierCaine.png" }
                };

            }
            u.SingleAnimal = animal;

            return View(u);
        }

        [HttpPost]
        public ActionResult Animal(string btn)
        {
            return RedirectToAction("Animal", "Home", new { @a = btn });
        }


    }
}

