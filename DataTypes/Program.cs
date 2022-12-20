
//// C# program to illustrate while loop
//using System;
//class whileLoopDemo
//{
//    public static void Main()
//    {
//        int x = 1;

//        // Exit when x becomes greater than 4
//        while (x <= 4)
//        {
//            Console.WriteLine("EnigmaCamp");

//            // Increment the value of x for
//            // next iteration
//            x++;
//        }
//    }
//}


//// C# program to illustrate for loop.
//using System;

//class forLoopDemo
//{
//    public static void Main()
//    {
//        // for loop begins when x=1
//        // and runs till x <=4
//        for (int x = 1; x <= 4; x++)
//            Console.WriteLine("EnigmaCamp");
//    }
//}

//// C# program to illustrate do-while loop
//using System;
//class dowhileloopDemo
//{
//    public static void Main()
//    {
//        int x = 21;
//        do
//        {
//            // The line will be printed even
//            // if the condition is false
//            Console.WriteLine("EnigmaCamp");
//            x++;
//        }
//        while (x < 20);
//    }
//}

//// C# program to demonstrate infinite loop
//using System;

//class infiniteLoop
//{
//    public static void Main()
//    {
//        // The statement will be printed
//        // infinite times
//        for (; ; )
//            Console.WriteLine("This is printed infinite times");
//    }
//}

// C# program to demonstrate nested loops
//using System;
//class nestedLoops
//{
//    public static void Main()
//    {
//        // loop within loop printing EnigmaCamp
//        for (int i = 2; i < 3; i++)
//            for (int j = 1; j < i; j++)
//                Console.WriteLine("EnigmaCamp");
//    }
//}

//// C# program to demonstrate continue statement
//using System;
//class demoContinue
//{
//    public static void Main()
//    {
//        // EnigmaCamp is printed only 2 times
//        // because of continue statement
//        for (int i = 1; i < 3; i++)
//        {
//            if (i == 2)
//                continue;

//            Console.WriteLine("EnigmaCamp");
//        }
//    }
//}

//// C# program to illustrate the
//// use of break statement
//using System;
//class EnigmaCamp
//{
//    // Main Method
//    static public void Main()
//    {
//        // EnigmaCamp is printed only 2 times
//        // because of break statement
//        for (int i = 1; i < 4; i++)
//        {
//            if (i == 3)
//                break;

//            Console.WriteLine("EnigmaCamp");
//        }
//    }
//}

//// C# program to illustrate the
//// use of continue statement
//using System;

//class EnigmaCamp
//{
//	// Main Method
//	public static void Main()
//	{
//		// This will skip 4 to print
//		for (int i = 1; i <= 10; i++)
//		{
//			// if the value of i becomes 4 then
//			// it will skip 4 and send the
//			// transfer to the for loop and
//			// continue with 5
//			if (i == 4)
//				continue;

//			Console.WriteLine(i);
//		}
//	}
//}

// for with switch and if
//using System;
//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            switch (i)
//            {
//                case 1:
//                case 3:
//                case 5:
//                case 7:
//                case 9:
//                    Console.WriteLine(i + " is odd");
//                    break;
//                case 2:
//                case 4:
//                case 6:
//                case 8:
//                case 10:
//                    Console.WriteLine(i + " is even");
//                    break;
//            }

//            if (i % 3 == 0 || i % 5 == 0)
//            {
//                Console.WriteLine(i + " is divisible by 3 or 5");
//            }
//        }

//        Console.WriteLine("Done!");
//    }
//}

// for while with if logical operator
//using System;

//class Program
//{
//    static void Main()
//    {
//        for (int i = 1; i <= 10; i++)
//        {
//            int j = 1;
//            while (j <= i)
//            {
//                if (i % j == 0 && j != 1 && j != i)
//                {
//                    Console.WriteLine(i + " is not a prime number");
//                    break;
//                }

//                if (j == i)
//                {
//                    Console.WriteLine(i + " is a prime number");
//                }

//                j++;
//            }

//        }

//        Console.WriteLine("Done!");
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        int x = 10;

//        while (x > 0 && x < 20)
//        {
//            if (x % 2 == 0)
//            {
//                Console.WriteLine(x + " is even");
//            }
//            else
//            {
//                Console.WriteLine(x + " is odd");
//            }
//            x++;
//        }

//        Console.WriteLine("Done!");
//    }
//}

//// do while switch and if
//using System;

//class Program
//{
//    static void Main()
//    {
//        int x = 10;

//        do
//        {
//            switch (x)
//            {
//                case 10:
//                    Console.WriteLine("x is 10");
//                    break;
//                case 9:
//                    Console.WriteLine("x is 9");
//                    break;
//                default:
//                    Console.WriteLine("x is not 10 or 9");
//                    break;
//            }

