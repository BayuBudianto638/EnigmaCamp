using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Data;
using WebAppCore.Interface;
using WebAppCore.Model;
using WebAppService.DefaultService;

namespace WebAppTest
{
    //public class ServiceFixture
    //{
    //    public ServiceFixture()
    //    {
    //        var serviceCollection = new ServiceCollection();
    //        serviceCollection.AddTransient<IDbConnection>((sp) => new SqlConnection("server=DESKTOP-QEO3NAA\\SQLEXPRESS; database=Dapper; Integrated Security=true; Encrypt=false"));
    //        serviceCollection.AddTransient<ICompanyAppService, CompanyAppService>();

    //        ServiceProvider = serviceCollection.BuildServiceProvider();
    //    }

    //    public ServiceProvider ServiceProvider { get; private set; }
    //}

    public class UnitTest1: IClassFixture<ServiceFixture>
    {
        private ServiceProvider _serviceProvider;

        public UnitTest1(ServiceFixture fixture)
        {
            _serviceProvider = fixture.ServiceProvider;
        }

        [Fact]
        public void CreateCompany()
        {
            var service = _serviceProvider.GetService<ICompanyAppService>();

            var newCompany = new CompanyDto();
            newCompany.Id = 1;
            newCompany.Name = "Apple";
            newCompany.Address = "Oregon";
            newCompany.Country = "USA";          
            var result = service.Create(newCompany);

            Assert.NotNull(result);
        }
    }
}