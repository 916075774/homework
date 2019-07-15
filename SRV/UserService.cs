using BLL;
using BLL.Repository;
using System;

namespace SRV
{
    public class UserService
    {
        private UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }

        public void Register(string username, string password)
        {
            User user = new User { Name = username, Password = password };
            user.Register();
            _userRepository.Save(user);
        }

        public bool HasExist(string username)
        {
            return _userRepository.GetByName(username) != null;
        }
    }
}