//            if (x % 2 == 0 && x % 3 == 0)
//            {
//                Console.WriteLine(x + " is divisible by both 2 and 3");
//            }
//            else if (x % 2 == 0)
//            {
//                Console.WriteLine(x + " is divisible by 2");
//            }
//            else if (x % 3 == 0)
//            {
//                Console.WriteLine(x + " is divisible by 3");
//            }
//            else
//            {
//                Console.WriteLine(x + " is not divisible by 2 or 3");
//            }

//            x--;
//        } while (x > 0);

//        Console.WriteLine("Done!");
//    }
//}

// for, while, do while, switch and if
class Program
{
    static void Main()
    {
        int x = 10;

        for (int i = 1; i <= 5; i++)
        {
            int j = 1;
            while (j <= i)
            {
                if (i % j == 0 && j != 1 && j != i)
                {
                    Console.WriteLine(i + " is not a prime number");
                    goto label;
                }

                if (j == i)
                {
                    Console.WriteLine(i + " is a prime number");
                }

                j++;
            }

        label:
            continue;
        }

        do
        {
            switch (x)
            {
                case 10:
                    Console.WriteLine("x is 10");
                    break;
                case 9:
                    Console.WriteLine("x is 9");
                    break;
                default:
                    Console.WriteLine("x is not 10 or 9");
                    break;
            }

            if (x % 2 == 0 && x % 3 == 0)
            {
                Console.WriteLine(x + " is divisible by both 2 and 3");
            }
            else if (x % 2 == 0 || x % 3 == 0)
            {
                Console.WriteLine(x + " is divisible by 2 or 3");
            }
            else
            {
                Console.WriteLine(x + " is not divisible by 2 or 3");
            }

            x--;
        } while (x > 0);

        Console.WriteLine("Done!");

    }
}

































//using System;
//class EnigmaCamp
//{
//    // Main Method
//    static public void Main()
//    {
//        // EnigmaCamp is printed only 2 times
//        // because of break statement
//        List<int> list = new List<int>();
//        int size = 10;

//        list = Enumerable.Range(1, size).Select(i => i).ToList();

//        // FOR
//        Console.WriteLine("FOR");
//        for (int i = 1; i <= list.Count; i++)
//        {
//            Console.WriteLine($"{i}");
//        }

//        Console.WriteLine("WHILE");
//        // WHILE
//        int item = 1;
//        while (item <= list.Count)
//        {
//            Console.WriteLine($"{item}");
//            item++;
//        }

//        Console.WriteLine("FOREACH");
//        // FOREACH
//        foreach (var i in list)
//        {
//            Console.WriteLine($"{i}");
//        }

//        // LINQ FOREACH
//        Console.WriteLine("LINQ_FOREACH");
//        list.Sort();
//        list.ForEach(i =>
//        {
//            Console.WriteLine($"{i}");
//        });

//        // PARALLEL FOREACH
//        Console.WriteLine("PARALLEL FOREACH");
//        list.Sort();
//        Parallel.ForEach(list, i =>
//        {
//            Console.WriteLine($"{i}");
//        });

//        // PARALLEL LINQ
//        Console.WriteLine("PARALLEL LINQ");
//        list.Sort();
//        list.AsParallel().ForAll(i =>
//        {
//            Console.WriteLine($"{i}");
//        });
//    }
//}

//// C# Program to illustrate the use
//// of throw keyword
//using System;
//class EnigmaCamp
//{
//	// taking null in the string
//	static string sub = null;
//	// method to display subject name
//	static void displaysubject(string sub1)
//	{
//		if (sub1 == null)
//			throw new NullReferenceException("Exception Message");
//	}

//	// Main Method
//	static void Main(string[] args)
//	{
//		// using try catch block to
//		// handle the Exception
//		try
//		{
//			// calling the static method
//			displaysubject(sub);
//		}

//		catch (Exception exp)
//		{
//			Console.WriteLine(exp.Message);
//		}
//	}
//}


//// C# program to illustrate the
//// use of goto statement
//using System;
//class EnigmaCamp
//{
//	// Main Method
//	static public void Main()
//	{
//		int number = 20;
//		switch (number)
//		{
//			case 5:
//				Console.WriteLine("case 5");
//				break;
//			case 10:
//				Console.WriteLine("case 10");
//				break;
//			case 20:
//				Console.WriteLine("case 20");

//				// goto statement transfer
//				// the control to case 5
//				goto case 5;

//			default:
//				Console.WriteLine("No match found");
//				break;
//		}
//	}
//}

//// C# program to illustrate the
//// use of return statement
//using System;
//class EnigmaCamp
//{
//	// creating simple addition function
//	static int Addition(int a)
//	{
//		// add two value and
//		// return the result of addition
//		int add = a + a;

//		// using return statement
//		return add;
//	}
//	// Main Method
//	static public void Main()
//	{
//		int number = 2;

//		// calling addition function
//		int result = Addition(number);
//		Console.WriteLine("The addition is {0}", result);
//	}
//}