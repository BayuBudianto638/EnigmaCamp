//////CONTOH 1 ENUM
////class Program
////{
////    enum Season
////    {
////        Spring,
////        Summer,
////        Autumn,
////        Winter
////    }

////    static void Main()
////    {
////        var enumList = from EnumSeason in Enum.GetNames(typeof(Season))
////                       select
////                       new
////                       {
////                           Value = EnumSeason
////                       };

////        foreach (var item in enumList)
////        {
////            Console.WriteLine(item);
////        }

////        Console.ReadKey();
////    }
////}

////CONTOH 2 ENUM
//class Program
//{
//    enum Season
//    {
//        Spring,
//        Summer,
//        Autumn,
//        Winter
//    }

//    static void Main()
//    {
//        var enumList = from EnumSeason in Enum.GetNames(typeof(Season))
//                       select
//                       new
//                       {
//                           Value = (int)Enum.Parse(typeof(Season), EnumSeason)
//                       };

//        foreach (var item in enumList)
//        {
//            Console.WriteLine(item);
//        }

//        Console.ReadKey();
//    }
//}


////// CONTOH 3 ENUM
////class Program
////{
////    enum Season
////    {
////        Spring,
////        Summer,
////        Autumn,
////        Winter
////    }

////    static void Main()
////    {
////        Console.WriteLine($"{Season.Spring}");
////        Console.ReadKey();
////    }
////}
///


//// CONTOH 1 STRUCT
//class Program
//{
//    public readonly struct Coords
//    {
//        public Coords(double x, double y)
//        {
//            X = x;
//            Y = y;
//        }

//        public double X { get; init; }
//        public double Y { get; init; }

//        public override string ToString() => $"({X}, {Y})";
//    }

//    public static void Main()
//    {
//        var p1 = new Coords(0, 0);
//        Console.WriteLine(p1);  // output: (0, 0)

//        var p2 = p1 with { X = 3 };
//        Console.WriteLine(p2);  // output: (3, 0)

//        var p3 = p1 with { X = 1, Y = 4 };
//        Console.WriteLine(p3);  // output: (1, 4)

//        Console.ReadKey();
//    }
//}

//// CONTOH 2 STRUCT
//class Program
//{
//    public readonly struct Measurement
//    {
//        public Measurement()
//        {
//            Value = double.NaN;
//            Description = "Undefined";
//        }

//        public Measurement(double value, string description)
//        {
//            Value = value;
//            Description = description;
//        }

//        public double Value { get; init; }
//        public string Description { get; init; }

//        public override string ToString() => $"{Value} ({Description})";
//    }

//    public static void Main()
//    {
//        var m1 = new Measurement();
//        Console.WriteLine(m1);  // output: NaN (Undefined)

//        var m2 = default(Measurement);
//        Console.WriteLine(m2);  // output: 0 ()

//        var ms = new Measurement[2];
//        Console.WriteLine(string.Join(", ", ms));  // output: 0 (), 0 ()
//    }
//}

//// CONTOH 3 STRUCT
//class Program
//{
//    public readonly struct Measurement
//    {
//        public Measurement(double value)
//        {
//            Value = value;
//        }

//        public Measurement(double value, string description)
//        {
//            Value = value;
//            Description = description;
//        }

//        public double Value { get; init; }
//        public string Description { get; init; } = "Ordinary measurement";

//        public override string ToString() => $"{Value} ({Description})";
//    }

//    public static void Main()
//    {
//        var m1 = new Measurement(5);
//        Console.WriteLine(m1);  // output: 5 (Ordinary measurement)

//        var m2 = new Measurement();
//        Console.WriteLine(m2);  // output: 0 ()

//        var m3 = default(Measurement);
//        Console.WriteLine(m3);  // output: 0 ()
//    }
//}

//// CONTOH 4 STRUCT
//public static class StructWithoutNew
//{
//    public struct Coords
//    {
//        public double x;
//        public double y;
//    }

//    public static void Main()
//    {
//        Coords p;
//        p.x = 3;
//        p.y = 4;
//        Console.WriteLine($"({p.x}, {p.y})");  // output: (3, 4)
//    }
//}

