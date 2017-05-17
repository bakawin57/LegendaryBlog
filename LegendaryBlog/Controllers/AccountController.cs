using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LegendaryBlog.Models;
namespace LegendaryBlog.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserRegister(string name,string pwd,string code)
        {
            string a = name;
            string b = pwd;
            string c = code;
            BlogUser user = new BlogUser();
            user.Username = name;
            user.Password = pwd;
            int res = 0;
            using (BlogModel model1 = new BlogModel())
            {
                model1.BlogUsers.Add(user);
                res=model1.SaveChanges();
            }
            if (res > 0)
            {
                return Redirect("/");
            }
            else
            {
                return Content("注册失败");
            }
        }
        [AllowAnonymous]
        public ActionResult GetValidateCode()
        {
            ValidateCode vCode = new ValidateCode();
            string code = vCode.CreateValidateCode(4);
            Session["ValidateCode"] = code;
            byte[] bytes = vCode.CreateValidateGraphic(code);
            return File(bytes, @"image/jpeg");
        }
    }
}