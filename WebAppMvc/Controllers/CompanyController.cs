using Microsoft.AspNetCore.Mvc;
using WebAppCore.Interface;
using WebAppCore.Model;
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

        public ActionResult Create()
        {
            var model = new CreateCompanyViewModel();

            return View(model);
        }

        // POST: Company/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateCompanyViewModel model)
        {
            if (ModelState.IsValid)
            {
                var newCompany = new CompanyDto();
                newCompany.Name = model.Name;
                newCompany.Address = model.Address;
                newCompany.Country = model.Country;

                _companyAppService.Create(newCompany);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        // GET: Company/Edit/5
        public ActionResult Edit(int id)
        {
            var Company = _companyAppService.GetById(id);

            var model = new EditCompanyViewModel();
            model.Name = Company.Name;
            model.Address = Company.Address;
            model.Country = Company.Country;

            return View(model);
        }

        // POST: Company/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EditCompanyViewModel model)
        {
            if (ModelState.IsValid)
            {
                var editCompany = new CompanyDto();
                editCompany.Id = model.Id;
                editCompany.Name = model.Name;
                editCompany.Address = model.Address;
                editCompany.Country = model.Country;

                _companyAppService.Update(editCompany);

                return RedirectToAction("Index");
            }

            return View(model);
        }

        public ActionResult Delete(int id)
        {
            try
            {
                // TODO: Add delete logic here
                var Company = _companyAppService.GetById(id);
                _companyAppService.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return RedirectToAction("Index");
            }
        }
    }
}
