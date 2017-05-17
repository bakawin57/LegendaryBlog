using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace LegendaryBlog.ViewModels
{
    public class RegisterUser
    {
        [StringLength(maximumLength:16,MinimumLength =6)]
        [Required(ErrorMessage = "必填")]
        public string Username { get; set; }
        [StringLength(maximumLength:16,MinimumLength =6)]
        [Required(ErrorMessage = "必填")]
        public string Password { get; set; }
        [StringLength(maximumLength: 16, MinimumLength = 6)]
        [Required(ErrorMessage ="必填")]
        [Compare("Password",ErrorMessage ="密码必须相同")]
        public string rePassword { get; set; }
        [Required(ErrorMessage = "必填")]
        public string Code { get; set; }
    }
}