using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWebProject.Domain.Entitie.User.DbModel;

namespace TWebProject.BusinessLogic.BDContext.User
{
    public class UserContext : DbContext
    {
        public UserContext() : base("name=TWebProject") { }


        public virtual DbSet<Domain.Entitie.User.DbModel.User> Users { get; set; }
    }
}
