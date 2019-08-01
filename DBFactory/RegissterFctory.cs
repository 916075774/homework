using BLL;
using BLL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
    internal class RegissterFctory
    {
        internal static User XiaoYu, XueMingLin;

        private static UserRepository _userRepository;
        static RegissterFctory()
        {
            _userRepository = new UserRepository();
        }

        internal static void Create()
        {
            XiaoYu = register("小屿");
            XueMingLin = register("薛明林");
        }

        private static User register(string name)
        {
            User user = new User { Name = name, Password = Helper.PassWord };
            user.Register();
            _userRepository.Save(user);

            return user;
        }

    }
}
