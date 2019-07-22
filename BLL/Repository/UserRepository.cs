using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class UserRepository : DbContext
    {
        public DbSet<User> _users { get; set; }

        public void Save(User user)
        {
            _users.Add(user);
            SaveChanges();
        }

        public User GetByName(string name)
        {
            return _users.Where(u => u.Name == name).SingleOrDefault();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=17bang;Integrated Security=True;";
            optionsBuilder.UseSqlServer(connectionString);

        }

        public User GetById(int id)
        {
            return _users.Where(u => u.Id == id).SingleOrDefault();

        }
    }
}
