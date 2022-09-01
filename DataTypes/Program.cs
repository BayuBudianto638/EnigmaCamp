//// declaring public class
//using System;
//public class EnigmaCamp
//{

//    // field variable
//    public int a, b;

//    // member function or method
//    public void display()
//    {
//        Console.WriteLine("Class & Objects in C#");
//      }
//}



//// CONTOH 1 OOP
//// C# program to illustrate the
//// Initialization of an object
//using System;
//// Class Declaration
//public class Dog
//{
//    // Instance Variables
//    String name;
//    String breed;
//    int age;
//    String color;

//    // Constructor Declaration of Class
//    public Dog(String name, String breed,
//                int age, String color)
//    {
//        this.name = name;
//        this.breed = breed;
//        this.age = age;
//        this.color = color;
//    }

//    // Property 1
//    public String GetName()
//    {
//        return name;
//    }

//    // Property 2
//    public String GetBreed()
//    {
//        return breed;
//    }

//    // Property 3
//    public int GetAge()
//    {
//        return age;
//    }

//    // Property 4
//    public String GetColor()
//    {
//        return color;
//    }

//    // Method 1
//    public String GetObject()
//    {
//        return ("Hi my name is " + this.GetName()
//                + ".\nMy breed, age and color are " + this.GetBreed()
//                + ", " + this.GetAge() + ", " + this.GetColor());
//    }

//    // Main Method
//    public static void Main(String[] args)
//    {
//        // Creating object
//        Dog subaru = new Dog("subaru", "herder", 5, "black");
//        Console.WriteLine(subaru.GetObject());
//        Console.ReadKey();
//    }
//}

//// CONTOH 2
//// C# Program to illustrate calling
//// a Default constructor
//using System;
//namespace DefaultConstructorExample
//{
//    class EnigmaCamp
//    {
//        int num;
//        string name;

//        // this would be invoked while the
//        // object of that class created.
//        EnigmaCamp()
//        {
//            Console.WriteLine("Constructor Called");
//        }

//        // Main Method
//        public static void Main()
//        {

//            // this would invoke default
//            // constructor.
//            EnigmaCamp ec = new EnigmaCamp();

//            // Default constructor provides
//            // the default values to the
//            // int and object as 0, null
//            // Note:
//            // It Give Warning because
//            // Fields are not assign
//            Console.WriteLine(ec.name);
//            Console.WriteLine(ec.num);
//            Console.ReadKey();
//        }
//    }
//}

//// CONTOH 3
//// C# Program to illustrate calling of
//// parameterized constructor.
//using System;
//namespace ParameterizedConstructorExample
//{
//    class EnigmaCamp
//    {
//        // data members of the class.
//        String name;
//        int id;

//        // parameterized constructor would
//        // initialized data members with
//        // the values of passed arguments
//        // while object of that class created.
//        EnigmaCamp(String name, int id)
//        {
//            this.name = name;
//            this.id = id;
//        }

//        // Main Method
//        public static void Main()
//        {
//            // This will invoke parameterized
//            // constructor.
//            EnigmaCamp ec = new EnigmaCamp("EC", 1);
//            Console.WriteLine("EnigmaName = " + ec.name +
//                            " and EnigmaId = " + ec.id);

//            Console.ReadKey();
//        }
//    }
//}


//// CONTOH 4
//// C# Program to illustrate calling
//// a Copy constructor
//using System;
//namespace copyConstructorExample
//{
//    class EnigmaCamp
//    {
//        private string month;
//        private int year;

//        // declaring Copy constructor
//        public EnigmaCamp(EnigmaCamp s)
//        {
//            month = s.month;
//            year = s.year;
//        }

//        // Instance constructor
//        public EnigmaCamp(string month, int year)
//        {
//            this.month = month;
//            this.year = year;
//        }

