//// Contoh 1
//using DataTypes;
//using DataTypes.Model;
//using DataTypes.ModelData;
//class program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        var data = context.Students.ToList();

//        Console.WriteLine("Subject Result:");
//        foreach (var item in data)
//        {
//            Console.Write($"{item.StudentId} - {item.Name}");
//            Console.WriteLine();
//        }

//        Console.ReadKey();
//    }
//}

//// Contoh 1
//using DataTypes;
//using DataTypes.Model;
//using DataTypes.ModelData;
//class program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        var data = context.Students.AsEnumerable();

//        Console.WriteLine("Subject Result:");
//        foreach (var item in data)
//        {
//            Console.Write($"{item.StudentId} - {item.Name}");
//            Console.WriteLine();
//        }

//        Console.ReadKey();
//    }
//}

// Contoh 1
using DataTypes;
using DataTypes.Model;
using DataTypes.ModelData;
class program
{
    static void Main()
    {
        var context = new SchoolContext();

        var data = context.Students.AsQueryable();

        Console.WriteLine("Subject Result:");
        foreach (var item in data)
        {
            Console.Write($"{item.StudentId} - {item.Name}");
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}



//// Contoh 1
//using DataTypes;
//using DataTypes.Model;
//using DataTypes.ModelData;
//class program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        // LINQ bisa ToList, AsQueryable, Where, First, FirstOrDefault, Single, Skip, Take and so on
//        var data = (from a in context.Subjects
//                    join b in context.Students on a.StudentId equals b.StudentId
//                    join c in context.Courses on a.CourseId equals c.CourseId
//                    select new SubjectList
//                    {
//                        SubjectId = a.SubjectId,
//                        StudentName = b.Name,
//                        CourseName = c.CourseName
//                    }).ToList();

//        Console.WriteLine("Subject Result:");
//        foreach (var item in data)
//        {
//            Console.Write($"{item.SubjectId} - {item.StudentName} - {item.CourseName}");
//            Console.WriteLine();
//        }

//        Console.ReadKey();
//    }
//}

//// Contoh 2
//// Using Where
//using DataTypes;
//using DataTypes.Model;
//using DataTypes.ModelData;

//class program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        // LINQ bisa ToList, AsQueryable, Where, First, FirstOrDefault, Single, Skip, Take and so on
//        var data = (from a in context.Subjects
//                    join b in context.Students on a.StudentId equals b.StudentId
//                    join c in context.Courses on a.CourseId equals c.CourseId
//                    select new SubjectList
//                    {
//                        SubjectId = a.SubjectId,
//                        StudentName = b.Name,
//                        CourseName = c.CourseName
//                    }).Where(w => w.StudentName == "Uchiha Itachi").ToList();

//        Console.WriteLine("Subject Result:");
//        foreach (var item in data)
//        {
//            Console.Write($"{item.SubjectId} - {item.StudentName} - {item.CourseName}");
//            Console.WriteLine();
//        }

//        Console.ReadKey();
//    }
//}

//// Contoh 3
//// Using FirstOrDefault
//using DataTypes;
//using DataTypes.Model;
//using DataTypes.ModelData;

//class program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        // LINQ bisa ToList, AsQueryable, Where, First, FirstOrDefault, Single, Skip, Take and so on
//        var data = (from a in context.Subjects
//                    join b in context.Students on a.StudentId equals b.StudentId
//                    join c in context.Courses on a.CourseId equals c.CourseId
//                    select new SubjectList
//                    {
//                        SubjectId = a.SubjectId,
//                        StudentName = b.Name,
//                        CourseName = c.CourseName
//                    }).FirstOrDefault(w => w.StudentName == "Uchiha Itachi");

//        Console.WriteLine("Subject Result:");

//        Console.Write($"{data.SubjectId} - {data.StudentName} - {data.CourseName}");
//        Console.WriteLine();

//        Console.ReadKey();
//    }
//}


//// Contoh 4 
//// Using Skip and Take - Biasanya digunakan untuk paging
//using DataTypes;
//using DataTypes.Model;
//using DataTypes.ModelData;

//class program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        // LINQ bisa ToList, AsQueryable, Where, First, FirstOrDefault, Single, Skip, Take and so on
//        var data = (from a in context.Subjects
//                    join b in context.Students on a.StudentId equals b.StudentId
//                    join c in context.Courses on a.CourseId equals c.CourseId
//                    select new SubjectList
//                    {
//                        SubjectId = a.SubjectId,
//                        StudentName = b.Name,
//                        CourseName = c.CourseName
//                    })
//                    .Skip(3)
//                    .Take(4)
//                    .ToList();

//        Console.WriteLine("Subject Result:");
//        foreach (var item in data)
//        {
//            Console.Write($"{item.SubjectId} - {item.StudentName} - {item.CourseName}");
//            Console.WriteLine();
//        }

//        Console.ReadKey();
//    }
//}

//// Contoh 5
//// Using Single and SingleOrDefault
//using DataTypes;
//using DataTypes.Model;
//using DataTypes.ModelData;

//class program
//{
//    static void Main()
//    {
//        var context = new SchoolContext();

//        // LINQ bisa ToList, AsQueryable, Where, First, FirstOrDefault, Single, Skip, Take and so on
//        var data = (from a in context.Subjects
//                    join b in context.Students on a.StudentId equals b.StudentId
//                    join c in context.Courses on a.CourseId equals c.CourseId
//                    select new SubjectList
//                    {
//                        SubjectId = a.SubjectId,
//                        StudentName = b.Name,
//                        CourseName = c.CourseName
//                    }).SingleOrDefault(w=>w.SubjectId == 1);

//        Console.WriteLine("Subject Result:");

//        Console.Write($"{data.SubjectId} - {data.StudentName} - {data.CourseName}");
//        Console.WriteLine();

//        Console.ReadKey();
//    }
//}


// Contoh 3 Using Menu like basic Pascal/C++ Console
//class Program
//{
//    static void Main(string[] args)
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
//        Console.ReadKey();
//    }

//    private static void UpdateStudent()
//    {
//        Console.Clear();
//        Console.WriteLine("Update Student");
//        Console.ReadKey();
//    }
//}