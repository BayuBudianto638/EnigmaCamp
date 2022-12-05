using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppCore.Interface;
using WebAppCore.Model;

namespace WebAppTest.UnitTest
{
    public class CompanyUnitTest
    {
        [Fact]
        public void CreateCompany()
        {
            var companyService = new Mock<ICompanyAppService>();

            var newCompany = new CompanyDto();
            newCompany.Id = 1;
            newCompany.Name = "Apple";
            newCompany.Address = "Oregon";
            newCompany.Country = "USA";

            var result = companyService.Setup(service => service.Create(newCompany)).Returns(newCompany);

            Assert.NotNull(result);
        }
    }
}