//        // Get details of EnigmaCamp
//        public string Details
//        {
//            get
//            {
//                return "Month: " + month.ToString() +
//                        "\nYear: " + year.ToString();
//            }
//        }

//        // Main Method
//        public static void Main()
//        {
//            // Create a new EnigmaCamp object.
//            EnigmaCamp ec1 = new EnigmaCamp("Sept", 2022);

//            // here is ec1 details is copied to ec2.
//            EnigmaCamp ec2 = new EnigmaCamp(ec1);

//            Console.WriteLine(ec2.Details);
//            Console.ReadKey();
//        }
//    }
//}

//// CONTOH 5
//// C# Program to illustrate calling
//// a Private constructor
//using System;
//namespace privateConstructorExample
//{
//    public class EnigmaCamp
//    {
//        // declare private Constructor
//        private EnigmaCamp()
//        {
//        }

//        // declare static variable field
//        public static int count_enigma;

//        // declare static method
//        public static int enigma_Count()
//        {
//            return ++count_enigma;
//        }

//        // Main Method
//        public static void Main()
//        {   
//            EnigmaCamp.count_enigma = 99;

//            // Accessing without any
//            // instance of the class
//            EnigmaCamp.enigma_Count();

//            Console.WriteLine(EnigmaCamp.count_enigma);

//            // Accessing without any
//            // instance of the class
//            EnigmaCamp.enigma_Count();

//            Console.WriteLine(EnigmaCamp.count_enigma);
//            Console.ReadKey();
//        }
//    }
//}

//// CONTOH 6
//class SimpleClass
//{
//    // Static variable that must be initialized at run time.
//    static readonly long baseline;

//    // Static constructor is called at most one time, before any
//    // instance constructor is invoked or member is accessed.
//    static SimpleClass()
//    {
//        baseline = DateTime.Now.Ticks;
//    }
//}

//// CONTOH 7
//using System;
//class A
//{
//    static A()
//    {
//        Console.WriteLine("Init A");
//    }

//    public static void F()
//    {
//        Console.WriteLine("A.F");
//    }
//}

//class B
//{
//    static B()
//    {
//        Console.WriteLine("Init B");
//    }

//    public static void F()
//    {
//        Console.WriteLine("B.F");
//    }
//}

//class TestClass
//{
//    static void Main()
//    {
//        A.F();
//        B.F();

//        Console.ReadKey();
//    }
//}

//// CONTOH 8
////It is possible to construct circular dependencies that allow static fields with variable initializers to be observed in their default value state.
//using System;
//class A
//{
//    public static int X;

//    static A()
//    {
//        X = B.Y + 1;
//    }
//}

//class B
//{
//    public static int Y = A.X + 1;

//    static B() { }

//    static void Main()
//    {
//        Console.WriteLine($"X = {A.X}, Y = {B.Y}");
//        Console.ReadKey();
//    }
//}

//// CONTOH 9
//// C# Program to illustrate calling
//// a Static constructor
//using System;
//namespace staticConstructorExample
//{
//    class EnigmaCamp
//    {
//        // It is invoked before the first
//        // instance constructor is run.
//        static EnigmaCamp()
//        {
//            // The following statement produces
//            // the first line of output,
//            // and the line occurs only once.
//            Console.WriteLine("Static Constructor");
//        }

//        // Instance constructor.
//        public EnigmaCamp(int i)
//        {
//            Console.WriteLine("Instance Constructor " + i);
//        }

//        // Instance method.
//        public string EnigmaCamp_detail(string name, int id)
//        {
//            return "Name:" + name + " id:" + id;
//        }

//        // Main Method
//        public static void Main()
//        {
//            // Here Both Static and instance
//            // constructors are invoked for
//            // first instance
//            EnigmaCamp obj = new EnigmaCamp(1);

//            Console.WriteLine(obj.EnigmaCamp_detail("EC", 1));

//            // Here only instance constructor
//            // will be invoked
//            EnigmaCamp obj1 = new EnigmaCamp(2);

