using BLL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
  public  class Db:DbContext
    {
        public DbSet<User> _users { get; set; }
    }
}
