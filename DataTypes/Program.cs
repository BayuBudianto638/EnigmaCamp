//// C# program to illustrate
//// if statement
//using System;
//public class EnigmaCamp
//{
//    public static void Main(string[] args)
//    {
//        string name = "EnigmaCamp";
//        if (name == "EnigmaCamp")
//        {
//            Console.WriteLine("EnigmaCamp");
//        }

//        Console.ReadKey();
//    }
//}


//// C# program to illustrate
//// if-else statement
//using System;
//public class EnigmaCamp
//{
//    public static void Main(string[] args)
//    {
//        string name = "EnigmaCamp";
//        if (name == "EnigmaCamps")
//        {
//            Console.WriteLine("EnigmaCamp");
//        }
//        else
//        {
//            Console.WriteLine("EnigmaCamp");
//        }
//    }
//}


//// C# program to illustrate
//// if-else-if ladder
//using System;
//class EnigmaCamp
//{
//    public static void Main(String[] args)
//    {
//        int i = 20;

//        if (i == 10)
//            Console.WriteLine("i is 10");
//        else if (i == 15)
//            Console.WriteLine("i is 15");
//        else if (i == 20)
//            Console.WriteLine("i is 20");
//        else
//            Console.WriteLine("i is not present");
//    }
//}

// C# program to illustrate
// nested-if statement
//using System;
//class EnigmaCamp
//{
//    public static void Main(String[] args)
//    {
//        int i = 10;

//        if (i == 10)
//        {

//            // Nested - if statement
//            // Will only be executed if statement
//            // above it is true
//            if (i < 12)
//                Console.WriteLine("i is smaller than 12 too");
//            else
//                Console.WriteLine("i is greater than 15");
//        }
//    }
//}

// C# example for switch case
//using System;
//public class EnigmaCamp
//{
//    public static void Main(String[] args)
//    {
//        int number = 30;
//        switch (number)
//        {
//            case 10:
//                Console.WriteLine("case 10");
//                break;
//            case 20:
//                Console.WriteLine("case 20");
//                break;
//            case 30:
//                Console.WriteLine("case 30");
//                break;
//            default:
//                Console.WriteLine("None matches");
//                break;
//        }
//    }
//}

// C# example for nested switch case
//using System;
//public class EnigmaCamp
//{
//    public static void Main(String[] args)
//    {
//        int j = 5;

//        switch (j)
//        {
//            case 5:
//                Console.WriteLine(5);
//                switch (j - 1)
//                {
//                    case 4:
//                        Console.WriteLine(4);
//                        switch (j - 2)
//                        {
//                            case 3:
//                                Console.WriteLine(3);
//                                break;
//                        }
//                        break;
//                }
//                break;
//            case 10:
//                Console.WriteLine(10);
//                break;
//            case 15:
//                Console.WriteLine(15);
//                break;
//            default:
//                Console.WriteLine(100);
//                break;
//        }

//    }
//}

// C# program to illustrate
// switch case statement
//using System;
//public class EnigmaCamp
//{
//    // Main Method
//    public static void Main(String[] args)
//    {
//        int nitem = 5;
//        switch (nitem)
//        {

//            case 1:
//                Console.WriteLine("case 1");
//                break;

//            case 5:
//                Console.WriteLine("case 5");
//                break;

//            case 9:
//                Console.WriteLine("case 9");
//                break;

//            default:
//                Console.WriteLine("No match found");
//                break;
//        }
//    }
//}

// C# program to illustrate
// if-else statement
//using System;
//class EnigmaCamp
//{
//    // Main Method
//    public static void Main(String[] args)
//    {
//        // taking two strings value
//        string topic;
//        string category;

//        // taking topic name
//        topic = "Inheritance";

//        // using compare function of string class
//        if ((String.Compare(topic, "Introduction to C#") == 0) ||
//            (String.Compare(topic, "Variables") == 0) ||
//            (String.Compare(topic, "Data Types") == 0))
//        {
//            category = "Basic";
//        }

//        // using compare function of string class
//        else if ((String.Compare(topic, "Loops") == 0) ||
//                (String.Compare(topic, "If Statements") == 0) ||
//                (String.Compare(topic, "Jump Statements") == 0))
//        {
//            category = "Control Flow";
//        }

//        // using compare function of string class
//        else if ((String.Compare(topic, "Class & Object") == 0) ||
//                (String.Compare(topic, "Inheritance") == 0) ||
//                (String.Compare(topic, "Constructors") == 0))
//        {
//            category = "OOPS Concept";
//        }

//        else
//        {
//            category = "Not Mentioned";
//        }

//        System.Console.Write("Category is " + category);
//    }
//}

// C# program to illustrate
// switch statement
//using System;
//class EnigmaCamp
//{
//    // Main Method
//    public static void Main(String[] args)
//    {
//        // taking two strings value
//        string topic;
//        string category;

//        // taking topic name
//        topic = "Inheritance";

//        // using switch Statement
//        switch (topic)
//        {
//            case "Introduction to C#":
//            case "Variables":
//            case "Data Types":

//                category = "Basic";
//                break;

//            case "Loops":
//            case "If Statements":
//            case "Jump Statements":

//                category = "Control Flow";
//                break;

//            case "Class & Object":
//            case "Inheritance":
//            case "Constructors":

//                category = "OOPS Concept";
//                break;

//            // default case
//            default:
//                category = "Not Mentioned";
//                break;

//        }

//        System.Console.Write("Category is " + category);
//    }
//}

// C# program to illustrate the
// use of goto in switch statement
//using System;
//public class EnigmaCamp
//{
//    // Main Method
//    public static void Main(String[] args)
//    {
//        int greeting = 2;

//        switch (greeting)
//        {
//            case 1:
//                Console.WriteLine("Hello");
//                goto default;
//            case 2:
//                Console.WriteLine("Bonjour");
//                goto case 3;
//            case 3:
//                Console.WriteLine("Namaste");
//                goto default;
//            default:
//                Console.WriteLine("Entered value is: " + greeting);
//                break;
//        }
//    }
//}

//How to avoid if
var a = new int[] { 1, 2, 3, 4, 5 };

var foundInt = a.FirstOrDefault(w => w == 4);

Console.WriteLine($"{foundInt.ToString()}");
Console.ReadKey();

var foundIntSingle = a.Single(w => w == 4);

Console.WriteLine($"{foundIntSingle.ToString()}");
Console.ReadKey();


string monthName = "Juni";

var tableMonth = new string[] { "Bulan", "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
var listMonth = tableMonth.ToList();
int month = listMonth.IndexOf(monthName);
Console.WriteLine($"{month.ToString()}");
Console.ReadKey();


if (month == 1) Console.WriteLine($"{31}");
if (month == 2) Console.WriteLine($"{29}");
if (month == 3) Console.WriteLine($"{31}");
if (month == 4) Console.WriteLine($"{30}");
if (month == 5) Console.WriteLine($"{31}");
if (month == 6) Console.WriteLine($"{30}");
if (month == 7) Console.WriteLine($"{31}");
if (month == 8) Console.WriteLine($"{31}");
if (month == 9) Console.WriteLine($"{30}");
if (month == 10) Console.WriteLine($"{31}");
if (month == 11) Console.WriteLine($"{30}");
if (month == 12) Console.WriteLine($"{31}");

var monthDays= new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
Console.WriteLine($"{monthDays[month - 1]}");

Console.ReadKey();