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
//                StudentId = 1,
//                Name = "Anton Medan"
//            };

//            context.Students.Add(student);
//            context.SaveChanges();
//        }
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


// Contoh 3 Using Menu like basic Pascal/C++ Console
class Program
{
    static void Main(string[] args)
    {
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
        Console.WriteLine("3) Exit");
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
                return false;
            default:
                return true;
        }
    }

    private static void CreateStudent()
    {
        Console.Clear();
        Console.WriteLine("Create Student");
        Console.ReadKey();
    }

    private static void UpdateStudent()
    {
        Console.Clear();
        Console.WriteLine("Update Student");
        Console.ReadKey();
    }
}