//            Console.WriteLine(obj1.EnigmaCamp_detail("EnigmaCamp", 2));
//            Console.ReadKey();
//        }
//    }
//}

//// CONTOH 10
//using System;
//public class Bus
//{
//    // Static variable used by all Bus instances.
//    // Represents the time the first bus of the day starts its route.
//    protected static readonly DateTime globalStartTime;

//    // Property for the number of each bus.
//    protected int RouteNumber { get; set; }

//    // Static constructor to initialize the static variable.
//    // It is invoked before the first instance constructor is run.
//    static Bus()
//    {
//        globalStartTime = DateTime.Now;

//        // The following statement produces the first line of output,
//        // and the line occurs only once.
//        Console.WriteLine("Static constructor sets global start time to {0}",
//            globalStartTime.ToLongTimeString());
//    }

//    // Instance constructor.
//    public Bus(int routeNum)
//    {
//        RouteNumber = routeNum;
//        Console.WriteLine("Bus #{0} is created.", RouteNumber);
//    }

//    // Instance method.
//    public void Drive()
//    {
//        TimeSpan elapsedTime = DateTime.Now - globalStartTime;

//        // For demonstration purposes we treat milliseconds as minutes to simulate
//        // actual bus times. Do not do this in your actual bus schedule program!
//        Console.WriteLine("{0} is starting its route {1:N2} minutes after global start time {2}.",
//                                this.RouteNumber,
//                                elapsedTime.Milliseconds,
//                                globalStartTime.ToShortTimeString());
//    }
//}

//class TestBus
//{
//    static void Main()
//    {
//        // The creation of this instance activates the static constructor.
//        Bus bus1 = new Bus(71);

//        // Create a second bus.
//        Bus bus2 = new Bus(72);

//        // Send bus1 on its way.
//        bus1.Drive();

//        // Wait for bus2 to warm up.
//        System.Threading.Thread.Sleep(25);

//        // Send bus2 on its way.
//        bus2.Drive();

//        // Keep the console window open in debug mode.
//        Console.WriteLine("Press any key to exit.");
//        Console.ReadKey();
//    }
//}


////INHERITANCE
//// How to use inheritance
//class Base_Class
//{
//    // do something
//}

//class Sub_Base_Class : Base_Class
//{
//    // do something
//}

//// CONTOH 1
//// How to use inheritance
//class Base_Class
//{
//    protected static int GenerateId;
//    protected int Id { get; set; }
//    protected string Name { get; set; }

//    public Base_Class()
//    {
//        Id = 1;
//        Name = "Anton";
//    }

//    public Base_Class(int id, string name)
//    {
//        this.Id = GetNextID();
//        this.Name = name;
//    }

//    // generate Id by adding it 1
//    protected int GetNextID() => ++GenerateId;

//    // update name
//    public void Update(string name)
//    {
//        this.Name = name;
//    }

//    public override string ToString() =>
//        $"{this.Id} - {this.Name}";
//}

//class Sub_Base_Class : Base_Class
//{
//    // do something
//    protected int OriId { get; set; }
//    public Sub_Base_Class()
//    {

//    }

//    public Sub_Base_Class(string name, int oriId)
//    {
//        // The following properties and the GetNexID method are inherited
//        // from Base_Class.
//        this.Id = GetNextID();
//        this.Name = name;

//        // Property OriId is a member of Sub_Base_Class, but not
//        // of Base_Class.
//        this.OriId = oriId;
//    }

//    public static void Main()
//    {
//        // Create an instance of WorkItem by using the constructor in the
//        // base class that takes three arguments.
//        Base_Class baseClass = new Base_Class(1, "Fix Bugs");

//        // Create an instance of ChangeRequest by using the constructor in
//        // the derived class that takes four arguments.
//        Sub_Base_Class change = new Sub_Base_Class("Change Base Class Design", 1);

