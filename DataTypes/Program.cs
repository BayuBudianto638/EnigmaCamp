﻿using EnigmaCore.Interface;
using EnigmaData.Database;
using EnigmaService.DefaultService;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        var serviceProvider = new ServiceCollection()
            .AddSingleton<IStudent, StudentService>()
            .BuildServiceProvider();

        bool showMenu = true;
        while (showMenu)
        {
            showMenu = MainMenu();
        }
    }

    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("SOLID Principles Implementation");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Create Student");
        Console.WriteLine("2) Update Student");
        Console.WriteLine("3) Get All Student");
        Console.WriteLine("4) Exit");
        Console.Write("\r\nSelect an option: ");

        switch (Console.ReadLine())
        {
            case "1":
                //CreateStudent();
                return true;
            case "2":
                //UpdateStudent();
                return true;
            case "3":
                //GetAllStudent();
                return true;
            case "4":
                return false;
            default:
                return true;
        }
    }

    //private static void CreateStudent()
    //{
    //    Console.Clear();
    //    Console.WriteLine("Create Student");
    //    Console.WriteLine("---------------");
    //    Console.Write("Nama:");
    //    string nama = Console.ReadLine();

    //    using (var context = new SchoolContext())
    //    {
    //        var student = new Student()
    //        {
    //            Name = nama
    //        };

    //        context.Students.Add(student);
    //        context.SaveChanges();
    //    }

    //    Console.ReadKey();
    //}

    //private static void UpdateStudent()
    //{
    //    Console.Clear();
    //    Console.WriteLine("Update Student");
    //    Console.WriteLine("---------------");
    //    Console.Write("Cari nama:");
    //    string cariNama = Console.ReadLine();

    //    using (var context = new SchoolContext())
    //    {
    //        var student = context.Students.FirstOrDefault(w => w.Name == cariNama);

    //        if (student != null)
    //        {
    //            Console.Write("Masukkan Nama:");
    //            string nama = Console.ReadLine();
    //            student = new Student()
    //            {
    //                Name = nama
    //            };

    //            context.Students.Add(student);
    //            context.SaveChanges();
    //        }
    //        else
    //        {
    //            Console.WriteLine("Nama tidak ditemukan");
    //        }
    //    }

    //    Console.ReadKey();
    //}

    //private static void GetAllStudent()
    //{
    //    Console.Clear();

    //    var context = new SchoolContext();

    //    var data = context.Students.ToList();

    //    Console.WriteLine("Students");
    //    Console.WriteLine("---------------------");
    //    foreach(var item in data)
    //    {
    //        Console.WriteLine($"{item.StudentId} - {item.Name}");
    //    }

    //    Console.ReadKey();
    //}
}