//// Contoh 1 Struct Ref
//public ref struct CustomRef
//{
//    public bool IsValid;
//    public Span<int> Inputs;
//    public Span<int> Outputs;
//}

//public readonly ref struct ConversionRequest
//{
//    public ConversionRequest(double rate, ReadOnlySpan<double> values)
//    {
//        Rate = rate;
//        Values = values;
//    }

//    public double Rate { get; }
//    public ReadOnlySpan<double> Values { get; }
//}

//class Program
//{
//    static void Main()
//    {
//        ConversionRequest conversionRequest = new ConversionRequest();
//        var rate = conversionRequest.Rate;

//        Console.WriteLine($"{rate}");
//        Console.ReadKey();
//    }
//}

//// Contoh 2
//// C# program to illustrate the
//// Declaration of structure
//using System;
//namespace ConsoleApplication
//{
//    // Defining ref structure
//    public ref struct Person
//    {
//        // Declaring different data types
//        public string Name;
//        public int Age;
//        public int Weight;
//    }

//    class EC
//    {
//        // Main Method
//        static void Main(string[] args)
//        {

//            // Declare P1 of type Person
//            Person P1;

//            // P1's data
//            P1.Name = "Enigma Camps";
//            P1.Age = 21;
//            P1.Weight = 80;

//            // Displaying the values
//            Console.WriteLine("Data Stored in P1 is " +
//                            P1.Name + ", age is " +
//                            P1.Age + " and weight is " +
//                            P1.Weight);

//        }
//    }
//}

//// Contoh 3
//// C# program to illustrate copy the structure
//using System;
//namespace ConsoleApplication
//{
//    // Defining structure
//    public ref struct Person
//    {
//        // Declaring different data types
//        public string Name;
//        public int Age;
//        public int Weight;

//    }

//    class EC
//    {
//        // Main Method
//        static void Main(string[] args)
//        {
//            // Declare P1 of type Person
//            Person P1;

//            // P1's data
//            P1.Name = "EnigmaCamp";
//            P1.Age = 21;
//            P1.Weight = 80;

//            // Declare P2 of type Person
//            Person P2;

//            // Copying the values of P1 into P2
//            P2 = P1;

//            // Displaying the values of P1
//            Console.WriteLine("Values Stored in P1");
//            Console.WriteLine("Name: " + P1.Name);
//            Console.WriteLine("Age: " + P1.Age);
//            Console.WriteLine("Weight: " + P1.Weight);
//            Console.WriteLine("");

//            // Displaying the values of P2
//            Console.WriteLine("Values Stored in P2");
//            Console.WriteLine("Name: " + P2.Name);
//            Console.WriteLine("Age: " + P2.Age);
//            Console.WriteLine("Weight: " + P2.Weight);
//        }
//    }
//}

//// Contoh 3
//// C# program to illustrate Nesting of structures
//using System;
//namespace ConsoleApplication
//{

//    // first structure defined
//    // with public modifier
//    public ref struct Address
//    {
//        // data member of Address structure
//        public string City;
//        public string State;
//    }


//    // Another structure
//    ref struct Person
//    {
//        // data member of Person structure
//        public string Name;
//        public int Age;

//        // Nesting of Address structure
//        // by creating A1 of type Address
//        public Address A1;
//    }

//    class EC
//    {
//        // Main method
//        static void Main(string[] args)
//        {

//            // Declare p1 of type Person
//            Person p1;

//            // Assigning values to the variables
//            p1.Name = "EnigmaCamp";
//            p1.Age = 12;

//            // Assigning values to the nested
//            // structure data members
//            p1.A1.City = "ABC_City";
//            p1.A1.State = "XYZ_State";

//            Console.WriteLine("Values Stored in p1");
//            Console.WriteLine("Name: " + p1.Name);
//            Console.WriteLine("Age: " + p1.Age);
//            Console.WriteLine("City: " + p1.A1.City);
//            Console.WriteLine("State: " + p1.A1.State);
//        }
//    }
//}

