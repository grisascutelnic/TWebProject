﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWebProject.Domain.Entitie.User
{
    public class ULoginData
    {
        public string  Credential { get; set; }
        public string Password { get; set; }
        public string Ip { get; set; }
        public DateTime LoginTime { get; set; }
    }
}
