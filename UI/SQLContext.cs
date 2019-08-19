using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using UI.Models.User;

namespace UI
{
    public class SQLContext : DbContext
    {
        public SQLContext() : base("constr")
        {

        }
        public DbSet<User> Users { get; set; }
        //public DbSet<User> Articles { get; set; }
        //public DbSet<User> Articles { get; set; }
    }
}