//// Contoh 1
//// Nullable Values
//// C# program to illustrate Nullable Types
//using System;

//class EC
//{
//    // Main Method
//    static void Main(string[] args)
//    {
//        // defining Nullable type
//        Nullable<int> n = null;

//        // using the method
//        // output will be 0 as default
//        // value of null is 0
//        Console.WriteLine(n.GetValueOrDefault());

//        // defining Nullable type
//        int? n1 = null;

//        // using the method
//        // output will be 0 as default
//        // value of null is 0
//        Console.WriteLine(n1.GetValueOrDefault());


//        // using Nullable type syntax
//        // to define non-nullable
//        int? n2 = 47;

//        // using the method
//        Console.WriteLine(n2.GetValueOrDefault());

//        // using Nullable type syntax
//        // to define non-nullable
//        Nullable<int> n3 = 457;

//        // using the method
//        Console.WriteLine(n3.GetValueOrDefault());
//    }
//}

//// Contoh 2
//// C# program to illustrate the
//// use of Nullable type
//using System;

//class EC
//{
//    // Main Method
//    static public void Main()
//    {
//        // a is nullable type
//        // and contains null value
//        int? a = null;

//        // b is nullable type int
//        // and behave as a normal int
//        int? b = 2345;

//        // this will not print
//        // anything on console
//        Console.WriteLine(a);

//        // gives 2345 as output
//        Console.WriteLine(b);
//    }
//}

//// Contoh 3
//// C# program to illustrate the
//// use of Nullable<L>.Hasvalue
//using System;

//class EC
//{
//    // Main Method
//    static void Main()
//    {
//        // a is nullable type
//        // and contains null value
//        Nullable<int> a = null;

//        // check the value of object
//        Console.WriteLine(a.HasValue);

//        // b is nullable type
//        // and contains a value
//        Nullable<int> b = 7;

//        // check the value of object
//        Console.WriteLine(b.HasValue);
//    }
//}

//// Contoh 4
//// C# program to illustrate the
//// use of null-coalescing operator(??)
//using System;

//class EC
//{
//    // Main Method
//    static public void Main()
//    {
//        // a is nullable type
//        // and contains null value
//        int? a = null;

//        // it means if a is null
//        // then assign 3 to b
//        int b = a ?? 3;

//        // It will print 3
//        Console.WriteLine(b);
//    }
//}

//// TUPLE
///The word Tuple means “a data structure which consists of the multiple parts”. 
///So tuple is a data structure which gives you the easiest way to represent a data set which has multiple values that may/may not be related to each other. 
//// C# program to create tuple
//// using Create Method
//// CONTOH 1
//using System;

//public class EC
//{
//    // Main method
//    static public void Main()
//    {
//        // Creating 1-tuple
//        // Using Create Method
//        var My_Tuple1 = Tuple.Create("EnigmaCamp");

//        // Creating 4-tuple
//        // Using Create Method
//        var My_Tuple2 = Tuple.Create(12, 30, 40, 50);

//        // Creating 8-tuple
//        // Using Create Method
//        var My_Tuple3 = Tuple.Create(13, "Geeks", 67,
//                    89.90, 'g', 39939, "geek", 10);
//    }
//}

//// C# program to access the tuple
//// using Item and Rest property
//// CONTOH 2
//using System;

//public class EC
//{

//    // Main method
//    static public void Main()
//    {

//        // Creating 1-tuple
//        // Using Create Method
//        var My_Tuple1 = Tuple.Create("EnigmaCamp");

//        // Accessing the element of Tuple
//        // Using Item property
//        Console.WriteLine("Element of My_Tuple1: " + My_Tuple1.Item1);
//        Console.WriteLine();

//        // Creating 4-tuple
//        // Using Create Method
//        var My_Tuple2 = Tuple.Create(12, 30, 40, 50);

//        // Accessing the element of Tuple
//        // Using Item property
//        Console.WriteLine("Element of My_Tuple2: " + My_Tuple2.Item1);
//        Console.WriteLine("Element of My_Tuple2: " + My_Tuple2.Item2);
//        Console.WriteLine("Element of My_Tuple2: " + My_Tuple2.Item3);
//        Console.WriteLine("Element of My_Tuple2: " + My_Tuple2.Item4);
//        Console.WriteLine();

