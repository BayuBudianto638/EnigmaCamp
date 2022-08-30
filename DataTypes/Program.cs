//// C# program to illustrate
//// method calling
//using System;
//namespace EnigmaCamp
//{
//	class EnigmaCamp
//	{
//		// Here Sum() method asks for two
//		// parameters from the user and
//		// calculates the sum of these
//		// and finally returns the result.
//		static int Sum(int x, int y)
//		{
//			// there are two local variables
//			// 'a' and 'b' where 'a' is assigned
//			// the value of parameter 'x' and
//			// 'b' is assigned the value of
//			// parameter 'y'
//			int a = x;
//			int b = y;

//			// The local variable calculates
//			// the sum of 'a' and 'b'
//			// and returns the result
//			// which is of 'int' type.
//			int result = a + b;

//			return result;
//		}

//		// Main Method
//		static void Main(string[] args)
//		{
//			int a = 12;
//			int b = 23;

//			// Method Sum() is invoked and
//			// the returned value is stored
//			// in the local variable say 'c'
//			int c = Sum(a, b);

//			// Display Result
//			Console.WriteLine("The Value of the sum is " + c);
//		}
//	}
//}

//// C# program to illustrate method Without
//// Parameters & Without Return Type
//using System;
//namespace EnigmaCamp
//{
//	class EnigmaCamp
//	{

//		// Here the method 'PrintSentence()'
//		// neither takes any parameter nor
//		// returns any value. It simply performs
//		// the required operations and prints
//		// the result within it.
//		static void PrintSentence()
//		{

//			Console.WriteLine("No parameters and return type void");
//		}

//		// Main Method
//		static void Main(string[] args)
//		{

//			// Method Invoking or Method calling
//			PrintSentence();
//		}
//	}
//}

//// C# program to illustrate the method Without
//// Parameters & With Return Value Type
//using System;
//namespace EnigmaCamp
//{

//	class EnigmaCamp
//	{

//		// This method takes no parameter,
//		// however returns the result obtained
//		static int sum()
//		{
//			int a = 78, b = 70, add;
//			add = a + b;
//			return add;
//		}

//		// Main Method
//		static void Main(string[] args)
//		{

//			// Here the calling variable
//			// is 'getresult'
//			int getresult = sum();

//			// Printing the value of
//			// 'getresult' variable
//			Console.WriteLine(getresult);
//		}
//	}
//}

//// C# program to illustrate Method With
//// Parameters & Without Return Value Type
//using System;
//namespace EnigmaCamp
//{
//	class EnigmaCamp
//	{

//		// This method take the side of
//		// the square as a parameter and
//		// after obtaining the result,
//		// it simply print it without
//		// returning anything..
//		static void perimeter(int p)
//		{

//			// Displaying the perimeter
//			// of the square
//			Console.WriteLine("Perimeter of the Square is " + 4 * p);
//		}

//		// Main Method
//		static void Main(string[] args)
//		{

//			// side of square
//			int p = 5;

//			// Method invoking
//			perimeter(p);
//		}
//	}
//}

//// C# program to illustrate Method With
//// Parameters & With Return Value Type
//using System;
//namespace EnigmaCamp
//{
//	class EnigmaCamp
//	{

//		// This method asks a number from
//		// the user and using that it
//		// calculates the factorial
//		// of it and returns the result
//		static int factorial(int n)
//		{
//			int f = 1;

//			// Method to calculate the
//			// factorial of a number
//			for (int i = 1; i <= n; i++)
//			{
//				f = f * i;
//			}

//			return f;
//		}

//		// Main Method
//		static void Main(string[] args)
//		{
//			int p = 4;

//			// displaying result by calling the function
//			Console.WriteLine("Factorial is : " + factorial(p));
//		}
//	}
//}

// C# program to demonstrate the function
// overloading by changing the Number
// of parameters
using System;
class EnigmaCamp
{

	// adding two integer values.
	public int Add(int a, int b)
	{
		int sum = a + b;
		return sum;
	}

	// adding three integer values.
	public int Add(int a, int b, int c)
	{
		int sum = a + b + c;
		return sum;
	}

	// Main Method
	public static void Main(String[] args)
	{

		// Creating Object
		EnigmaCamp ob = new EnigmaCamp();

		int sum1 = ob.Add(1, 2);
		Console.WriteLine("sum of the two "
						+ "integer value : " + sum1);

		int sum2 = ob.Add(1, 2, 3);
		Console.WriteLine("sum of the three "
						+ "integer value : " + sum2);
	}
}