//        // Use the ToString method defined in WorkItem.
//        Console.WriteLine(baseClass.ToString());

//        // Use the inherited Update method to change the title of the
//        // ChangeRequest object.
//        change.Update("Change the Design of the Base Class");

//        // ChangeRequest inherits WorkItem's override of ToString.
//        Console.WriteLine(change.ToString());
//        /* Output:
//            1 - Fix Bugs
//            2 - Change the Design of the Base Class
//        */
//    }
//}


// Contoh 2
//class Feline
//{
//    protected int branchId { get; set; }
//    protected string felineName { get; set; }
//    protected string felineType { get; set; }

//    public Feline()
//    {

//    }

//    public Feline(int branchId, string felineName, string felineType)
//    {
//        this.branchId = branchId;
//        this.felineName = felineName;
//        this.felineType = felineType;
//    }

//    public void Update(int branchId, string felineName, string felineType)
//    {
//        this.branchId = branchId;
//        this.felineName = felineName;
//        this.felineType = felineType;
//    }

//    public override string ToString() =>
//        $"{this.branchId} - {this.felineName} - {this.felineType}";
//}

//class Harimau : Feline
//{
//    public Harimau()
//    {

//    }

//    public Harimau(int branchId, string felineName, string felineType)
//    {
//        this.branchId = branchId;
//        this.felineName = felineName;
//        this.felineType = felineType;
//    }

//    static void Main()
//    {
//        Feline cats = new Feline(1, "Kucing Anggora", "Moggy Cat");
//        Console.WriteLine(cats.ToString());

//        Harimau harimau = new Harimau(2, "Harimau", "Big Cats");
//        Console.WriteLine(harimau.ToString());

//        Console.ReadKey();
//    }
//}

// Contoh 3
//class Feline
//{
//    protected int branchId { get; set; }
//    protected string felineName { get; set; }
//    protected string felineType { get; set; }

//    public Feline()
//    {

//    }

//    public Feline(int branchId, string felineName, string felineType)
//    {
//        this.branchId = branchId;
//        this.felineName = felineName;
//        this.felineType = felineType;
//    }

//    public void Update(int branchId, string felineName, string felineType)
//    {
//        this.branchId = branchId;
//        this.felineName = felineName;
//        this.felineType = felineType;
//    }

//    public void Mengeong(string felineName)
//    {
//        Console.WriteLine($"{felineName} Mengeong");
//    }

//    public void Mengaum(string felineName)
//    {
//        Console.WriteLine($"{felineName} Mengaum");
//    }

//    public override string ToString() =>
//        $"{this.branchId} - {this.felineName} - {this.felineType}";
//}

//class Harimau : Feline
//{
//    public Harimau()
//    {

//    }

//    public Harimau(int branchId, string felineName, string felineType)
//    {
//        this.branchId = branchId;
//        this.felineName = felineName;
//        this.felineType = felineType;
//    }

//    static void Main()
//    {
//        Feline cats = new Feline(1, "Kucing Anggora", "Moggy Cat");      
//        Console.WriteLine(cats.ToString());
//        cats.Mengeong("Kucing Anggora");

//        Harimau harimau = new Harimau(2, "Harimau", "Big Cats");
//        Console.WriteLine(harimau.ToString());
//        cats.Mengaum("Harimau");

//        Console.ReadKey();
//    }
//}

//// Contoh 4
//// Inheritance use different file class
//// use file Feline.cs
//using DataTypes;
//class Harimau : Feline
//{
//    public Harimau()
//    {

//    }

//    public Harimau(int branchId, string felineName, string felineType)
//    {
//        this.branchId = branchId;
//        this.felineName = felineName;
//        this.felineType = felineType;
//    }

//    public void BigCats()
//    {
//        Console.WriteLine("Kucing Besar");
//    }

