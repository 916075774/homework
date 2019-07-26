using BLL;
using SRV;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
    internal class RegissterFctory
    {

        private static UserService _userService;
        static RegissterFctory()
        {
            _userService = new UserService();
        }


        internal static void Create()
        {
            _userService.Register("小屿", Helper.PassWord);
            _userService.Register("薛明林", Helper.PassWord);
        }

    }
}
