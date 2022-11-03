using DataTypes.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false);
            var configuration = builder.Build();

            string conStr = configuration.GetConnectionString("DBConnection");
            optionsBuilder.UseLazyLoadingProxies(); // Lazy Loading, use Microsoft.EntityFrameworkCore.Proxies
            optionsBuilder.UseSqlServer(conStr);
        }
    }
}