//    static void Main()
//    {
//        Feline cats = new Feline(1, "Kucing Anggora", "Moggy Cat");
//        Console.WriteLine(cats.ToString());
//        cats.Mengeong("Kucing Anggora");
//        cats.Makan();
//        cats.Tidur();

//        Harimau harimau = new Harimau(2, "Harimau", "Big Cats");
//        Console.WriteLine(harimau.ToString());
//        harimau.Mengaum("Harimau");
//        harimau.Makan();
//        harimau.Tidur();
//        harimau.BigCats();

//        Console.ReadKey();
//    }
//}

// Multilevel Inheritance
// C# program to illustrate the
// concept of multilevel inheritance
//using System;
//class Shape
//{
//    double a_width;
//    double a_length;

//    // Default constructor
//    public Shape()
//    {
//        Width = Length = 0.0;
//    }

//    // Constructor for Shape
//    public Shape(double w, double l)
//    {
//        Width = w;
//        Length = l;
//    }

//    // Construct an object with
//    // equal length and width
//    public Shape(double y)
//    {
//        Width = Length = y;
//    }

//    // Properties for Length and Width
//    public double Width
//    {
//        get
//        {
//            return a_width;
//        }

//        set
//        {
//            a_width = value < 0 ? -value : value;
//        }
//    }

//    public double Length
//    {
//        get
//        {
//            return a_length;
//        }

//        set
//        {
//            a_length = value < 0 ? -value : value;
//        }
//    }
//    public void DisplayDim()
//    {
//        Console.WriteLine("Width and Length are "
//                    + Width + " and " + Length);
//    }
//}

//// A derived class of Shape
//// for the rectangle.
//class Rectangle : Shape
//{
//    string Style;

//    // A default constructor.
//    // This invokes the default
//    // constructor of Shape.
//    public Rectangle()
//    {
//        Style = "null";
//    }

//    // Constructor
//    public Rectangle(string s, double w, double l)
//        : base(w, l)
//    {
//        Style = s;
//    }

//    // Construct an square.
//    public Rectangle(double y)
//        : base(y)
//    {
//        Style = "square";
//    }

//    // Return area of rectangle.
//    public double Area()
//    {
//        return Width * Length;
//    }

//    // Display a rectangle's style.
//    public void DisplayStyle()
//    {
//        Console.WriteLine("Rectangle is " + Style);
//    }
//}

//// Inheriting Rectangle class
//class ColorRectangle : Rectangle
//{

//    string rcolor;

//    // Constructor
//    public ColorRectangle(string c, string s,
//                        double w, double l)
//        : base(s, w, l)
//    {
//        rcolor = c;
//    }

//    // Display the color.
//    public void DisplayColor()
//    {
//        Console.WriteLine("Color is " + rcolor);
//    }
//}

//// Driver Class
//class EnigmaCamp
//{
//    // Main Method
//    static void Main()
//    {
//        ColorRectangle r1 = new ColorRectangle("pink",
//                "Fibonacci rectangle", 2.0, 3.236);

//        ColorRectangle r2 = new ColorRectangle("black",
//                                "Square", 4.0, 4.0);

//        Console.WriteLine("Details of r1: ");
//        r1.DisplayStyle();
//        r1.DisplayDim();
//        r1.DisplayColor();

//        Console.WriteLine("Area is " + r1.Area());
//        Console.WriteLine();

//        Console.WriteLine("Details of r2: ");
//        r2.DisplayStyle();
//        r2.DisplayDim();
//        r2.DisplayColor();

//        Console.WriteLine("Area is " + r2.Area());
//        Console.ReadKey();
//    }
//}

// MULTIPLE INHERITANCE
// C# program to illustrate how to
// implement multiple class inheritance
// using interfaces
using System;
using System.Collections;

// Interface 1
interface EC1
{
    void languages();
}

// Parent class 1
class Enigma1 : EC1
{

