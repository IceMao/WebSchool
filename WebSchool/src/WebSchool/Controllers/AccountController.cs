using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using WebSchool.Models;
using Microsoft.AspNet.Identity;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebSchool.Controllers
{
    public class AccountController : BaseController
    {
        //管理员登录...等
        [FromServices]
        public SignInManager<User> signInManager { get; set; }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult>Login(string username, string password)
        {
            var result = await signInManager.PasswordSignInAsync(username, password, false, false);
            if (result.Succeeded)
                return RedirectToAction("Manage", "Home",username);
            else
                return RedirectToAction("Login", "Account");
        }
    }
}
