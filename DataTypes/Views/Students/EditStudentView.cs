﻿using DataTypes.Services.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Views.Students
{
    public class EditStudentView
    {
        private IStudentService _service;
        public EditStudentView(IStudentService service)
        {
            _service = service;
        }
        public void DisplayEditStudent()
        {
            Console.Clear();
            Console.WriteLine("Update Student");
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
                Console.ReadKey();

                Console.Write("Code : ");
                string code = Console.ReadLine();
                Console.Write("Name:");
                string nama = Console.ReadLine();
                Console.Write("Address:");
                string address = Console.ReadLine();
                Console.Write("Country:");
                string country = Console.ReadLine();

                student.StudentId = student.StudentId;
                student.Code = code;
                student.Name = nama;
                student.Address = address;
                student.Country = country;

                _service.UpdateStudent(student);
            }
            else
            {
                Console.WriteLine("Id tidak ditemukan");
            }

            Console.WriteLine("Record updated!");
            Console.ReadKey();
        }
    }
}
