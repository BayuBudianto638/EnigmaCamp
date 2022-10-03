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

        public CompanyDto Create(CompanyDto company)
        {
            string insertQuery = @"INSERT INTO [dbo].[Companies]([Name], [Address], [Country]) VALUES (@Name, @Address, @Country)";

            var result = _dbConnection.Execute(insertQuery, new
            {
                company.Name,
                company.Address,
                company.Country
            });

            return company;
        }

        public void Delete(int Id)
        {
            string insertQuery = @"DELETE FROM [dbo].[Companies] WHERE Id=@Id; ";

            var result = _dbConnection.Execute(insertQuery, new
            {
               Id
            });
        }

        public CompanyDto GetById(int Id)
        {
            var query = "SELECT * FROM Companies Where Id=@Id";
            var Parameter = new { Id = Id };

            var companies = _dbConnection.Query<CompanyDto>(query, Parameter);

            if (companies == null)
            {
                var company = new CompanyDto();
                return company;
            }

            return companies.First();
        }

        public IEnumerable<CompanyDto> GetCompanies()
        {
            var query = "SELECT * FROM Companies";

            var companies = _dbConnection.Query<CompanyDto>(query);
            return companies.ToList();
        }

        public void Update(CompanyDto company)
        {
            string updateQuery = @"UPDATE [dbo].[Companies]
                                SET
                                    Name=@Name, 
                                    Address=@Address, 
                                    Country=@Country
                                WHERE Id=@Id";

            var result = _dbConnection.Execute(updateQuery, new
            {
                company.Id,
                company.Name,
                company.Address,
                company.Country
            });
        }
    }
}
