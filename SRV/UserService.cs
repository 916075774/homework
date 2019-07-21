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

        public UserModel GetLoginInfo(string userName)
        {
            User user = _userRepository.GetByName(userName);
            if (user == null)
            {
                return null;
            }
            else
            {
                UserModel model = new UserModel();

                model.Id = user.Id;
                model.Md5Password = user.Password;

                return model;
            }

        }

        public bool PasswordCorrect(string rawPassword, string MD5Password)
        {
            return User.GetMd5Hash(rawPassword) == MD5Password;
        }

        public object GeyByName(string userName)
        {
            throw new NotImplementedException();
        }
    }

    public class UserModel
    {
        public int Id { get; set; }
        public string Md5Password { get; set; }
    }
}