    // Providing the implementation
    // of languages() method
    public void languages()
    {

        // Creating ArrayList
        ArrayList My_list = new ArrayList();

        // Adding elements in the
        // My_list ArrayList
        My_list.Add("C");
        My_list.Add("C++");
        My_list.Add("C#");
        My_list.Add("Java");

        Console.WriteLine("Languages provided by EnigmaCamp:");
        foreach (var elements in My_list)
        {
            Console.WriteLine(elements);
        }
    }
}

// Interface 2
interface EC2
{
    void courses();
}

// Parent class 2
class Enigma2 : EC2
{

    // Providing the implementation
    // of courses() method
    public void courses()
    {

        // Creating ArrayList
        ArrayList My_list = new ArrayList();

        // Adding elements in the
        // My_list ArrayList
        My_list.Add("System Design");
        My_list.Add("Fork Python");
        My_list.Add("Enigma Classes DSA");
        My_list.Add("Fork Java");

        Console.WriteLine("\nCourses provided by EnigmaCamp:");
        foreach (var elements in My_list)
        {
            Console.WriteLine(elements);
        }
    }
}

// Child class
class EnigmaCamp_Class : EC1, EC2
{

    // Creating objects of Geeks1 and Geeks2 class
    Enigma1 obj1 = new Enigma1();
    Enigma2 obj2 = new Enigma2();

    public void languages()
    {
        obj1.languages();
    }

    public void courses()
    {
        obj2.courses();
    }
}

// Driver Class
public class EnigmaCamp
{
    // Main method
    static public void Main()
    {
        // Creating object of GeeksforGeeks class
        EnigmaCamp_Class obj = new EnigmaCamp_Class();
        obj.languages();
        obj.courses();
    }
}


//// Hierarchical Inheritance
//// Contoh 1
//// C# program to illustrate the above concept
//using System;

//// Base Class
//public class Father
//{
//    public string FatherName()
//    {
//        return "Ravi";
//    }
//}

//// Derived Class
//public class ChildFirst : Father
//{
//    public string ChildDName()
//    {
//        return "Rohan";
//    }
//}

//// Derived Class
//public class ChildSecond : Father
//{
//    public string ChildDName()
//    {
//        return "Nikhil";
//    }
//}

//class EnigmaCamp
//{

//    static public void Main()
//    {
//        ChildFirst first = new ChildFirst();

//        // Displaying Child Name and Father Name for
//        // ChildFirst
//        Console.WriteLine("My name is " + first.ChildDName() +
//                        ". My father name is " +
//                        first.FatherName() + ".");
//        ChildSecond second = new ChildSecond();

//        // Displaying Child Name and Father Name for
//        // ChildSecond
//        Console.WriteLine("My name is " + second.ChildDName() +
//                        ". My father name is " +
//                        second.FatherName() + ".");
//        Console.ReadKey();
//    }
//}

//// Hierarchical Inheritance
//// Contoh 2
//// C# program to illustrate the above concept
//using System;

//// Base Class
//class Person
//{
//    public string name;
//    public int aadhar_id;
//    public int age;

//    public Person(int aadhar_id, int age, string name)
//    {
//        this.aadhar_id = aadhar_id;
//        this.name = name;
//        this.age = age;
//    }
//}

//// Derived Class
//class Teacher : Person
//{
//    public int teacher_salary;

//    public Teacher(int aadhar_id, int salary,
//                string name, int age) : base(aadhar_id,
//                                                age, name)
//    {
//        teacher_salary = salary;
//    }
//    public void TeacherDetails()
//    {
//        Console.WriteLine("teacher ID:	 " + aadhar_id);
//        Console.WriteLine("teacher Name: " + name);
//        Console.WriteLine("teacher Salary: " + teacher_salary);
//        Console.WriteLine("teacher Age:	 " + age);
//    }
//}

//// Derived Class
//class Doctor : Person
//{
//    public int doctor_fees;

