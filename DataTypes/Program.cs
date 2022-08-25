//char var = 'h'; // Declaring and Initializing character variable
//int a, b, c; // Declaring variables a, b and c of int type

//int age;

//float _studentname;

//int if; // "if" is a keyword

//float 12studentname; // Cannot start with digit

//int enigma;
//float camp;

//int y = 7; // Declaring and initializing the variable at same time
//int x; // Declaring variable x
//x = 5; // initializing x with value 5

//using System;
//class EnigmaCamp
//{

//    // only declaration, compiler will 
//    // provide the default value 0 to it
//    int y;

//    // Main Method
//    public static void Main(String[] args)
//    {

//        // Compile Time Initialization of variable 'x'
//        // Assigning value 32 to x
//        int x = 32;

//        // printing the value
//        Console.WriteLine("Value of x is " + x);

//        // creating object to access
//        // the variable y
//        EnigmaCamp enigma = new EnigmaCamp();

//        // printing the value
//        Console.WriteLine("Value of y is " + enigma.y);
//    }
//}

// C# program to demonstrate the 
// Run Time Initialization
using System;
class EnigmaCamp
{

    // Main Method
    public static void Main(String[] args)
    {

        // Value will be taken from user 
        // input and assigned to variable
        // num
        int num = Convert.ToInt32(Console.ReadLine());

        // printing the result
        Console.WriteLine("Value of num is " + num);

    }
}