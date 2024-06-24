using CompanyInfo.BL.Managers.Abstract;
using CompanyInfo.Entities.Models.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CompanyInfo.MVCUI.Controllers
{
    public class TedarikciController : Controller
    {
        private readonly IManager<Tedarikci> tedarikciManager;

        public TedarikciController(IManager<Tedarikci> tedarikciManager)
        {
            this.tedarikciManager = tedarikciManager;
        }
        public IActionResult Index()
        {
            var result = tedarikciManager.GetAll();
            return View(result);
        }
    }
}
