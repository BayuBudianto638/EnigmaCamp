//// Here 100 is a constant/literal.
//int x = 100;

//int y = 101;

//// The octal number should be prefix with 0.
//int z = 0146;

//// The hexa-decimal number should be prefix
//// with 0X or 0x.
//int hexa = 0X123Face;

//// The binary number should be prefix with 0b.
//int bin = 0b101;

//// C# program to illustrate the use of Integer Literals
//using System;

//class EnigmaCamp
//{

//    // Main method
//    public static void Main(String[] args)
//    {

//        // decimal-form literal
//        int a = 101;

//        // octal-form literal
//        int b = 0145;

//        // Hexa-decimal form literal
//        int c = 0xFace;

//        // binary-form literal
//        int x = 0b101;

//        Console.WriteLine(a);
//        Console.WriteLine(b);
//        Console.WriteLine(c);
//        Console.WriteLine(x);
//    }
//}

// C# program to illustrate the use of
// floating-point literals
//using System;

//class EnigmaCamp
//{

//    // Main Method
//    public static void Main(String[] args)
//    {
//        // decimal-form literal
//        double a = 101.230;

//        // It also acts as decimal literal
//        double b = 0123.222;

//        Console.WriteLine(a);
//        Console.WriteLine(b);
//    }
//}

//using System;

//class EnigmaCamp
//{

//    // Main Method
//    public static void Main(String[] args)
//    {

//        // character literal within single quote
//        char ch = 'a';

//        // Unicode representation
//        char c = '\u0061';

//        Console.WriteLine(ch);
//        Console.WriteLine(c);

//        // Escape character literal
//        Console.WriteLine("Hello\n\nEnigmaCamp\t!");
//    }
//}

//// C# program to illustrate the use of String literals
//using System;

//class EnigmaCamp
//{

//    // Main Method
//    public static void Main(String[] args)
//    {

//        String s = "Hello EnigmaCamp!";
//        String s2 = @"Hello EnigmaCamp!";
//        String s3 = $"Hello EnigmaCamp";

//        // If we assign without "" then it
//        // treats as a variable
//        // and causes compiler error
//        // String s1 = Geeks;

//        Console.WriteLine(s);
//        Console.WriteLine(s2);
//    }
}

// C# program to illustrate the use
// of boolean literals
using System;

class EnigmaCamp
{

    // Main Method
    public static void Main(String[] args)
    {
        bool b = true;
        bool c = false;

        // these will give compile time error
        // bool d = 0;
        // bool e = 1;
        // Console.WriteLine(d);
        // Console.WriteLine(e);

        Console.WriteLine(b);
        Console.WriteLine(c);
    }
}
