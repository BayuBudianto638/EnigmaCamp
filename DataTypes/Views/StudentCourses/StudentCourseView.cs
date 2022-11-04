using DataTypes.Services.StudentCourses;
using DataTypes.Views.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Views.StudentCourses
{
    public class StudentCourseView
    {
        private IStudentCourseService _service;
        public StudentCourseView(IStudentCourseService service)
        {
            _service = service;
        }

        public void DisplayView()
        {
            bool showMenu = true;
            while (showMenu)
            {
                Console.Clear();
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Create Student Course");
                Console.WriteLine("2) Update Student Course");
                Console.WriteLine("3) Delete Student Course");
                Console.WriteLine("4) Get All Student Course");
                Console.WriteLine("5) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        var createStudentView = new CreateStudentCourseView(_service);
                        createStudentView.DisplayView();
                        showMenu = true;
                        break;
                    case "2":
                        var editStudentView = new EditStudentCourseView(_service);
                        editStudentView.DisplayView();
                        showMenu = true;
                        break;
                    case "3":
                        var deleteStudentView = new DeleteStudentCourseView(_service);
                        deleteStudentView.DisplayView();
                        showMenu = true;
                        break;
                    case "4":
                        //GetAllStudent();
                        showMenu = true;
                        break;
                    case "5":
                        //GetAllStudent();
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
