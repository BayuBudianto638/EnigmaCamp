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
//    class EnigmaCamp
//    {
//        // Here the method 'PrintSentence()'
//        // neither takes any parameter nor
//        // returns any value. It simply performs
//        // the required operations and prints
//        // the result within it.
//        static void PrintSentence()
//        {
//            Console.WriteLine("No parameters and return type void");
//        }

//        // Main Method
//        static void Main(string[] args)
//        {
//            // Method Invoking or Method calling
//            PrintSentence();
//        }
//    }
//}

//// C# program to illustrate the method Without
//// Parameters & With Return Value Type
//using System;
//namespace EnigmaCamp
//{
//    class EnigmaCamp
//    {
//        // This method takes no parameter,
//        // however returns the result obtained
//        static int sum()
//        {
//            int a = 78, b = 70, add;
//            add = a + b;
//            return add;
//        }

//        // Main Method
//        static void Main(string[] args)
//        {
//            // Here the calling variable
//            // is 'getresult'
//            int getresult = sum();

//            // Printing the value of
//            // 'getresult' variable
//            Console.WriteLine(getresult);
//        }
//    }
//}

//// C# program to illustrate Method With
//// Parameters & Without Return Value Type
//using System;
//namespace EnigmaCamp
//{
//    class EnigmaCamp
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

//// C# program to illustrate Method With
//// Parameters & With Return Value Type
//using System;
//namespace EnigmaCamp
//{
//    class EnigmaCamp
//    {
//        // This method asks a number from
//        // the user and using that it
//        // calculates the factorial
//        // of it and returns the result
//        static int factorial(int n)
//        {
//            int f = 1;

//            // Method to calculate the
//            // factorial of a number
//            for (int i = 1; i <= n; i++)
//            {
//                f = f * i;
//            }

//            return f;
//        }

//        // Main Method
//        static void Main(string[] args)
//        {
//            int p = 4;

//            // displaying result by calling the function
//            Console.WriteLine("Factorial is : " + factorial(p));
//        }
//    }
//}


// METHOD OVERLOADING
//// C# program to demonstrate the function
//// overloading by changing the Number
//// of parameters
//using System;
//class EnigmaCamp
//{
//    // adding two integer values.
//    public int Add(int a, int b)
//    {
//        int sum = a + b;
//        return sum;
//    }

//    // adding three integer values.
//    public int Add(int a, int b, int c)
//    {
//        int sum = a + b + c;
//        return sum;
//    }

//    // Main Method
//    public static void Main(String[] args)
//    {
//        // Creating Object
//        EnigmaCamp ob = new EnigmaCamp();

//        int sum1 = ob.Add(1, 2);
//        Console.WriteLine("sum of the two "
//                        + "integer value : " + sum1);

//        int sum2 = ob.Add(1, 2, 3);
//        Console.WriteLine("sum of the three "
//                        + "integer value : " + sum2);
//    }
//}

//// C# program to demonstrate the function
//// overloading by changing the Data types
//// of the parameters
//using System;
//class EnigmaCamp
//{

//	// adding three integer values.
//	public int Add(int a, int b, int c)
//	{
//		int sum = a + b + c;
//		return sum;
//	}

//	// adding three double values.
//	public double Add(double a, double b, double c)
//	{
//		double sum = a + b + c;
//		return sum;
//	}

//	// Main Method
//	public static void Main(String[] args)
//	{
//		// Creating Object
//		EnigmaCamp ob = new EnigmaCamp();

//		int sum2 = ob.Add(1, 2, 3);
//		Console.WriteLine("sum of the three "
//						+ "integer value : " + sum2);
//		double sum3 = ob.Add(1.0, 2.0, 3.0);
//		Console.WriteLine("sum of the three "
//						+ "double value : " + sum3);
//	}
//}

//// C# program to demonstrate the function
//// overloading by changing the
//// Order of the parameters
//using System;
//class EnigmaCamp
//{
//	// Method
//	public void Identity(String name, int id)
//	{
//		Console.WriteLine("Name1 : " + name + ", "
//						+ "Id1 : " + id);
//	}

