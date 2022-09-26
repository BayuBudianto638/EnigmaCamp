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
    public class SchoolContext: DbContext
    {
        public IConfiguration Configuration { get; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conStr = Configuration.GetConnectionString("ConnectionString");
            optionsBuilder.UseSqlServer(conStr);
        }
    }
}
