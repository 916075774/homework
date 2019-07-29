using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class UserRepository
    {
        private SQLContext _sqlContext;
        public UserRepository()
        {
            _sqlContext = new SQLContext();
        }

        public void Save(User user)
        {
            _sqlContext._users.Add(user);
            _sqlContext.SaveChanges();
        }

        public User GetByName(string name)
        {
            return _sqlContext._users.Where(u => u.Name == name).SingleOrDefault();
        }

        public User GetById(int id)
        {
            return _sqlContext._users.Where(u => u.Id == id).SingleOrDefault();

        }
    }
}
