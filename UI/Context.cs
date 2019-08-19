using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UI.Models.User;

namespace UI
{
    public class Current
    {
        public static SQLContext db = new SQLContext();
        public static SQLContext _db
        {
            get
            {
                db = db ?? new SQLContext();
                return db;
            }
        }

        //public static User CurrentUser
        //{
        //    get
        //    {
        //        HttpCookie cookUser = HttpContext.Current.Request.Cookies[ConstRep.COOKIE_USER];
        //        if (cookUser != null)
        //        {
        //            User user = GetbyName(cookUser[ConstRep.COOKIE_USERNAME]);
        //            if (user != null)
        //            {
        //                if (user.PassWord == cookUser[ConstRep.COOKIE_PASSWORD])
        //                {
        //                    return user;
        //                }
        //            }
        //        }
        //        return null;
        //    }
        //}

        //private static User GetbyName(string userName)
        //{
        //    return _db.Users.Where(u => u.UserName == userName).SingleOrDefault();
        //}
    }
}