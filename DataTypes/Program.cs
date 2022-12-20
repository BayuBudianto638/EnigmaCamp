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

////C# program to illustrate
//// nested-if statement
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

//// complex nested if
//using System;
//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = -2;
//        int z = 3;

//        if (x > 0)
//        {
//            if (y > 0)
//            {
//                if (z > 0)
//                {
//                    Console.WriteLine("x, y, and z are all positive");
//                }
//                else
//                {
//                    Console.WriteLine("x and y are positive, but z is not");
//                }
//            }
//            else
//            {
//                if (z > 0)
//                {
//                    Console.WriteLine("x and z are positive, but y is not");
//                }
//                else
//                {
//                    Console.WriteLine("x is positive, but y and z are not");
//                }
//            }
//        }
//        else
//        {
//            if (y > 0)
//            {
//                if (z > 0)
//                {
//                    Console.WriteLine("y and z are positive, but x is not");
//                }
//                else
//                {
//                    Console.WriteLine("y is positive, but x and z are not");
//                }
//            }
//            else
//            {
//                if (z > 0)
//                {
//                    Console.WriteLine("z is positive, but x and y are not");
//                }
//                else
//                {
//                    Console.WriteLine("x, y, and z are all not positive");
//                }
//            }
//        }

//    }
//}

// if with logical operator
// AND
//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = 10;

//        if (x > 0 && y > 0)
//        {
//            Console.WriteLine("x and y are both positive");
//        }
//        else
//        {
//            Console.WriteLine("either x or y, or both, are not positive");
//        }
//    }
//}

//OR
//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = -10;

//        if (x > 0 || y > 0)
//        {
//            Console.WriteLine("either x or y, or both, are positive");
//        }
//        else
//        {
//            Console.WriteLine("x and y are both not positive");
//        }
//    }
//}

// nested if logical Operator
// AND
//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = 10;
//        int z = 15;

//        if (x > 0)
//        {
//            if (y > 0 && z > 0)
//            {
//                Console.WriteLine("x, y, and z are all positive");
//            }
//            else
//            {
//                Console.WriteLine("x is positive, but either y or z, or both, are not");
//            }
//        }
//        else
//        {
//            Console.WriteLine("x is not positive");
//        }
//    }
//}

// OR
//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = -10;
//        int z = 15;

//        if (x > 0)
//        {
//            if (y > 0 || z > 0)
//            {
//                Console.WriteLine("either x, y, or z, or any combination of them, are positive");
//            }
//            else
//            {
//                Console.WriteLine("x is positive, but y and z are not");
//            }
//        }
//        else
//        {
//            Console.WriteLine("x is not positive");
//        }
//    }
//}

//// NOT
//class Progam
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = -10;
//        int z = 15;

//        if (!(x > 0))
//        {
//            if (!(y > 0) && !(z > 0))
//            {
//                Console.WriteLine("x, y, and z are all not positive");
//            }
//            else
//            {
//                Console.WriteLine("either x or y or z, or any combination of them, are positive");
//            }
//        }
//        else
//        {
//            Console.WriteLine("x is positive");
//        }
//    }
//}

//// combination of AND, OR and NOT
//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = -10;
//        int z = 15;
//        int w = 20;

//        if (x > 0 || !(y > 0))
//        {
//            if (!(z > 0) && (w > 0 || x > 0))
//            {
//                Console.WriteLine("either x is positive, y is not positive, w is positive, or x is positive");
//            }
//            else
//            {
//                Console.WriteLine("either x is not positive, y is positive, w is not positive, or x is not positive");
//            }
//        }
//        else
//        {
//            Console.WriteLine("either x is not positive, or y is not positive");
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

//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = 2;

//        switch (x)
//        {
//            case 1:
//                switch (y)
//                {
//                    case 1:
//                        Console.WriteLine("x and y are both 1");
//                        break;
//                    case 2:
//                        Console.WriteLine("x is 1 and y is 2");
//                        break;
//                    default:
//                        Console.WriteLine("x is 1, but y is not 1 or 2");
//                        break;
//                }
//                break;
//            case 2:
//                Console.WriteLine("x is 2");
//                break;
//            case 3:
//                Console.WriteLine("x is 3");
//                break;
//            default:
//                Console.WriteLine("x is not 1, 2, or 3");
//                break;
//        }
//    }
//}

// Complex nested switch
//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = 2;
//        int z = -3;

