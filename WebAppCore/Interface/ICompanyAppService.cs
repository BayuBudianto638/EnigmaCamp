using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppCore.Model;

namespace WebAppCore.Interface
{
    public interface ICompanyAppService
    {
        IEnumerable<CompanyDto> GetCompanies();
        CompanyDto Create(CompanyDto company);
        CompanyDto GetById(int Id);
        void Update(CompanyDto company);
        void Delete(int Id);
    }
}
