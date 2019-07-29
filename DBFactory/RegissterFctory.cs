using BLL;
using SRV;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBFactory
{
    internal class RegissterFctory
    {
        internal static User XiaoYu, XueMingLin;

        private static UserService _userService;
        static RegissterFctory()
        {
            _userService = new UserService();
        }


        internal static void Create()
        {
            XiaoYu = _userService.Register("小屿", Helper.PassWord);
            XueMingLin = _userService.Register("薛明林", Helper.PassWord);
        }

    }
}
