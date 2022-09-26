using DataTypes.Model;
using Microsoft.EntityFrameworkCore;
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
            //var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false);
            //var configuration = builder.Build();

            ////contains "Server=xxxxxx"
            //string str = configuration.GetConnectionString("DataBaseConnectionString");

            //string conStr = _iConfiguration.GetConnectionString("DBConnection");
            //optionsBuilder.UseSqlServer(conStr);
        }
    }
}
