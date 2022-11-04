using DataTypes.Interfaces;
using DataTypes.Model;
using DataTypes.Services.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Views.Courses
{
    public class CreateCourseView
    {
        //private readonly IRepository<Course> _courseRepo;
        //public CreateCourseView(IRepository<Course> courseRepo)
        //{
        //    _courseRepo = courseRepo;
        //}

        private readonly IRepository<Course> _courseRepo;
        private readonly ICourseService _courseService;
        public CreateCourseView(ICourseService courseService, IRepository<Course> courseRepo)
        {
            _courseService = courseService;
            _courseRepo = courseRepo;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Create Course");
            Console.WriteLine("---------------");

            Console.Write("Course Name : ");
            string courseName = Console.ReadLine();

            var course = new Course();
            course.CourseName = courseName;

            try
            {
                _courseRepo.Begin();
                _courseService.Save(course);
                var(isSave, strMessage) = _courseRepo.Commit();
                if (isSave == true)
                {
                    Console.WriteLine("Record saved!");
                }

                Console.ReadKey();
            }
            catch
            {
                _courseRepo.RollBack();
                Console.WriteLine("Record not saved!");
                Console.ReadKey();
            
            }

            
        }
    }
}
