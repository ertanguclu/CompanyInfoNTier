using CompanyInfo.MVCUI.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInfo.MVCUI.Controllers
{
    public class AccountController : Controller
    {
       

        public IActionResult Login()
        {
            LoginVM loginVM = new LoginVM();
            return View(loginVM);
         
        }

        public IActionResult Login(LoginVM loginVM)
        {
            if(!ModelState.IsValid)
            {
                return View(loginVM);
            }
            var usr = UserManager.GetAllInclude(p => p.Email == loginVM.Email && p.Password == loginVM.Password, p => p.Roller).FirstOrDefault(); ;

        }

        public IActionResult Logout()
        {
            return View();
        }
    }
}
