/*
 * Methods are generally the block of codes or statements in a program that gives the user the ability to reuse the same code which ultimately saves the excessive use of memory, 
 * acts as a time saver and more importantly, it provides a better readability of code. So basically, a method is a collection of statements that perform some specific task and 
 * return the result to the caller. A method can also perform some specific task without returning anything.
 * */

//class Program
//{
//    // Method Name --> GetCircleArea()
//    // Return Type ---> double
//    static double GetCircleArea(double radius)
//    {
//        const float pi = 3.14F;
//        double area = pi * radius * radius;
//        return area;
//    }

//    static void Main()
//    {
//        var result = GetCircleArea(20);
//        Console.WriteLine($"Result : {result}");
//    }
//}


///*
// * In C# a method declaration consists of the following components as follows :

//Modifier : It defines access type of the method i.e. from where it can be accessed in your application. In C# there are Public, Protected, Private access modifiers. 

//Name of the Method : It describes the name of the user defined method by which the user calls it or refer it. Eg. GetName()
//Return type: It defines the data type returned by the method. It depends upon user as it may also return void value i.e return nothing
//Body of the Method : It refers to the line of code of tasks to be performed by the method during its execution. It is enclosed between braces.
//Parameter list : Comma separated list of the input parameters are defined, preceded with their data type, within the enclosed parenthesis. If there are no parameters, 
//then empty parentheses () have to use out. 

//Method Signature : Method Signature is defined by mainly two parameters(number of parameters, type of the parameters and order of the parameters), 
//One of them is Method Name and second one is its Parameter list.
//Method Naming : Name of a method or a function in any programming language whether in C++ or Java or C# holds great importance and is mainly used in order to call that method 
//for its execution. For example, findSum, computeMax, setX and getX etc. There are certain pre-defined rules for naming methods which a user should follow :

//The method name must be some kind of Noun or a verb.
//It’s naming should be done in such a way that it must describe the purpose of that method.
//The first letter of the method name can be either a small letter or a Capital letter, however, it is recommended to use the capital one.
//These rules are not mandatory, but recommendable. Generally, a method has a unique name within the class in which it is defined but sometime a method might have the same name
//as other method names within the same class as method overloading is allowed in C#.
//The Method Body : As discussed above the body of the method consists of statements of code which a user wants to perform. 
//After the method has been declared, it is dependent on the user whether to define its implementation or not. Not writing any implementation, makes the method not to perform any task. 
//However, when the user wants to perform certain tasks using method then it must write the statements for execution in the body of the method. 


//Method Invocation or Method Calling is done when the user wants to execute the method. The method needs to be called for using its functionality. 
//A method returns to the code that invoked it when:

//It completes all the statements in the method
//It reaches a return statement
//Throws an exception 
// */

////// C# program to illustrate
////// method calling
////using System;
////namespace ConsoleApplication1
////{

////    class EC
////    {

////        // Here Sum() method asks for two
////        // parameters from the user and
////        // calculates the sum of these
////        // and finally returns the result.
////        static int Sum(int x, int y)
////        {

////            // there are two local variables
////            // 'a' and 'b' where 'a' is assigned
////            // the value of parameter 'x' and
////            // 'b' is assigned the value of
////            // parameter 'y'
////            int a = x;
////            int b = y;

////            // The local variable calculates
////            // the sum of 'a' and 'b'
////            // and returns the result
////            // which is of 'int' type.
////            int result = a + b;

////            return result;
////        }

////        // Main Method
////        static void Main(string[] args)
////        {
////            int a = 12;
////            int b = 23;

////            // Method Sum() is invoked and
////            // the returned value is stored
////            // in the local variable say 'c'
////            int c = Sum(a, b);

////            // Display Result
////            Console.WriteLine("The Value of the sum is " + c);
////        }
////    }
////}

///*
// Method Parameters

//There might be certain situations the user want to execute a method but sometimes that method requires some value inputs in order to execute and complete its tasks. 
//These input values are known as Parameters in a computer language terms. Now, these parameters can be either int, long or float or double or char.
//However, it depends upon the user requirements. The methods in C# can be classified into different categories based on return type as well as input parameters. 
//// */

