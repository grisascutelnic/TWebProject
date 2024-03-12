using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TWebProject.Web.Models
{
    public class UserData
    {
        public string Username { get; set; }

        public List<Animal> Animals { get; set; }

        public string SingleAnimal { get; internal set; }



    }

    

public class Animal
    {

        public string Name { get; set; }
        public string ImageUrl { get; set; }

    }
}