//        switch (x)
//        {
//            case > 0:
//                if (y > 0)
//                {
//                    switch (z)
//                    {
//                        case > 0:
//                            Console.WriteLine("x, y, and z are all positive");
//                            break;
//                        default:
//                            Console.WriteLine("x and y are positive, but z is not");
//                            break;
//                    }
//                }
//                else
//                {
//                    switch (z)
//                    {
//                        case > 0:
//                            Console.WriteLine("x and z are positive, but y is not");
//                            break;
//                        default:
//                            Console.WriteLine("x is positive, but y and z are not");
//                            break;
//                    }
//                }
//                break;
//            default:
//                if (y > 0)
//                {
//                    switch (z)
//                    {
//                        case > 0:
//                            Console.WriteLine("y and z are positive but x is not");
//                            break;
//                        default:
//                            Console.WriteLine("y is positive, but x and z are not");
//                            break;
//                    }
//                }
//                else
//                {
//                    switch (z)
//                    {
//                        case > 0:
//                            Console.WriteLine("z is positive but x and y are not");
//                            break;
//                        default:
//                            Console.WriteLine("x, y and z are all positive");
//                            break;
//                    }
//                }
//                break;
//        }
//    }
//}

// switch with logical operator
//// AND
//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = 10;

//        switch (x > 0 && y > 0)
//        {
//            case true:
//                Console.WriteLine("x and y are both positive");
//                break;
//            case false:
//                Console.WriteLine("either x or y, or both, are not positive");
//                break;
//        }
//    }
//}

// OR
//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = -10;

//        switch (x > 0 || y > 0)
//        {
//            case true:
//                Console.WriteLine("either x or y, or both, are positive");
//                break;
//            case false:
//                Console.WriteLine("x and y are both not positive");
//                break;
//        }
//    }
//}

// NOT
//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = -10;

//        switch (!(x > 0))
//        {
//            case true:
//                Console.WriteLine("x is not positive");
//                break;
//            case false:
//                Console.WriteLine("x is positive");
//                break;
//        }
//    }
//}

////  nested switch with logical operator
//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = -10;
//        int z = 15;
//        int w = 20;

//        switch (x > 0 || !(y > 0))
//        {
//            case true:
//                switch (!(z > 0) && (w > 0 || x > 0))
//                {
//                    case true:
//                        Console.WriteLine("either x is positive, y is not positive, w is positive, or x is positive");
//                        break;
//                    case false:
//                        Console.WriteLine("either x is not positive, y is positive, w is not positive, or x is not positive");
//                        break;
//                }
//                break;
//            case false:
//                Console.WriteLine("either x is not positive, or y is not positive");
//                break;
//        }
//    }
//}

// switch logical operator with if
//class Program
//{
//    static void Main()
//    {
//        int x = 5;
//        int y = -10;
//        int z = 15;
//        int w = 20;

//        switch (x > 0 || !(y > 0))
//        {
//            case true:
//                if (!(z > 0) && (w > 0 || x > 0))
//                {
//                    Console.WriteLine("either x is positive, y is not positive, w is positive, or x is positive");
//                }
//                else
//                {
//                    Console.WriteLine("either x is not positive, y is positive, w is not positive, or x is not positive");
//                }
//                break;
//            case false:
//                Console.WriteLine("either x is not positive, or y is not positive");
//                break;
//        }
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

// goto
//class Program
//{
//    static void Main()
//    {
//        int x = 10;

//    // Labeled statement
//    label:

//        if (x > 0)
//        {
//            Console.WriteLine("x is greater than 0");
//            x--;
//            goto label; // Jump to the labeled statement
//        }

//        Console.WriteLine("x is not greater than 0");
//    }
//}

////How to avoid if
//var a = new int[] { 1, 2, 3, 4, 5 };

//var foundInt = a.FirstOrDefault(w => w == 4);

//Console.WriteLine($"{foundInt.ToString()}");
//Console.ReadKey();

//var foundIntSingle = a.Single(w => w == 4);

//Console.WriteLine($"{foundIntSingle.ToString()}");
//Console.ReadKey();


//string monthName = "Juni";

//var tableMonth = new string[] { "Bulan", "Januari", "Februari", "Maret", "April", "Mei", "Juni", "Juli", "Agustus", "September", "Oktober", "November", "Desember" };
//var listMonth = tableMonth.ToList();
//int month = listMonth.IndexOf(monthName);
//Console.WriteLine($"{month}");
//Console.ReadKey();


//if (month == 1) Console.WriteLine($"{31}");
//if (month == 2) Console.WriteLine($"{29}");
//if (month == 3) Console.WriteLine($"{31}");
//if (month == 4) Console.WriteLine($"{30}");
//if (month == 5) Console.WriteLine($"{31}");
//if (month == 6) Console.WriteLine($"{30}");
//if (month == 7) Console.WriteLine($"{31}");
//if (month == 8) Console.WriteLine($"{31}");
//if (month == 9) Console.WriteLine($"{30}");
//if (month == 10) Console.WriteLine($"{31}");
//if (month == 11) Console.WriteLine($"{30}");
//if (month == 12) Console.WriteLine($"{31}");

//var monthDays= new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
//Console.WriteLine($"{monthDays[month - 1]}");

//Console.ReadKey();