using DataTypes.Interfaces;
using DataTypes.Model;
using DataTypes.Services.Courses;
using DataTypes.Views.StudentCourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Views.Courses
{
    public class CourseView
    {
        private readonly IRepository<Course> _courseRepo;
        private readonly CreateCourseView _createCourseView;
        private readonly GetAllCourseView _getAllCourseView;
        private readonly DeleteCourseView _deleteCourseView;
        private readonly EditCourseView _editCourseView;

        public CourseView(IRepository<Course> courseRepo, 
                        CreateCourseView createCourseView,
                        DeleteCourseView deleteCourseView,
                        EditCourseView editCourseView,
                        GetAllCourseView getAllCourseView)
        {
            _courseRepo = courseRepo;
            _createCourseView = createCourseView;
            _getAllCourseView = getAllCourseView;
            _editCourseView = editCourseView;
            _deleteCourseView = deleteCourseView;
        }

        public void DisplayView()
        {
            bool showMenu = true;
            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Create Course");
                Console.WriteLine("2) Update Course");
                Console.WriteLine("3) Delete Course");
                Console.WriteLine("4) Get All Course");
                Console.WriteLine("5) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        _createCourseView.DisplayView();
                        showMenu = true;
                        break;
                    case "2":
                        _editCourseView.DisplayView();
                        showMenu = true;
                        break;
                    case "3":
                        _deleteCourseView.DisplayView();
                        showMenu = true;
                        break;
                    case "4":
                        _getAllCourseView.DisplayView();
                        showMenu = true;
                        break;
                    case "5":
                        showMenu = false;
                        break;
                    default:
                        showMenu = true;
                        break;
                }
            }
        }
    }
}
