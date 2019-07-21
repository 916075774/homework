using System;
using System.Security.Cryptography;
using System.Text;

namespace BLL
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public User InviteBy { get; set; }

        public void Register()
        {
            if (InviteBy != null)
            {

            }
            Password = GetMd5Hash(Password);
        }

        public static string GetMd5Hash(string input)
        {
            //加盐
            const string _salt = "%3&Xy";

            using (MD5 md5Hash = MD5.Create())
            {
                //将字符串转换成byte[]
                //进行MD5加密运算
                byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input + _salt));

                //StringBuilder 提高性能（也提高了可读性）
                StringBuilder stringBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    stringBuilder.Append(data[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }
    }
}
