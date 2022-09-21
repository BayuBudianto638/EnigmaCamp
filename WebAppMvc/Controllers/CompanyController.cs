using Microsoft.AspNetCore.Mvc;
using WebAppCore.Interface;
using WebAppMvc.Models;

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
            var data = _companyAppService.GetCompanies();

            var output = new List<CompanyModel>();
            foreach (var item in data)
            {
                var dataOutput = new CompanyModel();

                dataOutput.Id = item.Id;
                dataOutput.Name = item.Name;
                dataOutput.Address = item.Address;
                dataOutput.Country = item.Country;
                output.Add(dataOutput);
            }
            return View(output);
        }
    }
}
