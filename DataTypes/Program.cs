//In C#, a class is a blueprint for an object. It defines the properties (data) and behaviors (methods) of the object. 
//A class is a template for creating objects, and it is defined using the class keyword.

//Here is an example of a simple
//class Program
//{
//    public class Person
//    {
//        // Properties (data)
//        public string Name { get; set; }
//        public int Age { get; set; }
//        public string Gender { get; set; }

//        // Constructor
//        public Person(string name, int age, string gender)
//        {
//            Name = name;
//            Age = age;
//            Gender = gender;
//        }

//        // Method (behavior)
//        public void SayHello()
//        {
//            Console.WriteLine("Hello, my name is " + Name);
//        }
//    }

//    static void Main()
//    {
//        Person p = new Person("John", 30, "Male");
//        Console.WriteLine(p.Name); // Outputs "John"
//        p.SayHello(); // Outputs "Hello, my name is John"
//    }
//}


// Access Modifier
// Access Modifier adalah keyword yg mengontrol aksesibilitas dr sebuah class, method, property dan lainnya dr sebuah program
// Access modifier menentukan apakah anggota dr class itu bisa di akses dr luar atauhanya dr class itu sendiri.

// public : access modifier ini membuat sebuah method, property atau class bisa di panggil dimanapu dlm sebuah program
// private : access modifier ini membuat sebuah method, property atau class hanya bisa di panggil didalam class itu sendiri
// protected : access modifier ini hanya membuat sebuah method property hanya bisa di panggil didalam class itu sendiri,
// atau dr class turunannya
// internal : access modifier ini membuat sebuah method, property atau class bisa di panggil dimanapun tp hanya
// dlm project sendiri atau assemblies sendiri
// protected internal : gabungan antara internal dan protected



//class Program
//{
//    static void Main()
//    {
//        MyClass myClass = new MyClass();
//        int result = myClass.Addition(1, 2);
//        Console.WriteLine(result);

//        int resultStatic = MyClass.AdditionStatic(1, 2);
//    }

//    class MyClass
//    {
//        public int Addition(int x, int y) // by default adalah private
//        {
//            return x + y;
//        }

//        public static int AdditionStatic(int x, int y)
//        {
//            return x + y;
//        }
//    }
//}

// Constructor
//Types of Constructor
//Default Constructor
//Parameterized Constructor
//Copy Constructor
//Private Constructor
//Static Constructor

//using System.Xml.Linq;

////Default Constructor
//class Program
//{
//    static void Main()
//    {
//        MyClass myClass = new MyClass();
//        int result = myClass.Addition(1, 2);
//        Console.WriteLine(result);

//        int resultStatic = MyClass.AdditionStatic(1, 2);
//    }

//    public class MyClass
//    {
//        public MyClass()
//        {
//            Console.WriteLine("Constructor called");
//        }

//        ~MyClass()
//        {
//            // Release resources here
//            Console.WriteLine("MyClass object being garbage collected");
//        }

//        public int Addition(int x, int y) // by default adalah private
//        {
//            return x + y;
//        }

//        public static int AdditionStatic(int x, int y)
//        {
//            return x + y;
//        }
//    }
//}

// Parameterized Constructor
// C# Program to illustrate calling of
// parameterized constructor.
//using System;
//namespace ParameterizedConstructorExample
//{

//    class MyClass
//    {
//        // data members of the class.
//        String name;
//        int id;

//        // parameterized constructor would
//        // initialized data members with
//        // the values of passed arguments
//        // while object of that class created.
//        MyClass(String name, int id)
//        {
//            this.name = name;
//            this.id = id;
//        }

//        // Main Method
//        public static void Main()
//        {

//            // This will invoke parameterized
//            // constructor.
//            MyClass geek1 = new MyClass("GFG", 1);
//            Console.WriteLine("GeekName = " + geek1.name +
//                            " and GeekId = " + geek1.id);
//        }
//    }
//}

// C# Program to illustrate calling
// a Copy constructor
//using System;
//namespace copyConstructorExample
//{

//    class MyClass
//    {
//        private string month;
//        private int year;

