// Contoh 1
using DataTypes;
using DataTypes.Model;
class program
{
    static void Main()
    {
        using (var context = new SchoolContext())
        {
            var student = new Student()
            {
                Name = "Itachi Uchiha",
                Address = "Konoha",
                Country = "Negara Api"
            };

            context.Students.Add(student);
            context.SaveChanges();
        }
    }
}

//// Contoh 2 menggunakan Interface, class service dan Dependency Injection
////using DataTypes.Interface;
////using DataTypes.Service;
////using Microsoft.Extensions.DependencyInjection;

////class Program
////{
////    static void Main()
////    {
////               var serviceProvider = new ServiceCollection()
////                   .AddLogging()
////                   .AddSingleton<IStudent, StudentService>()
////                   //.AddSingleton<ICour, BarService>()
////                   .BuildServiceProvider();

////    }
////}


////Contoh 3 Using Menu like basic Pascal/C++ Console
//using DataTypes.Model;
//using DataTypes;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using DataTypes.Interface;
//using DataTypes.Service;

//class Program
//{
//    static void Main(string[] args)
//    {
//        var serviceProvider = new ServiceCollection()
//            .AddLogging()
//            .AddSingleton<IStudent, StudentService>()
//            .BuildServiceProvider();

//        bool showMenu = true;
//        while (showMenu)
//        {
//            showMenu = MainMenu();
//        }
//    }

//    private static bool MainMenu()
//    {
//        Console.Clear();
//        Console.WriteLine("Choose an option:");
//        Console.WriteLine("1) Create Student");
//        Console.WriteLine("2) Update Student");
//        Console.WriteLine("3) Exit");
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
//        Console.Write("Nama:");
//        string nama = Console.ReadLine();

//        var student = new Student();
//        student.Name = nama;

//        var studentService = new StudentService();
//        studentService.SimpanStudent(student);

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
//                Console.Write("Masukkan Nama:");
//                string nama = Console.ReadLine();

//                student.StudentId = student.StudentId;
//                student.Name = nama;

//                var studentService = new StudentService();
//                studentService.UpdateStudent(student);
//            }
//            else
//            {
//                Console.WriteLine("Nama tidak ditemukan");
//            }          
//        }

//        Console.ReadKey();
//    }
//}