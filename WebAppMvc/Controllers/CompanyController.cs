using Microsoft.AspNetCore.Mvc;

namespace WebAppMvc.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