//        // declaring Copy constructor
//        public MyClass(Geeks s)
//        {
//            month = s.month;
//            year = s.year;
//        }

//        // Instance constructor
//        public MyClass(string month, int year)
//        {
//            this.month = month;
//            this.year = year;
//        }

//        // Get details of Geeks
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

//            // Create a new Geeks object.
//            MyClass g1 = new MyClass("June", 2018);

//            // here is g1 details is copied to g2.
//            MyClass g2 = new MyClass(g1);

//            Console.WriteLine(g2.Details);
//        }
//    }
//}

//// C# Program to illustrate calling
//// a Private constructor
//using System;
//namespace privateConstructorExample
//{

//    public class Geeks
//    {

//        // declare private Constructor
//        private Geeks()
//        {
//        }

//        // declare static variable field
//        public static int count_geeks;

//        // declare static method
//        public static int geeks_Count()
//        {
//            return ++count_geeks;
//        }

//        // Main Method
//        public static void Main()
//        {

//            // If you uncomment the following
//            // statement, it will generate
//            // an error because the constructor
//            // is unaccessible:
//            // Geeks s = new Geeks(); // Error

//            Geeks.count_geeks = 99;

//            // Accessing without any
//            // instance of the class
//            Geeks.geeks_Count();

//            Console.WriteLine(Geeks.count_geeks);

//            // Accessing without any
//            // instance of the class
//            Geeks.geeks_Count();

//            Console.WriteLine(Geeks.count_geeks);
//        }
//    }
//}

//// C# Program to illustrate calling
//// a Static constructor
//using System;
//namespace staticConstructorExample
//{

//    class geeks
//    {

//        // It is invoked before the first
//        // instance constructor is run.
//        static geeks()
//        {

//            // The following statement produces
//            // the first line of output,
//            // and the line occurs only once.
//            Console.WriteLine("Static Constructor");
//        }

//        // Instance constructor.
//        public geeks(int i)
//        {
//            Console.WriteLine("Instance Constructor " + i);
//        }

//        // Instance method.
//        public string geeks_detail(string name, int id)
//        {
//            return "Name:" + name + " id:" + id;
//        }

//        // Main Method
//        public static void Main()
//        {

//            // Here Both Static and instance
//            // constructors are invoked for
//            // first instance
//            geeks obj = new geeks(1);

//            Console.WriteLine(obj.geeks_detail("GFG", 1));

//            // Here only instance constructor
//            // will be invoked
//            geeks obj1 = new geeks(2);

//            Console.WriteLine(obj1.geeks_detail("GeeksforGeeks", 2));
//        }
//    }
//}

//public class Person
//{
//    private string name;
//    private int age;

//    public string Name
//    {
//        get { return name; }
//        set
//        {
//            if (value != null && value.Length > 0)
//            {
//                name = value;
//            }
//            else
//            {
//                throw new ArgumentException("Error");
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person p = new Person();
//        p.Name = null;

//        Console.WriteLine($"{p.Name}");
//    }
//}


//public class Person
//{
//    // Properties (data)
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public string Gender { get; set; }

//    // Constructor
//    public Person(string name, int age, string gender)
//    {
//        Name = name;
//        Age = age;
//        Gender = gender;
//    }

//    // Method (behavior)
//    public void SayHello()
//    {
//        Console.WriteLine("Hello, my name is " + Name);
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Person p = new Person("John", 30, "Male");
//        Console.WriteLine(p.Name); // Outputs "John"
//        p.SayHello(); // Outputs "Hello, my name is John"
//    }
//}

//class Something
//{
//    private int _w;
//    public int Weight
//    {
//        get { return _w; }
//        set
//        {
//            if (value < 100)
//                throw new ArgumentException("weight too small");

//            _w = value;
//            RecalculateDensity();
//        }
//    }
//    void RecalculateDensity()
//    {
//        // statement
//        Console.WriteLine("Recalculate Method");
//    }
//    // and other methods
//}

//class Program
//{
//    static void Main()
//    {
//        Something s = new Something();
//        s.Weight = 10;
//    }
//}


//// C# Program to illustrate how
//// a destructor works
//using System;

