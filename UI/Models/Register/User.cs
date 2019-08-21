 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UI.Models.User
{
    public class User
    {
        [Required(ErrorMessage = "* 用户名不能为空")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "* 密码不能为空")]
        //[DataType(DataType.Password)]
        public string PassWord { get; set; }
        public int Id { get; set; }

        [NotMapped]
        [Compare("PassWord", ErrorMessage = "* 两次输入密码不一致")]
        public string ConfirmPassWord { get; set; }
        [NotMapped]
        public bool? IsMale { get; set; }
        [NotMapped]
        public string SelfIntroduction { get; set; }
        [NotMapped]
        public Cities? InCity { get; set; }
        [NotMapped]
        public bool RememberMe { get; set; }
    }

    public enum Cities
    {
        ChongQing,
        ChengDu,
        [Display(Name = "广州")]
        GuangZhou
    }
}