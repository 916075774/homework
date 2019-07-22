using System;
using System.Collections.Generic;
using System.Text;

namespace SRV.Model
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Md5PassWord { get; set; }
    }
}