//	// Method
//	public void Identity(int id, String name)
//	{
//		Console.WriteLine("Name2 : " + name + ", "
//						+ "Id2 : " + id);
//	}

//	// Main Method
//	public static void Main(String[] args)
//	{
//		// Creating Object
//		EnigmaCamp obj = new EnigmaCamp();

//		obj.Identity("Akku", 1);
//		obj.Identity(2, "Abby");
//	}
//}

//// C# program to show error when method signature
//// is the same and the return type is different.
//using System;
//class EnigmaCamp
//{
//	// adding two integer value.
//	public int Add(int a, int b)
//	{
//		int sum = a + b;
//		return sum;
//	}

//	// adding three integer value.
//	public double Add(int a, int b)
//	{
//		double sum = a + b + 0.0;
//		return sum;
//	}

//	// Main Method
//	public static void Main(String[] args)
//	{
//		// Creating Object
//		EnigmaCamp ob = new EnigmaCamp();

//		int sum1 = ob.Add(1, 2);
//		Console.WriteLine("sum of the two "
//						+ "integer value :" + sum1);

//		int sum2 = ob.Add(1, 2);
//		Console.WriteLine("sum of the three "
//						+ "integer value :" + sum2);
//	}
//}


// METHOD PARAMETERS
//// C# program to illustrate the
//// concept of the named parameters
//using System;
//public class EnigmaCamp
//{

//	// addstr contain three parameters
//	public static void addstr(string s1, string s2, string s3)
//	{
//		string result = s1 + s2 + s3;
//		Console.WriteLine("Final string is: " + result);
//	}

//	// Main Method
//	static public void Main()
//	{
//		// calling the static method with named
//		// parameters without any order
//		addstr(s1: "Enigma", s2: " ", s3: "Camp");

//	}
//}

//// C# program to illustrate the
//// concept of ref parameter
//using System;
//class EnigmaCamp
//{
//	// Main Method
//	public static void Main()
//	{
//		// Assigning value
//		string val = "Dog";

//		// Pass as a reference parameter
//		CompareValue(ref val);

//		// Display the given value
//		Console.WriteLine(val);
//	}

//	static void CompareValue(ref string val1)
//	{
//		// Compare the value
//		if (val1 == "Dog")
//		{
//			Console.WriteLine("Matched!");
//		}

//		// Assigning new value
//		val1 = "Cat";
//	}
//}

//// C# program to illustrate the
//// concept of out parameter
//using System;
//class EnigmaCamp
//{
//    // Main method
//    static public void Main()
//    {
//        // Creating variable
//        // without assigning value
//        int num;

//        // Pass variable num to the method
//        // using out keyword
//        AddNum(out num);

//        // Display the value of num
//        Console.WriteLine("The sum of"
//        + " the value is: {0}", num);
//    }

//    // Method in which out parameter is passed
//    // and this method returns the value of
//    // the passed parameter
//    public static void AddNum(out int num)
//    {
//        num = 40;
//        num += num;
//    }
//}

//// C# program to illustrate the
//// concept of optional parameters
//using System;
//class EnigmaCamp
//{

//	// This method contains two regular
//	// parameters, i.e. ename and eid
//	// And two optional parameters, i.e.
//	// bgrp and dept
//	static public void detail(string ename,
//							int eid,
//							string bgrp = "A+",
//					string dept = "Review-Team")

//	{
//		Console.WriteLine("Employee name: {0}", ename);
//		Console.WriteLine("Employee ID: {0}", eid);
//		Console.WriteLine("Blood Group: {0}", bgrp);
//		Console.WriteLine("Department: {0}", dept);
//	}

//	// Main Method
//	static public void Main()
//	{
//		// Calling the detail method
//		detail("XYZ", 123);
//		detail("ABC", 456, "B-");
//		detail("DEF", 789, "B+",
//		"Software Developer");
//	}
//}