//        // Creating 8-tuple
//        // Using Create Method
//        var My_Tuple3 = Tuple.Create(13, "Enigma",
//            67, 89.90, 'g', 39939, "Camp", 10);

//        // Accessing the element of Tuple
//        // Using Item property
//        // And print the 8th element of tuple
//        // using Rest property
//        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item1);
//        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item2);
//        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item3);
//        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item4);
//        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item5);
//        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item6);
//        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Item7);
//        Console.WriteLine("Element of My_Tuple3: " + My_Tuple3.Rest);
//    }
//}

//// Contoh 3
//// C# program to illustrate nested tuple
//using System;

//public class EC
//{
//    // Main method
//    static public void Main()
//    {
//        // Nested Tuple
//        var My_Tuple = Tuple.Create(13, "Engima", 67, 89.90,
//                'g', 39939, "Camp", Tuple.Create(12, 30, 40, 50));

//        // Accessing the element of Tuple
//        // Using Item property
//        // And accessing the elements of nested tuple
//        // Using Rest property
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item1);
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item2);
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item3);
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item4);
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item5);
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item6);
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item7);
//        Console.WriteLine("Element of Nested tuple: " + My_Tuple.Rest);
//        Console.WriteLine("Element of Nested tuple: " + My_Tuple.Rest.Item1.Item1);
//        Console.WriteLine("Element of Nested tuple: " + My_Tuple.Rest.Item1.Item2);
//        Console.WriteLine("Element of Nested tuple: " + My_Tuple.Rest.Item1.Item3);
//        Console.WriteLine("Element of Nested tuple: " + My_Tuple.Rest.Item1.Item4);
//    }
//}

//// CONTOH 4
//// C# program to illustrate nested tuple
//using System;

//public class EC
//{
//    // Main method
//    static public void Main()
//    {
//        // Nested Tuple
//        // Here nested tuple is present
//        // at the place of 2nd element
//        var My_Tuple = Tuple.Create(13, Tuple.Create(12, 30, 40,
//                            50), 67, 89.90, 'E', 39939, 123, "Camp");

//        // Accessing the element of Tuple
//        // Using Item property
//        // And accessing the elements of
//        // nested tuple Using Rest property
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item1);
//        Console.WriteLine("Element of Nested Tuple: " + My_Tuple.Item2.Item1);
//        Console.WriteLine("Element of Nested Tuple: " + My_Tuple.Item2.Item2);
//        Console.WriteLine("Element of Nested Tuple: " + My_Tuple.Item2.Item3);
//        Console.WriteLine("Element of Nested Tuple: " + My_Tuple.Item2.Item4);
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item3);
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item4);
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item5);
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item6);
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Item7);
//        Console.WriteLine("Element of My_Tuple: " + My_Tuple.Rest);
//    }
//}

//// CONTOH 5
//// C# program to illustrate the
//// tuple as a method parameter.
//using System;

//public class EC
//{
//    // Main method
//    static public void Main()
//    {
//        // Creating a tuple
//        var mytuple = Tuple.Create("EnigmaCamp", 123, 90.8);

//        // Pass the tuple in the
//        // PrintTheTuple method
//        PrintTheTuple(mytuple);
//    }

//    static void PrintTheTuple(Tuple<string, int, double> mytuple)
//    {
//        Console.WriteLine("Element: " + mytuple.Item1);
//        Console.WriteLine("Element: " + mytuple.Item2);
//        Console.WriteLine("Element: " + mytuple.Item3);
//    }
//}

//// CONTOH 6
//// C# program to illustrate
//// how a method return tuple
//using System;

//public class GFECG
//{

//    // Main Method
//    static public void Main()
//    {
//        // Return tuple is stored in mytuple
//        var mytuple = PrintTuple();
//        Console.WriteLine(mytuple.Item1);
//        Console.WriteLine(mytuple.Item2);
//        Console.WriteLine(mytuple.Item3);
//    }

