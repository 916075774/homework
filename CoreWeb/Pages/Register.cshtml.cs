﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRV;
using System.ComponentModel.DataAnnotations;

namespace CoreWeb.Pages
{
    [BindProperties]
    public class RegisterModel : PageModel
    {
        private UserService _userService;
        public RegisterModel()
        {
            _userService = new UserService();
        }
        public Register Register { get; set; }
        public void OnGet()
        {
            ViewData ["title"] = "一起帮·注册☺";

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
        }
    }
    public class Register
    {
        [Required(ErrorMessage = "* 用户名必须填写")]
        public string Name { get; set; }
        public string Password { get; set; }
    }
}