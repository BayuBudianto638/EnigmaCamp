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
    public class DeleteCourseView
    {
        private readonly IRepository<Course> _courseRepo;
        public DeleteCourseView(IRepository<Course> courseRepo)
        {
            _courseRepo = courseRepo;
        }

        public void DisplayView()
        {
            Console.Clear();
            Console.WriteLine("Delete Student");
            Console.WriteLine("---------------");
            Console.Write("Cari Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            var student = studentService.GetById(id);

            if (student != null)
            {
                Console.WriteLine($"Code : {student.Code}");
                Console.WriteLine($"Nama : {student.Name}");
                Console.WriteLine($"Address : {student.Address}");
                Console.WriteLine($"Country : {student.Country}");

                Console.WriteLine("---------------");
                Console.WriteLine("Are you sure want to delete this record? (Y/N)");
                var choice = Console.ReadLine();
                if (choice.ToUpper().Equals('Y'))
                {
                    //studentService.DeleteStudent(id);

                    Console.WriteLine("Record updated!");
                }
            }
            else
            {
                Console.WriteLine("Id tidak ditemukan");
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