//// C# program to illustrate the concept
//// of the dynamic parameters
//using System;
//class EnigmaCamp
//{
//	// Method which contains dynamic parameter
//	public static void mulval(dynamic val)
//	{
//		val *= val;
//		Console.WriteLine(val);
//	}

//	// Main method
//	static public void Main()
//	{
//		// Calling mulval method
//		mulval(30);
//	}
//}

//// C# program to illustrate value parameters
//using System;
//public class EnigmaCamp
//{
//	// Main Method
//	static public void Main()
//	{
//		// The value of the parameter
//		// is already assigned
//		string str1 = "Enigma";
//		string str2 = "Camp";
//		string res = addstr(str1, str2);
//		Console.WriteLine(res);
//	}

//	public static string addstr(string s1, string s2)
//	{
//		return s1 + s2;
//	}
//}

//// C# program to illustrate params
//using System;
//namespace EnigmaCamp
//{
//	class EnigmaCamp
//	{
//		// function containing params parameters
//		public static int mulval(params int[] num)
//		{
//			int res = 1;

//			// foreach loop
//			foreach (int j in num)
//			{
//				res *= j;
//			}
//			return res;
//		}

//		static void Main(string[] args)
//		{
//			// Calling mulval method
//			int x = mulval(20, 49, 56, 69, 78);

//			// show result
//			Console.WriteLine(x);
//		}
//	}
//}

////METHOD OVERRIDING
//// C# program to demonstrate the method overriding
//// without using 'virtual' and 'override' modifiers
//using System;
//// base class name 'baseClass'
//class baseClass
//{
//	public void show()
//	{
//		Console.WriteLine("Base class");
//	}
//}

//// derived class name 'derived'
//// 'baseClass' inherit here
//class derived : baseClass
//{
//	// overriding
//	new public void show()
//	{
//		Console.WriteLine("Derived class");
//	}
//}

//class EnigmaCamp
//{
//	// Main Method
//	public static void Main()
//	{
//		// 'obj' is the object of
//		// class 'baseClass'
//		baseClass obj = new baseClass();

//		// invokes the method 'show()'
//		// of class 'baseClass'
//		obj.show();
//		obj = new derived();

//		// it also invokes the method
//		// 'show()' of class 'baseClass'
//		obj.show();
//	}
//}

//// C# program to illustrate the use of
////'virtual' and 'override' modifiers
//using System;
//class baseClass
//{
//		// show() is 'virtual' here
//	public virtual void show()
//	{
//		Console.WriteLine("Base class");
//	}
//}

//// class 'baseClass' inherit
//// class 'derived'
//class derived : baseClass
//{
//	//'show()' is 'override' here
//	public override void show()
//	{
//		Console.WriteLine("Derived class");
//	}
//}

//class EnigmaCamp
//{
//	// Main Method
//	public static void Main()
//	{
//		baseClass obj;
//		// 'obj' is the object
//		// of class 'baseClass'
//		obj = new baseClass();

//		// it invokes 'show()'
//		// of class 'baseClass'
//		obj.show();
//		// the same object 'obj' is now
//		// the object of class 'derived'
//		obj = new derived();
//		// it invokes 'show()' of class 'derived'
//		// 'show()' of class 'derived' is overridden
//		// for 'override' modifier
//		obj.show();
//	}
//}


////CONTOH 3
//// C# program to show the use of 'base'
//// keyword in method overriding
//using System;
//// base class
//public class web
//{
//	string name = "EnigmaCamp";
//	// 'showdata()' is member method,
//	// declare as virtual
//	public virtual void showdata()
//	{
//		Console.WriteLine("Website Name: " + name);
//	}
//}

//// derived class
//// class 'web' is inherits
//// class 'stream'
//class stream : web
//{
//	string s = "Computer Science";
//	//'showdata()' is overridden
//	// in derived class
//	public override void showdata()
//	{
//		// Calling 'showdata()' of base
//		// class using 'base' keyword
//		base.showdata();
//		Console.WriteLine("About: " + s);
//	}
//}

