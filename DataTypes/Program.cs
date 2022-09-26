//// Contoh 1
//using DataTypes;
//using DataTypes.Model;
//class program
//{
//    static void Main()
//    {
//        using (var context = new SchoolContext())
//        {
//            var student = new Student()
//            {
//                Name = "Itachi Uchiha",
//                Address = "Konoha",
//                Country = "Negara Api"
//            };

//            context.Students.Add(student);
//            context.SaveChanges();
//        }
//    }
//}


//// Contoh 1
//using DataTypes;
//using DataTypes.Model;
//class program
//{
//    static void Main()
//    {
//        Console.Write("Nama : ");
//        var Nama = Console.ReadLine();
//        Console.Write("Alamat : ");
//        var Address = Console.ReadLine();
//        Console.Write("Country : ");
//        var Country = Console.ReadLine();

//        using (var context = new SchoolContext())
//        {
//            var student = new Student()
//            {
//                Name = Nama,
//                Address = Address,
//                Country = Country
//            };

//            context.Students.Add(student);
//            context.SaveChanges();
//        }
//    }
//}

//using DataTypes.Interface;
//using DataTypes.Service;
//using DataTypes;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Security.Cryptography;
//using DataTypes.Model;

//class Program
//{
//    static void Main()
//    {       
//        bool showMenu = true;
//        while (showMenu)
//        {
//            showMenu = MainMenu();
//        }
//    }

//    private static bool MainMenu()
//    {
//        Console.Clear();
//        Console.WriteLine("CRUD Principles Implementation");
//        Console.WriteLine("-------------------------------");
//        Console.WriteLine("Choose an option:");
//        Console.WriteLine("1) Create Student");
//        Console.WriteLine("2) Update Student");
//        Console.WriteLine("3) Get All Student");
//        Console.WriteLine("4) Delete Student");
//        Console.WriteLine("5) Exit");
//        Console.Write("\r\nSelect an option: ");

//        switch (Console.ReadLine())
//        {
//            case "1":
//                CreateStudent();
//                return true;
//            case "2":
//                UpdateStudent();
//                return true;
//            case "3":
//                GetAllStudent();
//                return true;
//            case "4":
//                DeleteStudent();
//                return true;
//            case "5":
//                return false;
//            default:
//                return true;
//        }
//    }

//    private static void CreateStudent()
//    {
//        Console.Clear();
//        Console.WriteLine("Create Student");
//        Console.WriteLine("---------------");
//        Console.Write("Name:");
//        string nama = Console.ReadLine();
//        Console.Write("Address:");
//        string address = Console.ReadLine();
//        Console.Write("Country:");
//        string country = Console.ReadLine();

//        using (var context = new SchoolContext())
//        {
//            var student = new Student()
//            {
//                Name = nama,
//                Address = address,
//                Country = country
//            };

//            context.Students.Add(student);
//            context.SaveChanges();
//        }

//        Console.ReadKey();
//    }

//    private static void UpdateStudent()
//    {
//        Console.Clear();
//        Console.WriteLine("Update Student");
//        Console.WriteLine("---------------");
//        Console.Write("Cari nama:");
//        string cariNama = Console.ReadLine();

//        using (var context = new SchoolContext())
//        {
//            var student = context.Students.FirstOrDefault(w => w.Name == cariNama);

//            if (student != null)
//            {
//                Console.WriteLine($"{student.StudentId} - {student.Name} - {student.Address} - {student.Country}");
//                Console.ReadKey();

//                Console.WriteLine("----------------------");

//                Console.Write("Name:");
//                string nama = Console.ReadLine();
//                Console.Write("Address:");
//                string address = Console.ReadLine();
//                Console.Write("Country:");
//                string country = Console.ReadLine();

//                student.Name = nama;
//                student.Address = address;
//                student.Country = country;

//                context.Students.Update(student);
//                context.SaveChanges();
//            }
//            else
//            {
//                Console.WriteLine("Nama tidak ditemukan");
//            }
//        }

//        Console.ReadKey();
//    }

//    private static void GetAllStudent()
//    {
//        Console.Clear();

//        var context = new SchoolContext();

//        var data = context.Students.ToList();

//        Console.WriteLine("Students");
//        Console.WriteLine("---------------------");
//        foreach (var item in data)
//        {
//            Console.WriteLine($"{item.StudentId} - {item.Name} - {item.Address} - {item.Country}");
//        }

//        Console.ReadKey();
//    }

//    private static void DeleteStudent()
//    {
//        Console.Clear();
//        Console.WriteLine("Delete Student");
//        Console.WriteLine("---------------");
//        Console.Write("Name:");
//        string nama = Console.ReadLine();

