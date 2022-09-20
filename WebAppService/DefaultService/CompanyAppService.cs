using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppCore.Interface;
using WebAppCore.Model;
using WebAppMvc.Database;

namespace WebAppService.DefaultService
{
    public class CompanyAppService : ICompanyAppService
    {
        private readonly DapperContext _context;
        public CompanyAppService(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CompanyDto>> GetCompanies()
        {
            var query = "SELECT * FROM Companies";
            using (var connection = _context.CreateConnection())
            {
                var companies = await connection.QueryAsync<CompanyDto>(query);
                return companies.ToList();
            }
        }

    }
}