//    // PrintTuple method return a tuple
//    static Tuple<string, string, string> PrintTuple()
//    {
//        return Tuple.Create("Enigma", "-", "Camp");
//    }
//}


//// TUPLE CLASS
//// C# program to create tuple
//// using tuple constructor.
//using System;

//class EC
//{
//    // Main method
//    static public void Main()
//    {
//        // Creating tuple with seven elements
//        // Using Tuple<T1, T2, T3, T4, T5, T6,
//        // T7>(T1, T2, T3, T4, T5, T6, T7) constructor
//        Tuple<int, int, int, int, int, int, int> My_Tuple = new Tuple<int,
//            int, int, int, int, int, int>(22, 334, 54, 65, 76, 87, 98);

//        Console.WriteLine("Element 1: " + My_Tuple.Item1);
//        Console.WriteLine("Element 2: " + My_Tuple.Item2);
//        Console.WriteLine("Element 3: " + My_Tuple.Item3);
//        Console.WriteLine("Element 4: " + My_Tuple.Item4);
//        Console.WriteLine("Element 5: " + My_Tuple.Item5);
//        Console.WriteLine("Element 6: " + My_Tuple.Item6);
//        Console.WriteLine("Element 7: " + My_Tuple.Item7);
//    }
//}


//// C# program to create 3-tuple
//// using create method
//using System;

//class EC
//{
//    // Main method
//    static public void Main()
//    {
//        // Creating tuple with three elements
//        // Using Create method
//        var My_Tuple = Tuple.Create("EC", 2323, 'e');

//        Console.WriteLine("Element 1: " + My_Tuple.Item1);
//        Console.WriteLine("Element 2: " + My_Tuple.Item2);
//        Console.WriteLine("Element 3: " + My_Tuple.Item3);
//    }
//}


// VALUE TUPLE
//// C# program to illustrate how to
//// create value tuple using the
//// ValueTuple constructor.
//using System;

//class EC
//{

//    // Main method
//    static public void Main()
//    {
//        // ValueTuple with one element
//        ValueTuple<int> ValTpl1 = new ValueTuple<int>(345678);

//        // ValueTuple with three elements
//        ValueTuple<string, string, int> ValTpl2 = new ValueTuple<string,
//                                        string, int>("C#", "Delphi", 586);

//        // ValueTuple with eight elements
//        ValueTuple<int, int, int, int, int, int, int, ValueTuple<int>> ValTpl3 = new ValueTuple<int,
//                                int, int, int, int, int, int, ValueTuple<int>>(45, 67, 65, 34, 34,
//                                                                    34, 23, new ValueTuple<int>(90));
//    }
//}

//// C# program to create value tuple
//// using Create Method
//using System;

//public class EC
//{
//    // Main method
//    static public void Main()
//    {
//        // Creating 0-ValueTuple
//        // Using Create() Method
//        var Valtpl1 = ValueTuple.Create();

//        // Creating 3-ValueTuple
//        // Using Create(T1, T2, T3) Method
//        var Valtpl2 = ValueTuple.Create(12, 30, 40, 50);

//        // Creating 8-ValueTuple
//        // Using Create(T1, T2, T3, T4, T5, T6, T7, T8) Method
//        var Valtpl3 = ValueTuple.Create(34, "EnigmaCamp",
//                    'g', 'f', 'g', 56.78, 4323, "ec");
//    }
//}

//// C# program to illustrated named member
//using System;

//public class EC
//{
//    static public void Main()
//    {
//        (int age, string Aname, string Lang) author = (23, "Sonia", "C#");
//    }
//}

//// C# program to illustrated named member
//using System;

//public class EC
//{

//    static public void Main()
//    {
//        var author = (age: 23, Aname
//                    : "Sonia", Lang
//                    : "C#");
//    }
//}

//// CONTOH DELEGATE
//// C# program to illustrate the use of Delegates
//using System;
//namespace EnigmaCamp
//{
//    // declare class "Geeks"
//    class EC
//    {
//        // Declaring the delegates
//        // Here return type and parameter type should
//        // be same as the return type and parameter type
//        // of the two methods
//        // "addnum" and "subnum" are two delegate names
//        public delegate void addnum(int a, int b);
//        public delegate void subnum(int a, int b);