//        using (var context = new SchoolContext())
//        {
//            var student = context.Students.FirstOrDefault(w => w.Name == nama);

//            if (student != null)
//            {
//                Console.WriteLine($"{student.StudentId} - {student.Name} - {student.Address} - {student.Country}");
//                Console.WriteLine("Press any key to continue");
//                Console.ReadKey();

//                Console.WriteLine("Deleting");
//                Console.WriteLine("----------------------");

//                context.Students.Remove(student);
//                context.SaveChanges();
//            }
//            else
//            {
//                Console.WriteLine("Nama tidak ditemukan");
//            }
//        }

//        Console.ReadKey();
//    }
//}



// Contoh 2 menggunakan Interface, class service dan Dependency Injection
//using DataTypes.Interface;
//using DataTypes.Service;
//using Microsoft.Extensions.DependencyInjection;

//class Program
//{
//    static void Main()
//    {
//               var serviceProvider = new ServiceCollection()
//                   .AddLogging()
//                   .AddSingleton<IStudent, StudentService>()
//                   //.AddSingleton<ICour, BarService>()
//                   .BuildServiceProvider();

//    }
//}


//Contoh 3 Using Menu like basic Pascal/C++ Console
using DataTypes.Model;
using DataTypes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using DataTypes.Interface;
using DataTypes.Service;

class Program
{
    static void Main(string[] args)
    {
        var serviceProvider = new ServiceCollection()
            .AddLogging()
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
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1) Create Student");
        Console.WriteLine("2) Update Student");
        Console.WriteLine("3) Get Student By Id");
        Console.WriteLine("4) Get All Student");
        Console.WriteLine("5) Exit");
        Console.Write("\r\nSelect an option: ");

        switch (Console.ReadLine())
        {
            case "1":
                CreateStudent();
                return true;
            case "2":
                UpdateStudent();
                return true;
            case "3":
                GetStudentById();
                return true;
            case "4":
                GetAllStudent();
                return true;
            case "5":
                return false;
            default:
                return true;
        }
    }

    private static void CreateStudent()
    {
        Console.Clear();
        Console.WriteLine("Create Student");
        Console.WriteLine("---------------");

        Console.Write("Name:");
        string nama = Console.ReadLine();
        Console.Write("Address:");
        string address = Console.ReadLine();
        Console.Write("Country:");
        string country = Console.ReadLine();

        var student = new Student();
        student.Name = nama;
        student.Address = address;
        student.Country = country;

        var studentService = new StudentService();
        studentService.SimpanStudent(student);

        Console.ReadKey();
    }

    private static void UpdateStudent()
    {
        Console.Clear();
        Console.WriteLine("Update Student");
        Console.WriteLine("---------------");
        Console.Write("Cari Id:");
        int id = Convert.ToInt32(Console.ReadLine());

        var studentService = new StudentService();
        var student = studentService.GetById(id);

        if (student != null)
        {
            Console.WriteLine($"Nama : {student.Name}");
            Console.WriteLine($"Address : {student.Address}");
            Console.WriteLine($"Country : {student.Country}");

            Console.WriteLine("---------------");
            Console.ReadKey();

            Console.Write("Name:");
            string nama = Console.ReadLine();
            Console.Write("Address:");
            string address = Console.ReadLine();
            Console.Write("Country:");
            string country = Console.ReadLine();

            student.Name = nama;
            student.Address = address;
            student.Country = country;

            studentService.UpdateStudent(student);
        }
        else
        {
            Console.WriteLine("Id tidak ditemukan");
        }

        Console.ReadKey();
    }

    private static void GetStudentById()
    {
        Console.Clear();
        Console.WriteLine("Get Student By Id");
        Console.WriteLine("---------------");
        Console.Write("Id:");
        int id = Convert.ToInt32(Console.ReadLine());

        var studentService = new StudentService();
        var student = studentService.GetById(id);

        Console.WriteLine($"Nama : {student.Name}");
        Console.WriteLine($"Address : {student.Address}");
        Console.WriteLine($"Country : {student.Country}");

        Console.ReadKey();
    }

    private static void GetAllStudent()
    {
        Console.Clear();
        Console.WriteLine("Get All Student");
        Console.WriteLine("---------------");

        var studentService = new StudentService();
        var studentList = studentService.GetAllStudents();

        foreach (var item in studentList)
        {
            Console.WriteLine($"{item.StudentId} - {item.Name} - {item.Address} - {item.Country}");
        }

        Console.ReadKey();
    }
}