//namespace GeeksforGeeks
//{

//    class Complex
//    {

//        // Class members, private
//        // by default
//        int real, img;

//        // Defining the constructor
//        public Complex()
//        {
//            real = 0;
//            img = 0;
//        }

//        // SetValue method sets
//        // value of real and img
//        public void SetValue(int r, int i)
//        {
//            real = r;
//            img = i;
//        }

//        // DisplayValue displays
//        // values of real and img
//        public void DisplayValue()
//        {
//            Console.WriteLine("Real = " + real);
//            Console.WriteLine("Imaginary = " + img);
//        }

//        // Defining the destructor
//        // for class Complex
//        ~Complex()
//        {
//            Console.WriteLine("Destructor was called");
//        }

//    } // End class Complex


//    // Driver Class
//    class Program
//    {
//        // Main Method
//        static void Main(string[] args)
//        {

//            // Creating an instance of class
//            // Complex C invokes constructor
//            Complex C = new Complex();

//            // Calling SetValue method using
//            // instance C Setting values of
//            // real to 2 and img to 3
//            C.SetValue(2, 3);

//            // Displaying values of real
//            // and imaginary parts
//            C.DisplayValue();

//            // Instance is no longer needed
//            // Destructor will be called

//        } // End Main

//    } // End class Program

//}

//using System;
//namespace DestructorExample
//{
//    class DestructorDemo
//    {
//        public DestructorDemo()
//        {
//            Console.WriteLine("Constructor Object Created");
//        }
//        ~DestructorDemo()
//        {
//            string type = GetType().Name;
//            Console.WriteLine($"Object {type} is Destroyed");
//        }
//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            DestructorDemo obj1 = new DestructorDemo();
//            DestructorDemo obj2 = new DestructorDemo();
//            //Making obj1 for Garbage Collection
//            obj1 = null;
//            GC.Collect();
//            Console.ReadKey();
//        }
//    }
//}

//using System;
//namespace GarbageCollectionDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            MyClass1 obj1 = new MyClass1();
//            obj1.Dispose();

//            Console.Read();
//        }
//    }

//    public class MyClass1 : IDisposable
//    {

//        #region IDisposable Support
//        private bool disposedValue = false; // To detect redundant calls

//        protected virtual void Dispose(bool disposing)
//        {
//            if (!disposedValue)
//            {
//                if (disposing)
//                {
//                    // TODO: dispose managed state (managed objects).
//                }

//                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
//                // TODO: set large fields to null.

//                disposedValue = true;
//            }
//        }

//        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
//        ~MyClass1()
//        {
//            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.            
//            Dispose(false);
//        }

//        // This code added to correctly implement the disposable pattern.
//        public void Dispose()
//        {
//            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
//            Dispose(true);
//            // TODO: uncomment the following line if the finalizer is overridden above.
//            GC.SuppressFinalize(this);
//        }
//        #endregion

//    }
//}

////// CONTOH 1
////using System;

////namespace PolymorphismApplication
////{
////    class Printdata
////    {
////        void print(int i)
////        {
////            Console.WriteLine("Printing int: {0}", i);
////        }

////        void print(double f)
////        {
////            Console.WriteLine("Printing float: {0}", f);
////        }

////        void print(string s)
////        {
////            Console.WriteLine("Printing string: {0}", s);
////        }

////        static void Main(string[] args)
////        {
////            Printdata p = new Printdata();

////            // Call print to print integer
////            p.print(5);

////            // Call print to print float
////            p.print(500.263);

////            // Call print to print string
////            p.print("Hello C#");
////            Console.ReadKey();
////        }
////    }
////}

//// Contoh 2
//class Animal  // Base class (parent) 
//{
//    public void animalSound()
//    {
//        Console.WriteLine("The animal makes a sound");
//    }
//}

//class Pig : Animal  // Derived class (child) 
//{
//    public void animalSound()
//    {
//        Console.WriteLine("The pig says: wee wee");
//    }
//}

//class Dog : Animal  // Derived class (child) 
//{
//    public void animalSound()
//    {
//        Console.WriteLine("The dog says: woof woof");
//    }
//}