//class EC
//{
//	// Main Method
//	static void Main()
//	{
//		// 'E' is object of class stream
//		// also works as object of
//		// class 'web'
//		stream E = new stream();
//		// it first invokes 'showdata()'
//		// of class 'web' then it invokes
//		// 'showdata()' of class 'stream'
//		E.showdata();
//	}
//}

//// CONTOH4
//// C# program to show how base keyword
//// specifies the calling of base-class
//// constructor from the derived class
//// when derived class instances are created
//using System;
//// base class
//public class clssA
//{
//	int n1, n2;
//	// default constructor
//	public clssA()
//	{
//		Console.WriteLine("Default Constructor Invoked");
//	}

//	// parameterized constructor
//	public clssA(int i, int j)
//	{
//		// construct values
//		n1 = i;
//		n2 = j;
//		Console.WriteLine("Parameterized Constructor Invoked");
//		Console.WriteLine("Invoked Values are: " + n1 + " and " + n2);
//	}
//}

//// derived class
//public class DerivedClass : clssA
//{
//	// This constructor will instantiate
//	// 'clssA()' [no argument constructor]
//	// using 'base' keyword
//	public DerivedClass() : base() { }

//	// This constructor will instantiate
//	// 'clssA(int i, int j)' [parameterized
//	// constructor] using 'base' keyword
//	public DerivedClass(int i, int j) : base(i, j) { }

//	// Main Method
//	static void Main()
//	{
//		// invoke no argument constructor
//		DerivedClass d1 = new DerivedClass();
//		Console.WriteLine();
//		// invoke parameterized constructor
//		DerivedClass d2 = new DerivedClass(10, 20);

//	}
//}

// CONTOH 5
// C# program to show how 'base' keyword specifies
// the base-class constructor that called from
// derived class and also calling a method 'swap'
// from derived class using base keyword
using System;
// base class
public class clssA
{
	public int n1, n2;
	// default constructor
	public clssA()
	{
		Console.WriteLine("In clssA 'no argument constructor' invoked");
	}

	// parameterized constructor
	public clssA(int i, int j)
	{
		// construct values
		n1 = i;
		n2 = j;
		Console.WriteLine("in clssA 'parameterized constructor' invoked");
		Console.WriteLine("the invoked values are " + n1 + " and " + n2);
		Console.WriteLine();
	}

	public virtual void swap()
	{
		Console.WriteLine("swap function of base class(clssA) invoked");
		Console.WriteLine("Before swap num1 = {0} and num2 = {1}", n1, n2);

		// swapping
		int t = n1;
		n1 = n2;
		n2 = t;
		Console.WriteLine("After swap num1 = {0} and num2 = {1}", n1, n2);
	}
}

// derived class
public class DerivedClass : clssA
{
	// This constructor will instantiate
	// 'clssA' [no argument constructor]
	// using 'base' keyword
	public DerivedClass() : base() { }
	// This constructor will instantiate
	// 'clssA' [parameterized constructor]
	// using 'base' keyword
	public DerivedClass(int i, int j) : base(i, j) { }
	public override void swap()
	{
		// it access the swap function of
		// 'clssA' using 'base' keyword
		base.swap();
		Console.WriteLine();
		Console.WriteLine("Swap function of derived class invoked");
		Console.WriteLine("Before swap num1 = {0} and num2 = {1}", n1, n2);

		// swapping
		int t = n1;
		n1 = n2;
		n2 = t;
		Console.WriteLine("After swap num1 = {0} and num2 = {1}", n1, n2);
	}

	// Main Method
	static void Main()
	{
		// invoke no argument constructor
		DerivedClass d1 = new DerivedClass();
		Console.WriteLine();
		// invoke parameterized constructor
		DerivedClass d2 = new DerivedClass(10, 20);

		// calling swap function
		d2.swap();
	}
}
