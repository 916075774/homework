﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UI.Models.Register
{
    public class IndexModel
    {
        [Required(ErrorMessage ="* 用户名不能为空")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="* 密码不能为空")]
        public string PassWord { get; set; }

        public bool RememberMe { get; set; }
        //public 
    }
}