//    public Doctor(int aadhar_id, int fees,
//                string name, int age) : base(aadhar_id,
//                                            age, name)
//    {
//        doctor_fees = fees;
//    }
//    public void DoctorDetails()
//    {
//        Console.WriteLine("Doctor ID:	 " + aadhar_id);
//        Console.WriteLine("Doctor Name: " + name);
//        Console.WriteLine("Doctor Fees: " + doctor_fees);
//        Console.WriteLine("Doctor Age:	 " + age);
//    }
//}

//class EnigmaCamp
//{
//    static public void Main()
//    {
//        // Creating objects
//        Teacher t = new Teacher(25054, 50000, "Sanjay", 28);
//        Doctor d = new Doctor(25045, 750, "Rohit", 32);

//        t.TeacherDetails();
//        Console.WriteLine("-----------------------------------");
//        d.DoctorDetails();

//        Console.ReadKey();
//    }
//}


// Hybrid Inheritance
// Contoh 1
// C# program to illustrate the concept
// of inheritance in interface
//using System;
//// declaring an interface
//public interface A
//{

//    // method of interface
//    void mymethod1();
//    void mymethod2();
//}

//// The methods of interface A
//// is inherited into interface B
//public interface B : A
//{
//    // method of interface B
//    void mymethod3();
//}

//// Below class is inheriting
//// only interface B
//// This class must
//// implement both interfaces
//class Talent : B
//{
//    // implementing the method
//    // of interface A
//    public void mymethod1()
//    {
//        Console.WriteLine("Implement method 1");
//    }

//    // Implement the method
//    // of interface A
//    public void mymethod2()
//    {
//        Console.WriteLine("Implement method 2");
//    }

//    // Implement the method
//    // of interface B
//    public void mymethod3()
//    {
//        Console.WriteLine("Implement method 3");
//    }
//}

//// Driver Class
//class EnigmaCamp
//{
//    // Main method
//    static void Main(String[] args)
//    {
//        // creating the object
//        // class of Talent
//        Talent obj = new Talent();

//        // calling the method
//        // using object 'obj'
//        obj.mymethod1();
//        obj.mymethod2();
//        obj.mymethod3();

//        Console.ReadKey();
//    }
//}

//// Contoh 2
//// Hybrid Inheritance via Interface
//using DataTypes;

//class Harimau : IBigCats
//{
//    public void BAB()
//    {
//        Console.WriteLine("BAB");
//    }

//    public void JenisKucing(string jenisKucing)
//    {
//        Console.WriteLine(jenisKucing);
//    }

//    public void Makan()
//    {
//        Console.WriteLine("Makan");
//    }

//    public void Mengaum()
//    {
//        Console.WriteLine("Mengaum");
//    }

//    public void Tidur()
//    {
//        Console.WriteLine("Tidur");
//    }
//}

//class EnigmaCamp
//{
//    // Main method
//    static void Main(String[] args)
//    {
//        // creating the object
//        // class of Talent
//        Harimau obj = new Harimau();

//        // calling the method
//        // using object 'obj'
//        obj.JenisKucing("Harimau");
//        obj.Mengaum();
//        obj.Makan();
//        obj.BAB();
//        obj.Tidur();

//        Console.ReadKey();
//    }
//}

//// Contoh 3
//// Hybrid Inheritance via Interface
//// with different file and how to implement it
//// the file are IFeline and IBigCats, with Class Harimau that implement IBigCats and IFeline
//using DataTypes;
//class EnigmaCamp
//{
//    // Main method
//    static void Main(String[] args)
//    {
//        // creating the object
//        // class of Talent
//        Harimau obj = new Harimau();

//        // calling the method
//        // using object 'obj'
//        obj.JenisKucing("Harimau");
//        obj.Mengaum();
//        obj.Makan();
//        obj.BAB();
//        obj.Tidur();

//        Console.ReadKey();
//    }
//}


// Encapsulation