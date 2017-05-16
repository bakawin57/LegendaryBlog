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
        [Required]
        public string Username { get; set; }
        [StringLength(maximumLength:16,MinimumLength =6)]
        [Required]
        public string Password { get; set; }
        [StringLength(maximumLength: 16, MinimumLength = 6)]
        [Required]
        [Compare("Password")]
        public string rePassword { get; set; }
        [Required]
        public string Code { get; set; }
    }
}