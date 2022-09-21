using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppCore.Interface;
using WebAppCore.Model;

namespace WebAppService.DefaultService
{
    public class CompanyAppService : ICompanyAppService
    {
        private readonly IDbConnection _dbConnection;

        public CompanyAppService(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public IEnumerable<CompanyDto> GetCompanies()
        {
            var query = "SELECT * FROM Companies";

            var companies = _dbConnection.Query<CompanyDto>(query);
            return companies.ToList();
        }
    }
}
