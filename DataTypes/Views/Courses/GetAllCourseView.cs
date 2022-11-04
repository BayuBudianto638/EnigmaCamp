using DataTypes.Interfaces;
using DataTypes.Model;
using DataTypes.Services.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Views.Courses
{
    public class GetAllCourseView
    {
        private readonly IRepository<Course> _courseRepo;
        public GetAllCourseView(IRepository<Course> courseRepo)
        {
            _courseRepo = courseRepo;
        }

        public void DisplayView()
        {
            var a = _courseRepo.GetAll();

            foreach(var item in a)
            {
                Console.WriteLine($"{item.CourseId} - {item.CourseName}");
            }

            Console.ReadKey();
        }
    }
}
