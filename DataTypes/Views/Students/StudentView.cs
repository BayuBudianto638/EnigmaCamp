using DataTypes.Services.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Views.Students
{
    public class StudentView
    {
        private IStudentService _service;
        public StudentView(IStudentService service)
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
                Console.WriteLine("1) Create Student");
                Console.WriteLine("2) Update Student");
                Console.WriteLine("3) Delete Student");
                Console.WriteLine("4) Get Student By Id");
                Console.WriteLine("5) Get All Student");
                Console.WriteLine("6) Exit");
                Console.Write("\r\nSelect an option: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        var createStudentView = new CreateStudentView(_service);
                        createStudentView.DisplayView();
                        showMenu = true;
                        break;
                    case "2":
                        var editStudentView = new EditStudentView(_service);
                        editStudentView.DisplayEditStudent();
                        showMenu = true;
                        break;
                    case "3":
                        var deleteStudentView = new DeleteStudentView(_service);
                        deleteStudentView.DisplayDeleteStudent();
                        showMenu = true;
                        break;
                    case "4":
                        //GetAllStudent();
                        showMenu = true;
                        break;
                    case "5":
                        //GetAllStudent();
                        showMenu = true;
                        break;
                    case "6":
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
