using Microsoft.AspNetCore.Mvc;
using WebAppCore.Interface;

namespace WebAppMvc.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyAppService _companyAppService;

        public CompanyController(ICompanyAppService companyAppService)
        {
            _companyAppService = companyAppService;
        }


        public IActionResult Index()
        {
            var output = _companyAppService.GetCompanies();
            return View(output);
        }
    }
}