//class MainClass
//{
//    static void Main()
//    {
//        Pig pig = new Pig();
//        pig.animalSound();

//        Dog dog = new Dog();
//        dog.animalSound();

//        Console.ReadKey();
//    }
//}


////// Contoh 3
////class Animal  // Base class (parent) 
////{
////    public void animalSound()
////    {
////        Console.WriteLine("The animal makes a sound");
////    }
////}

////class Pig : Animal  // Derived class (child) 
////{
////    public void animalSound()
////    {
////        Console.WriteLine("The pig says: wee wee");
////    }
////}

////class Dog : Animal  // Derived class (child) 
////{
////    public void animalSound()
////    {
////        Console.WriteLine("The dog says: bow wow");
////    }
////}

////class Program
////{
////    static void Main(string[] args)
////    {
////        Animal myAnimal = new Animal();  // Create a Animal object
////        Animal myPig = new Pig();  // Create a Pig object
////        Animal myDog = new Dog();  // Create a Dog object

////        myAnimal.animalSound();
////        myPig.animalSound();
////        myDog.animalSound();

////        Console.ReadKey();
////    }
////}
///

////// Contoh 4
////class Animal  // Base class (parent) 
////{
////    public virtual void animalSound()
////    {
////        Console.WriteLine("The animal makes a sound");
////    }
////}

////class Pig : Animal  // Derived class (child) 
////{
////    public override void animalSound()
////    {
////        Console.WriteLine("The pig says: wee wee");
////    }
////}

////class Dog : Animal  // Derived class (child) 
////{
////    public override void animalSound()
////    {
////        Console.WriteLine("The dog says: woof woof");
////    }
////}

////class Program
////{
////    static void Main(string[] args)
////    {
////        Animal myAnimal = new Animal();  // Create a Animal object
////        Animal myPig = new Pig();  // Create a Pig object
////        Animal myDog = new Dog();  // Create a Dog object

////        myAnimal.animalSound();
////        myPig.animalSound();
////        myDog.animalSound();
////    }
////}

////// Dynamic Polimorphism
////using System;

////namespace PolymorphismApplication
////{
////    abstract class Shape
////    {
////        public abstract int area();
////    }

////    class Rectangle : Shape
////    {
////        private int length;
////        private int width;

////        public Rectangle(int a = 0, int b = 0)
////        {
////            length = a;
////            width = b;
////        }
////        public override int area()
////        {
////            Console.WriteLine("Rectangle class area :");
////            return (width * length);
////        }
////    }

////    class RectangleTester
////    {
////        static void Main(string[] args)
////        {
////            Rectangle r = new Rectangle(10, 7);
////            double a = r.area();
////            Console.WriteLine("Area: {0}", a);
////            Console.ReadKey();
////        }
////    }
////}

//using System;

//namespace PolymorphismApplication
//{
//    class Shape
//    {
//        protected int width, height;

//        public Shape(int a = 0, int b = 0)
//        {
//            width = a;
//            height = b;
//        }
//        public virtual int area()
//        {
//            Console.WriteLine("Parent class area :");
//            return 0;
//        }
//    }
//    class Rectangle : Shape
//    {
//        public Rectangle(int a = 0, int b = 0) : base(a, b)
//        {

//        }
//        public override int area()
//        {
//            Console.WriteLine("Rectangle class area :");
//            return (width * height);
//        }
//    }
//    class Triangle : Shape
//    {
//        public Triangle(int a = 0, int b = 0) : base(a, b)
//        {
//        }
//        public override int area()
//        {
//            Console.WriteLine("Triangle class area :");
//            return (width * height / 2);
//        }
//    }
//    class Caller
//    {
//        public void CallArea(Shape sh)
//        {
//            int a;
//            a = sh.area();
//            Console.WriteLine("Area: {0}", a);
//        }
//    }
//    class Tester
//    {
//        static void Main(string[] args)
//        {
//            Caller c = new Caller();
//            Rectangle r = new Rectangle(10, 7);
//            Triangle t = new Triangle(10, 5);

//            c.CallArea(r);
//            c.CallArea(t);
//            Console.ReadKey();
//        }
//    }
//}

