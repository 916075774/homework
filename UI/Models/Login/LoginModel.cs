using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UI.Models.Login
{
    public class LoginModel
    {
        [Required(ErrorMessage = "* 用户名不能为空")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "* 密码不能为空")]
        public string PassWord { get; set; }
        
        [NotMapped]
        [Required(ErrorMessage = "* 验证码不能为空")]
        public string Captcha { get; set; }
    }
}