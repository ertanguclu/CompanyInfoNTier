using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInfo.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
   
    public class HomeController : Controller
    {

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [Authorize("Admin")]
        public IActionResult Test()
        {
            return View();
        }
        [Authorize("Admin,Satis")]
        public IActionResult Deneme()
        {
            return View();
        }
    }
}
