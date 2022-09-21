using Moq;
using WebAppCore.Interface;
using WebAppCore.Model;

namespace WebAppTest
{
    public class UnitTest1
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