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
        BlogModel model = new BlogModel();
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Register()
        {

            return View();
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