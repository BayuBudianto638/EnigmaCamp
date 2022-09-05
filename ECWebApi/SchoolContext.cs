
using EnigmaData.Database;
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
        public DbSet<Student> Students { get; set; }
        //public DbSet<Course> Courses { get; set; }


        //Constructor with DbContextOptions and the context class itself
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        { 
        
        }
    }
}
