using EnigmaCore.Interface;
using EnigmaService.DefaultService;
using Microsoft.Extensions.DependencyInjection;

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

