using DataTypes.Services.Students;
using DataTypes.Services.StudentCourses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Views.StudentCourses
{
    public class EditStudentCourseView
    {
        private IStudentCourseService _service;
        public EditStudentCourseView(IStudentCourseService service)
        {
            _service = service;
        }

        public void DisplayView()
        {
            //Console.Clear();
            //Console.WriteLine("Update Student");
            //Console.WriteLine("---------------");
            //Console.Write("Cari Id:");
            //int id = Convert.ToInt32(Console.ReadLine());

            //IStudentService studentService = new StudentService();
            //var student = studentService.GetById(id);

            //if (student != null)
            //{
            //    Console.WriteLine($"Code : {student.Code}");
            //    Console.WriteLine($"Nama : {student.Name}");
            //    Console.WriteLine($"Address : {student.Address}");
            //    Console.WriteLine($"Country : {student.Country}");

            //    Console.WriteLine("---------------");
            //    Console.ReadKey();

            //    Console.Write("Code : ");
            //    string code = Console.ReadLine();
            //    Console.Write("Name:");
            //    string nama = Console.ReadLine();
            //    Console.Write("Address:");
            //    string address = Console.ReadLine();
            //    Console.Write("Country:");
            //    string country = Console.ReadLine();

            //    student.StudentId = student.StudentId;
            //    student.Code = code;
            //    student.Name = nama;
            //    student.Address = address;
            //    student.Country = country;

            //    studentService.UpdateStudent(student);
            //}
            //else
            //{
            //    Console.WriteLine("Id tidak ditemukan");
            //}

            //Console.WriteLine("Record updated!");
            //Console.ReadKey();
        }
    }
}
