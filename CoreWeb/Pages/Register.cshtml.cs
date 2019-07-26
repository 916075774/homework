using CoreWeb.Pages.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using System.ComponentModel.DataAnnotations;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class RegisterModel : _LayoutModel
    {
        public Constellation UserConstellation { get; set; }
        public Register Register { get; set; }

        private UserService _userService;
        public RegisterModel()
        {
            _userService = new UserService();
        }

        public override void OnGet()
        {

        }
        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            if (_userService.HasExist(Register.Name))
            {
                ModelState.AddModelError("Register.Name", "* 用户名已存在");
                return;
            }
            _userService.Register(Register.Name, Register.Password);

            Response.Redirect("Welcome");
        }
    }
    public class Register
    {
        [Required(ErrorMessage = "* 用户名必须填写")]
        [MaxLength(25, ErrorMessage = "* 用户名长度必须在2-25之间")]
        [MinLength(2, ErrorMessage = "* 用户名长度必须在2-25之间")]
        public string Name { get; set; }

        [Required(ErrorMessage = "* 密码必须填写")]
        [MaxLength(25, ErrorMessage = "* 密码长度必须在2-25之间")]
        [MinLength(2, ErrorMessage = "* 密码必须在2-25之间")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="* 两次输入密码不一致")]
        public string ConfirmPassword { get; set; }
    }
    public enum Constellation
    {
        [Display(Name = "金牛座")]
        Taurus,
        [Display(Name = "处女座")]
        Virgo,
        [Display(Name = "天秤座")]
        Libra,
    }

}