using DataTypes.Services.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Views.Students
{
    public class DeleteStudentView
    {
        private IStudentService _service;
        public DeleteStudentView(IStudentService service)
        {
            _service = service;
        }

        public void DisplayDeleteStudent()
        {
            Console.Clear();
            Console.WriteLine("Delete Student");
            Console.WriteLine("---------------");
            Console.Write("Cari Id:");
            int id = Convert.ToInt32(Console.ReadLine());

            var student = _service.GetById(id);

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
                    _service.DeleteStudent(id);

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
