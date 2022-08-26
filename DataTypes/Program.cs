//// C# program to demonstrate the working
//// of Unary Arithmetic Operators
//using System;
//namespace Arithmetic
//{

//    class EnigmaCamp
//    {
//        // Main Function
//        static void Main(string[] args)
//        {
//            int a = 10, res;

//            // post-increment example:
//            // res is assigned 10 only,
//            // a is not updated yet
//            res = a++;

//            //a becomes 11 now
//            Console.WriteLine("a is {0} and res is {1}", a, res);

//            // post-decrement example: // res is assigned 11 only, a is not updated yet
//            res = a--;

//            //a becomes 10 now
//            Console.WriteLine("a is {0} and res is {1}", a, res);

//            // pre-increment example: 
//            // res is assigned 11 now since a
//            // is updated here itself
//            res = ++a;

//            // a and res have same values = 11
//            Console.WriteLine("a is {0} and res is {1}", a, res);

//            // pre-decrement example:
//            // res is assigned 10 only since
//            // a is updated here itself
//            res = --a;

//            // a and res have same values = 10
//            Console.WriteLine("a is {0} and res is {1}", a, res);
//        }
//    }
//}

// C# program to demonstrate the working
// of Relational Operators
//using System;
//namespace Relational
//{

//    class EnigmaCamp
//    {

//        // Main Function
//        static void Main(string[] args)
//        {
//            bool result;
//            int x = 5, y = 10;

//            // Equal to Operator
//            result = (x == y);
//            Console.WriteLine("Equal to Operator: " + result);

//            // Greater than Operator
//            result = (x > y);
//            Console.WriteLine("Greater than Operator: " + result);

//            // Less than Operator
//            result = (x < y);
//            Console.WriteLine("Less than Operator: " + result);

//            // Greater than Equal to Operator
//            result = (x >= y);
//            Console.WriteLine("Greater than or Equal to: " + result);

//            // Less than Equal to Operator
//            result = (x <= y);
//            Console.WriteLine("Lesser than or Equal to: " + result);

//            // Not Equal To Operator
//            result = (x != y);
//            Console.WriteLine("Not Equal to Operator: " + result);
//        }
//    }
//}

// C# program to demonstrate the working
// of Logical Operators
//using System;
//namespace Logical
//{

//    class EnigmaCamp
//    {

//        // Main Function
//        static void Main(string[] args)
//        {
//            bool a = true, b = false, result;

//            // AND operator
//            result = a && b;
//            Console.WriteLine("AND Operator: " + result);

//            // OR operator
//            result = a || b;
//            Console.WriteLine("OR Operator: " + result);

//            // NOT operator
//            result = !a;
//            Console.WriteLine("NOT Operator: " + result);

//        }
//    }
//}

//// C# program to demonstrate the working
//// of Bitwise Operators
//using System;
//namespace Bitwise
//{
//    class EnigmaCamp
//    {

//        // Main Function
//        static void Main(string[] args)
//        {
//            int x = 5, y = 10, result;

//            // Bitwise AND Operator
//            result = x & y;
//            Console.WriteLine("Bitwise AND: " + result);

//            // Bitwise OR Operator
//            result = x | y;
//            Console.WriteLine("Bitwise OR: " + result);

//            // Bitwise XOR Operator
//            result = x ^ y;
//            Console.WriteLine("Bitwise XOR: " + result);

//            // Bitwise AND Operator
//            result = ~x;
//            Console.WriteLine("Bitwise Complement: " + result);

//            // Bitwise LEFT SHIFT Operator
//            result = x << 2;
//            Console.WriteLine("Bitwise Left Shift: " + result);

//            // Bitwise RIGHT SHIFT Operator
//            result = x >> 2;
//            Console.WriteLine("Bitwise Right Shift: " + result);
//        }
//    }
//}

//// C# program to demonstrate the working
//// of Assignment Operators
//using System;
//namespace Assignment
//{
//    class EnigmaCamp
//    {
//        // Main Function
//        static void Main(string[] args)
//        {
//            // initialize variable x
//            // using Simple Assignment
//            // Operator "="
//            int x = 15;

//            // it means x = x + 10
//            x += 10;
//            Console.WriteLine("Add Assignment Operator: " + x);

//            // initialize variable x again
//            x = 20;

//            // it means x = x - 5
//            x -= 5;
//            Console.WriteLine("Subtract Assignment Operator: " + x);

//            // initialize variable x again
//            x = 15;

//            // it means x = x * 5
//            x *= 5;
//            Console.WriteLine("Multiply Assignment Operator: " + x);

//            // initialize variable x again
//            x = 25;

//            // it means x = x / 5
//            x /= 5;
//            Console.WriteLine("Division Assignment Operator: " + x);

//            // initialize variable x again
//            x = 25;

//            // it means x = x % 5
//            x %= 5;
//            Console.WriteLine("Modulo Assignment Operator: " + x);

//            // initialize variable x again
//            x = 8;

//            // it means x = x << 2
//            x <<= 2;
//            Console.WriteLine("Left Shift Assignment Operator: " + x);

//            // initialize variable x again
//            x = 8;

//            // it means x = x >> 2
//            x >>= 2;
//            Console.WriteLine("Right Shift Assignment Operator: " + x);

//            // initialize variable x again
//            x = 12;

//            // it means x = x >> 4
//            x &= 4;
//            Console.WriteLine("Bitwise AND Assignment Operator: " + x);

//            // initialize variable x again
//            x = 12;

//            // it means x = x >> 4
//            x ^= 4;
//            Console.WriteLine("Bitwise Exclusive OR Assignment Operator: " + x);

//            // initialize variable x again
//            x = 12;

//            // it means x = x >> 4
//            x |= 4;
//            Console.WriteLine("Bitwise Inclusive OR Assignment Operator: " + x);
//        }
//    }
//}

// C# program to demonstrate the working
// of Conditional Operator
using System;
namespace Conditional
{
    class EnigmaCamp
    {
        // Main Function
        static void Main(string[] args)
        {
            int x = 5, y = 10, result;

            // To find which value is greater
            // Using Conditional Operator
            result = x > y ? x : y;

            // To display the result
            Console.WriteLine("Result: " + result);

            // To find which value is greater
            // Using Conditional Operator
            result = x < y ? x : y;

            // To display the result
            Console.WriteLine("Result: " + result);
        }
    }
}
