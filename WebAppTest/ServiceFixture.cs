using Microsoft.Data.SqlClient;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppCore.Interface;
using WebAppService.DefaultService;

namespace WebAppTest
{
    public class ServiceFixture
    {
        public ServiceFixture()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddTransient<IDbConnection>((sp) => new SqlConnection("server=DESKTOP-QEO3NAA\\SQLEXPRESS; database=Dapper; Integrated Security=true; Encrypt=false"));
            serviceCollection.AddTransient<ICompanyAppService, CompanyAppService>();

            ServiceProvider = serviceCollection.BuildServiceProvider();
        }

        public ServiceProvider ServiceProvider { get; private set; }
    }
}
