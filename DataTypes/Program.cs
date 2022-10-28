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

////// Contoh 2
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
////        Console.WriteLine("The dog says: woof woof");
////    }
////}

////class MainClass
////{
////    static void Main()
////    {
////        Pig pig = new Pig();
////        pig.animalSound();

////        Dog dog = new Dog();
////        dog.animalSound();

////        Console.ReadKey();
////    }
////}


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

// C# Program to illustrate how
// a destructor works
using System;

namespace GeeksforGeeks
{

    class Complex
    {

        // Class members, private
        // by default
        int real, img;

        // Defining the constructor
        public Complex()
        {
            real = 0;
            img = 0;
        }

        // SetValue method sets
        // value of real and img
        public void SetValue(int r, int i)
        {
            real = r;
            img = i;
        }

        // DisplayValue displays
        // values of real and img
        public void DisplayValue()
        {
            Console.WriteLine("Real = " + real);
            Console.WriteLine("Imaginary = " + img);
        }

        // Defining the destructor
        // for class Complex
        ~Complex()
        {
            Console.WriteLine("Destructor was called");
        }

    } // End class Complex


    // Driver Class
    class Program
    {
        // Main Method
        static void Main(string[] args)
        {

            // Creating an instance of class
            // Complex C invokes constructor
            Complex C = new Complex();

            // Calling SetValue method using
            // instance C Setting values of
            // real to 2 and img to 3
            C.SetValue(2, 3);

            // Displaying values of real
            // and imaginary parts
            C.DisplayValue();

            // Instance is no longer needed
            // Destructor will be called

        } // End Main

    } // End class Program

}
