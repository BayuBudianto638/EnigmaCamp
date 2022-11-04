using DataTypes.Model;
using DataTypes.Services.StudentCourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Views.StudentCourses
{
    public class CreateStudentCourseView
    {
        private IStudentCourseService _service;
        public CreateStudentCourseView(IStudentCourseService service)
        {
            _service = service;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Create Student");
            Console.WriteLine("---------------");

            Console.Write("Code : ");
            string code = Console.ReadLine();
            Console.Write("Name : ");
            string nama = Console.ReadLine();
            Console.Write("Address : ");
            string address = Console.ReadLine();
            Console.Write("Country : ");
            string country = Console.ReadLine();

            var student = new Student();
            student.Code = code;
            student.Name = nama;
            student.Address = address;
            student.Country = country;

            //_service.SimpanStudent(student);

            Console.WriteLine("Record saved!");
            Console.ReadKey();
        }
    }
}
