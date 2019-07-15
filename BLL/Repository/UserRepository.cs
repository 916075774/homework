using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL.Repository
{
    public class UserRepository
    {
        private static IList<User> _users;

        public void Save(User user)
        {
            _users = _users ?? new List<User>();
            _users.Add(user);
        }

        public User GetByName(string name)
        {
            return _users == null ? null
                : _users.Where(u => u.Name == name).SingleOrDefault();
        }

    }
}