//        // method "sum"
//        public void sum(int a, int b)
//        {
//            Console.WriteLine("(100 + 40) = {0}", a + b);
//        }

//        // method "subtract"
//        public void subtract(int a, int b)
//        {
//            Console.WriteLine("(100 - 60) = {0}", a - b);
//        }

//        // Main Method
//        public static void Main(String[] args)
//        {

//            // creating object "obj" of class "EC"
//            EC obj = new EC();

//            // creating object of delegate, name as "del_obj1"
//            // for method "sum" and "del_obj2" for method "subtract" &
//            // pass the parameter as the two methods by class object "obj"
//            // instantiating the delegates
//            addnum del_obj1 = new addnum(obj.sum);
//            subnum del_obj2 = new subnum(obj.subtract);

//            // pass the values to the methods by delegate object
//            del_obj1(100, 40);
//            del_obj2(100, 60);

//            // These can be written as using
//            // "Invoke" method
//            // del_obj1.Invoke(100, 40);
//            // del_obj2.Invoke(100, 60);
//        }
//    }
//}

//// C# program to illustrate the
//// Multicasting of Delegates
//using System;

//class rectangle
//{
//    // declaring delegate
//    public delegate void rectDelegate(double height,
//                                    double width);

//    // "area" method
//    public void area(double height, double width)
//    {
//        Console.WriteLine("Area is: {0}", (width * height));
//    }

//    // "perimeter" method
//    public void perimeter(double height, double width)
//    {
//        Console.WriteLine("Perimeter is: {0} ", 2 * (width + height));
//    }

//    // Main Method
//    public static void Main(String[] args)
//    {
//        // creating object of class
//        // "rectangle", named as "rect"
//        rectangle rect = new rectangle();

//        // these two lines are normal calling
//        // of that two methods
//        // rect.area(6.3, 4.2);
//        // rect.perimeter(6.3, 4.2);

//        // creating delegate object, name as "rectdele"
//        // and pass the method as parameter by
//        // class object "rect"
//        rectDelegate rectdele = new rectDelegate(rect.area);

//        // also can be written as
//        // rectDelegate rectdele = rect.area;

//        // call 2nd method "perimeter"
//        // Multicasting
//        rectdele += rect.perimeter;

//        // pass the values in two method
//        // by using "Invoke" method
//        rectdele.Invoke(6.3, 4.2);
//        Console.WriteLine();

//        // call the methods with
//        // different values
//        rectdele.Invoke(16.3, 10.3);
//    }
//}


////PREIDACTE DELEGATE
//// C# program to illustrate delegates
//using System;

//class EC
//{
//    // Declaring the delegate
//    public delegate bool my_delegate(string mystring);

//    // Method
//    public static bool myfun(string mystring)
//    {
//        if (mystring.Length < 7)
//        {
//            return true;
//        }

//        else
//        {
//            return false;
//        }
//    }

//    // Main method
//    static public void Main()
//    {
//        // Creating object of my_delegate
//        my_delegate obj = myfun;
//        Console.WriteLine(obj("Hello"));
//    }
//}

//// C# program to illustrate Action delegates
//using System;

//class EC
//{
//    // Method
//    public static void myfun(int p, int q)
//    {
//        Console.WriteLine(p - q);
//    }

//    // Main method
//    static public void Main()
//    {

//        // Using Action delegate
//        // Here, Action delegate
//        // contains two input parameters
//        Action<int, int> val = myfun;
//        val(20, 5);
//    }
//}

// C# program to illustrate Func delegate
using System;

class EC
{
    // Method
    public static int mymethod(int s, int d, int f, int g)
    {
        return s * d * f * g;
    }

    // Main method
    static public void Main()
    {

        // Using Func delegate
        // Here, Func delegate contains
        // the four parameters of int type
        // one result parameter of int type
        Func<int, int, int, int, int> val = mymethod;
        Console.WriteLine(val(10, 100, 1000, 1));
    }
}