////// C# program to illustrate method Without
////// Parameters & Without Return Type
////using System;
////namespace ConsoleApplication2
////{
////    class EC
////    {
////        // Here the method 'PrintSentence()'
////        // neither takes any parameter nor
////        // returns any value. It simply performs
////        // the required operations and prints
////        // the result within it.
////        static void PrintSentence()
////        {
////            Console.WriteLine("No parameters and return type void");
////        }

////        // Main Method
////        static void Main(string[] args)
////        {
////            // Method Invoking or Method calling
////            PrintSentence();
////        }
////    }
////}



////// C# program to illustrate the method Without
////// Parameters & With Return Value Type
////using System;
////namespace ConsoleApplication3
////{
////    class EC
////    {

////        // This method takes no parameter,
////        // however returns the result obtained
////        static int sum()
////        {
////            int a = 78, b = 70, add;
////            add = a + b;
////            return add;
////        }

////        // Main Method
////        static void Main(string[] args)
////        {

////            // Here the calling variable
////            // is 'getresult'
////            int getresult = sum();

////            // Printing the value of
////            // 'getresult' variable
////            Console.WriteLine(getresult);
////        }
////    }
////}

//// C# program to illustrate Method With
//// Parameters & Without Return Value Type
//using System;
//namespace ConsoleApplication3
//{
//    class EC
//    {
//        // This method take the side of
//        // the square as a parameter and
//        // after obtaining the result,
//        // it simply print it without
//        // returning anything..
//        static void perimeter(int p)
//        {
//            // Displaying the perimeter
//            // of the square
//            Console.WriteLine("Perimeter of the Square is " + 4 * p);
//        }

//        // Main Method
//        static void Main(string[] args)
//        {
//            // side of square
//            int p = 5;

//            // Method invoking
//            perimeter(p);
//        }
//    }
//}

//using System;    
//namespace InterviewQuestionPart4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Please Enter a Number");

//            //read number from user    
//            int number = Convert.ToInt32(Console.ReadLine());

//            //invoke the static method    
//            double factorial = Factorial(number);

//            //print the factorial result    
//            Console.WriteLine("factorial of" + number + "=" + factorial.ToString());

//        }
//        public static double Factorial(int number)
//        {
//            if (number == 0)
//                return 1;

//            double factorial = 1;
//            for (int i = number; i >= 1; i--)
//            {
//                factorial = factorial * i;
//            }
//            return factorial;
//        }
//    }
//}

//using System;

//namespace InterviewQuestionPart4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Please Enter a Number");

//            //read number from user    
//            int number = Convert.ToInt32(Console.ReadLine());

//            //invoke the static method    
//            double factorial = Factorial(number);

//            //print the factorial result    
//            Console.WriteLine("factorial of" + number + "=" + factorial.ToString());

//        }
//        public static double Factorial(int number)
//        {
//            if (number == 0)
//                return 1;
//            return number * Factorial(number * 1);//Recursive call    

//        }
//    }
//}

//using System;

//namespace InterviewQuestionPart4
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Please Enter a Number");

//            //read number from user    
//            int number = Convert.ToInt32(Console.ReadLine());

//            //invoke the static method    
//            double factorial = Factorial(number);

//            //print the factorial result    
//            Console.WriteLine("factorial of" + number + "=" + factorial.ToString());

//        }
//        public static double Factorial(int number)
//        {
//            if (number == 0)
//                return 1;
//            return number * Factorial(number - 1);//Recursive call    

//        }
//    }
//}

//// Pass By Value
//class Program
//{
//    static void Main()
//    {
//        var a = 100;
//        var b = PassByValue(a);

//        Console.WriteLine($"Nilai a {a}");
//        Console.WriteLine($"Nilai b {b}");
//    }

//    public static int PassByValue(int a)
//    {
//        return a * 10;
//    }
//}

// Pass By Reference
class Program
{
    static void Main()
    {
        var a = 100;
        var b = PassByValue(ref a);

        Console.WriteLine($"Nilai a {a}");
        Console.WriteLine($"Nilai b {b}");
    }

    public static int PassByValue(ref int a)
    {
        return a = a - 10;
    }
}