using System;

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
        }
    }
}
