using Dapper;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
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
        private readonly IConfiguration _configs;

        public CompanyAppService(IDbConnection dbConnection, IConfiguration configs)
        {
            _dbConnection = dbConnection;
            _configs = configs;
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
            return companies.FirstOrDefault();
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

        public async Task<CompanyDto> GetDataPegawaiDirektur(string authorizevalue)
        {
            try
            {
                string url = _configs.GetSection("Server").GetSection("APIMDM").Value;
                using (var client = new HttpClient { BaseAddress = new Uri(url) })
                {
                    client.DefaultRequestHeaders.Add("Authorization", authorizevalue);

                    HttpResponseMessage message = await client.GetAsync("api/v1/Mdmpegawai");
                    var strResponse = await message.Content.ReadAsStringAsync();
                    var objResponse = JsonConvert.DeserializeObject<CompanyDto>(strResponse);

                    if (!message.IsSuccessStatusCode)
                        return null;
                    else
                        return objResponse;
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
