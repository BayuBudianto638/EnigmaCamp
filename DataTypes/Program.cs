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

// C# program to illustrate the
// use of break statement
using System;
class EnigmaCamp
{
    // Main Method
    static public void Main()
    {
        // EnigmaCamp is printed only 2 times
        // because of break statement
        List<int> list = new List<int>();
        int size = 10;

        list = Enumerable.Range(1, size).Select(i => i).ToList();

        // FOR
        Console.WriteLine("FOR");
        for (int i = 1; i <= list.Count; i++)
        {
            Console.WriteLine($"{i}");
        }

        Console.WriteLine("WHILE");
        // WHILE
        int item = 1;
        while (item <= list.Count)
        {
            Console.WriteLine($"{item}");
            item++;
        }

        Console.WriteLine("FOREACH");
        // FOREACH
        foreach (var i in list)
        {
            Console.WriteLine($"{i}");
        }

        // LINQ FOREACH
        Console.WriteLine("LINQ_FOREACH");
        list.Sort();
        list.ForEach(i => {
            Console.WriteLine($"{ i }");
        });

        // PARALLEL FOREACH
        Console.WriteLine("PARALLEL FOREACH");
        list.Sort();
        Parallel.ForEach(list, i => {
            Console.WriteLine($"{i}");
        });

        // PARALLEL LINQ
        Console.WriteLine("PARALLEL LINQ");
        list.Sort();
        list.AsParallel().ForAll(i => {
            Console.WriteLine($"{i}");
        });       
    }
}
