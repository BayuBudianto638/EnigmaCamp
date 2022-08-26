//// C# Program to illustrate the keywords
//using System;
//class EnigmaCamp
//{
//    // Here static, public, void
//    // are keywords	
//    static public void Main()
//    {
//        // here int is keyword
//        // a is identifier
//        int a = 10;

//        Console.WriteLine("The value of a is: {0}", a);

//        // this is not a valid identifier

//        // removing comment will give compile time error
//        // double int = 10;
//    }
//}

// C# Program to illustrate the
// value type keywords
//using System;
//class EnigmaCamp
//{
//    // Here static, public, void
//    // are keywords	
//    static public void Main()
//    {
//        // here byte is keyword
//        // a is identifier
//        byte a = 47;
//        Console.WriteLine("The value of a is: {0}", a);

//        // here bool is keyword
//        // b is identifier
//        // true is a keyword
//        bool b = true;

//        Console.WriteLine("The value of b is: {0}", b);
//    }
//}

//// C# Program to illustrate the
//// modifiers keywords
//using System;
//class EnigmaCamp
//{
//    class Mod
//    {
//        // using public modifier
//        // keyword
//        public int n1;
//    }

//    // Main Method
//    static void Main(string[] args)
//    {
//        Mod obj1 = new Mod();

//        // access to public members
//        obj1.n1 = 77;

//        Console.WriteLine("Value of n1: {0}", obj1.n1);
//    }
//}

//// C# program to illustrate the statement keywords
//using System;

//class EnigmaCamp
//{
//    public static void Main()
//    {
//        // using for as statement keyword
//        // EnigmaCamp is printed only 2 times
//        // because of continue statement
//        for (int i = 1; i < 3; i++)
//        {
//            // here if and continue are keywords
//            if (i == 2)
//                continue;

//            Console.WriteLine("EnigmaCamp");
//        }
//    }
//}

//// C# Program to illustrate the use of
//// prefixing @ in keywords
//using System;
//class EnigmaCamp
//{
//    // Here static, public, void
//    // are keywords	
//    static public void Main()
//    {
//        // here int is keyword
//        // a is identifier
//        int a = 10;

//        Console.WriteLine("The value of a is: {0}", a);

//        // prefix @ in keyword int which
//        // makes it a valid identifier
//        int @int = 11;

//        Console.WriteLine("The value of a is: {0}", @int);
//    }
//}

// C# program to illustrate contextual keywords
using System;
public class Student
{
    // Declare name field
    private string name = "EnigmaCamp";

    // Declare name property
    public string Name
    {

        // get is contextual keyword
        get
        {
            return name;
        }

        // set is a contextual
        // keyword
        set
        {
            name = value;
        }
    }
}

class TestStudent
{
    // Main Method
    public static void Main(string[] args)
    {
        Student s = new Student();

        // calls set accessor of the property Name,
        // and pass "EGC" as value of the
        // standard field 'value'.
        s.Name = "EGC";

        // displays EGC, Calls the get accessor
        // of the property Name.
        Console.WriteLine("Name: " + s.Name);

        // using get and set as identifier
        int get = 50;
        int set = 70;

        Console.WriteLine("Value of get is: {0}", get);
        Console.WriteLine("Value of set is: {0}", set);
    }
}
