using DataTypes.Interfaces;
using DataTypes.Model;
using DataTypes.Services.Courses;
using DataTypes.Services.StudentCourses;
using DataTypes.Services;
using DataTypes.Services.Students;
using DataTypes.Views.Courses;
using DataTypes.Views.Students;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace DataTypes
{
    public class Startup
    {
        IConfigurationRoot Configuration { get; }
        private string conStr = "";
        private SchoolContext _schoolContext;
        public Startup()
        {
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false);
            var configuration = builder.Build();

            conStr = configuration.GetConnectionString("DBConnection");

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddLogging();            
            services.AddSingleton<IConfigurationRoot>(Configuration);
            services.AddSingleton<IStudentService, StudentService>();
            services.AddSingleton<ICourseService, CourseService>();
            services.AddSingleton<IRepository<Course>, RepositoryBase<Course>>();
            services.AddSingleton<IRepository<Student>, RepositoryBase<Student>>();

            services.AddDbContext<SchoolContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DBConnection")));
            services
            .AddDbContext<SchoolContext>(options =>
            {
                options.UseSqlServer(
                    Configuration.GetConnectionString("DBConnection"), builder =>
                        builder.MigrationsAssembly("migration.presentence"));
            }, ServiceLifetime.Singleton);

            //// Dependency Injection for Course
            services.AddSingleton<CourseView>(x => new CourseView(x.GetService<IRepository<Course>>(), x.GetService<CreateCourseView>(),
                                            x.GetService<DeleteCourseView>(), x.GetService<EditCourseView>(),
                                            x.GetService<GetAllCourseView>()));
            services.AddSingleton<CreateCourseView>(x => new CreateCourseView(x.GetService<ICourseService>(), x.GetService<IRepository<Course>>()));
            services.AddSingleton<DeleteCourseView>(x => new DeleteCourseView(x.GetService<IRepository<Course>>()));
            services.AddSingleton<EditCourseView>(x => new EditCourseView(x.GetService<IRepository<Course>>()));
            services.AddSingleton<GetAllCourseView>(x => new GetAllCourseView(x.GetService<IRepository<Course>>()));

            services.AddSingleton<StudentView>(x => new StudentView(x.GetService<IStudentService>()));

            // Dependency Injection for Student
            //_schoolContext = services.GetService<SchoolContext>();

            services.BuildServiceProvider();
           

            //var studentService = services.GetService<IStudentService>();
            //var studentCourseService = services.GetService<IStudentCourseService>();
            //var courseRepoService = services.GetService<IRepository<Course>>();
            //var studentRepoService = services.GetService<IRepository<Student>>();

            ////
            //var courseView = services.GetService<CourseView>();
            //var studentView = services.GetService<StudentView>();
        }

    }
}
