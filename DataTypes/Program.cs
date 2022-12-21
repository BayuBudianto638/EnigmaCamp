//using System;

//namespace PointerExample
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            // Declare and initialize an array of integers
//            int[] numbers = { 1, 2, 3, 4, 5 };

//            // Get the address of the first element of the array
//            int* p = (int*)&numbers[0];

//            // Print the elements of the array using the pointer
//            Console.WriteLine("Elements of the array:");
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                Console.WriteLine(*p);
//                p++;
//            }

//            // Change the value of the second element using the pointer
//            p = (int*)&numbers[1];
//            *p = 10;

//            // Print the elements of the array using the pointer again
//            Console.WriteLine("\nElements of the array after changing the value of the second element:");
//            p = (int*)&numbers[0];
//            for (int i = 0; i < numbers.Length; i++)
//            {
//                Console.WriteLine(*p);
//                p++;
//            }
//        }
//    }
//}


////// C# program to illustrate creating an array
////// of integers, puts some values in the array,
////// and prints each value to standard output.
////using System;
////namespace EnigmaCamp
////{
////	class GFG
////	{
////		// Main Method
////		public static void Main()
////		{
////			// declares an Array of integers.
////			int[] intArray;

////			// allocating memory for 5 integers.
////			intArray = new int[5];

////			// initialize the first elements
////			// of the array
////			intArray[0] = 10;

////			// initialize the second elements
////			// of the array
////			intArray[1] = 20;

////			// so on...
////			intArray[2] = 30;
////			intArray[3] = 40;
////			intArray[4] = 50;

////			// accessing the elements
////			// using for loop
////			Console.Write("For loop :");
////			for (int i = 0; i < intArray.Length; i++)
////				Console.Write(" " + intArray[i]);

////			Console.WriteLine("");
////			Console.Write("For-each loop :");

////			// using for-each loop
////			foreach (int i in intArray)
////				Console.Write(" " + i);

////			Console.WriteLine("");
////			Console.Write("while loop :");

////			// using while loop
////			int j = 0;
////			while (j < intArray.Length)
////			{
////				Console.Write(" " + intArray[j]);
////				j++;
////			}

////			Console.WriteLine("");
////			Console.Write("Do-while loop :");

////			// using do-while loop
////			int k = 0;
////			do
////			{
////				Console.Write(" " + intArray[k]);
////				k++;
////			} while (k < intArray.Length);
////		}
////	}
////}


//// C# program to creating an array
//// of the string as week days, store
//// day values in the weekdays,
//// and prints each value.
//using System;
//namespace EnigmaCamp
//{

//	class Enigma
//	{

//		// Main Method
//		public static void Main()
//		{

//			// declares a 1D Array of string.
//			string[] weekDays;

//			// allocating memory for days.
//			weekDays = new string[] {"Sun", "Mon", "Tue", "Wed",
//									"Thu", "Fri", "Sat"};

//			// Displaying Elements of array
//			foreach (string day in weekDays)
//				Console.Write(day + " ");
//		}
//	}
//}

//////// C# program to illustrate creating
//////// an multi- dimensional array
//////// puts some values in the array,
//////// and print them
//////using System;
//////namespace EnigmaCamp
//////{
//////	class Enigma
//////	{
//////		// Main Method
//////		public static void Main()
//////		{
//////			// Two-dimensional array
//////			int[,] intarray = new int[,] { { 1, 2 },
//////										{ 3, 4 },
//////										{ 5, 6 },
//////										{ 7, 8 } };

//////			// The same array with dimensions
//////			// specified 4 row and 2 column.
//////			int[,] intarray_d = new int[4, 2] { { 1, 2 }, { 3, 4 },
//////											{ 5, 6 }, { 7, 8 } };

//////			// A similar array with string elements.
//////			string[,] str = new string[4, 2] { { "one", "two" },
//////											{ "three", "four" },
//////											{ "five", "six" },
//////											{ "seven", "eight" } };

//////			// Three-dimensional array.
//////			int[,,] intarray3D = new int[,,] { { { 1, 2, 3 },
//////											{ 4, 5, 6 } },
//////											{ { 7, 8, 9 },
//////										{ 10, 11, 12 } } };


//////			// The same array with dimensions
//////			// specified 2, 2 and 3.
//////			int[,,] intarray3Dd = new int[2, 2, 3] { { { 1, 2, 3 },
//////												{ 4, 5, 6 } },
//////												{ { 7, 8, 9 },
//////												{ 10, 11, 12 } } };

//////			// Accessing array elements.
//////			Console.WriteLine("2DArray[0][0] : " + intarray[0, 0]);
//////			Console.WriteLine("2DArray[0][1] : " + intarray[0, 1]);
//////			Console.WriteLine("2DArray[1][1] : " + intarray[1, 1]);
//////			Console.WriteLine("2DArray[2][0] " + intarray[2, 0]);

//////			Console.WriteLine("2DArray[1][1] (other) : "
//////									+ intarray_d[1, 1]);

//////			Console.WriteLine("2DArray[1][0] (other)"
//////								+ intarray_d[1, 0]);

//////			Console.WriteLine("3DArray[1][0][1] : "
//////							+ intarray3D[1, 0, 1]);

//////			Console.WriteLine("3DArray[1][1][2] : "
//////							+ intarray3D[1, 1, 2]);

//////			Console.WriteLine("3DArray[0][1][1] (other): "
//////								+ intarray3Dd[0, 1, 1]);

//////			Console.WriteLine("3DArray[1][0][2] (other): "
//////								+ intarray3Dd[1, 0, 2]);

//////			// using nested loop show string elements
//////			Console.WriteLine("To String element");
//////			for (int i = 0; i < 4; i++)
//////				for (int j = 0; j < 2; j++)
//////					Console.Write(str[i, j] + " ");
//////		}
//////	}
//////}

//////// C# program to single-dimensional jagged array
//////// that contains two single-dimensional array
//////// elements of different sizes.
//////using System;
//////namespace EnigmaCamp
//////{

//////	class Enigma
//////	{
//////		// Main Method
//////		public static void Main()
//////		{
//////			/*----------2D Array---------------*/
//////			// Declare the array of two elements:
//////			int[][] arr = new int[2][];

//////			// Initialize the elements:
//////			arr[0] = new int[5] { 1, 3, 5, 7, 9 };
//////			arr[1] = new int[4] { 2, 4, 6, 8 };

//////			// Another way of Declare and
//////			// Initialize of elements
//////			int[][] arr1 = { new int[] { 1, 3, 5, 7, 9 },
//////						new int[] { 2, 4, 6, 8 } };

//////			// Display the array elements:
//////			for (int i = 0; i < arr.Length; i++)
//////			{
//////				System.Console.Write("Element [" + i + "] Array: ");
//////				for (int j = 0; j < arr[i].Length; j++)
//////					Console.Write(arr[i][j] + " ");
//////				Console.WriteLine();
//////			}

//////			Console.WriteLine("Another Array");

//////			// Display the another array elements:
//////			for (int i = 0; i < arr1.Length; i++)
//////			{
//////				System.Console.Write("Element [" + i + "] Array: ");
//////				for (int j = 0; j < arr1[i].Length; j++)
//////					Console.Write(arr1[i][j] + " ");
//////				Console.WriteLine();
//////			}
//////		}
//////	}
//////}

//////// C# program to single-dimensional jagged array
//////// that contains three two-dimensional array
//////// elements of different sizes.
//////using System;
//////namespace EnigmaCamp
//////{
//////	class Enigma
//////	{
//////		// Main Method
//////		public static void Main()
//////		{
//////			int[][,] arr = new int[3][,] {new int[, ] {{1, 3}, {5, 7}},
//////									new int[, ] {{0, 2}, {4, 6}, {8, 10}},
//////									new int[, ] {{11, 22}, {99, 88}, {0, 9}}};

//////			// Display the array elements:
//////			for (int i = 0; i < arr.Length; i++)
//////			{
//////				int x = 0;
//////				for (int j = 0; j < arr[i].GetLength(x); j++)
//////				{
//////					for (int k = 0; k < arr[j].Rank; k++)
//////						Console.Write(" arr[" + i + "][" + j + ", " + k + "]:"
//////													+ arr[i][j, k] + " ");
//////					Console.WriteLine();
//////				}
//////				x++;
//////				Console.WriteLine();
//////			}
//////		}
//////	}
//////}

//////// C# program to illustrate the declaration
//////// and Initialization of Jagged Arrays
//////using System;
//////class EnigmaCamp
//////{
//////	// Main Method
//////	public static void Main()
//////	{
//////		// Declare the Jagged Array of four elements:
//////		int[][] jagged_arr = new int[4][];

//////		// Initialize the elements
//////		jagged_arr[0] = new int[] { 1, 2, 3, 4 };
//////		jagged_arr[1] = new int[] { 11, 34, 67 };
//////		jagged_arr[2] = new int[] { 89, 23 };
//////		jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

//////		// Display the array elements:
//////		for (int n = 0; n < jagged_arr.Length; n++)
//////		{

//////			// Print the row number
//////			System.Console.Write("Row({0}): ", n);

//////			for (int k = 0; k < jagged_arr[n].Length; k++)
//////			{

//////				// Print the elements in the row
//////				System.Console.Write("{0} ", jagged_arr[n][k]);
//////			}
//////			System.Console.WriteLine();
//////		}
//////	}
//////}

//////// C# program to illustrate the Mixing of 1-D
//////// Jagged Array with the four 2-D array
//////using System;
//////namespace EnigmaCamp
//////{
//////	class Enigma
//////	{
//////		// Main Method
//////		public static void Main()
//////		{
//////			// Declaration and Initialization of
//////			// Jagged array with 4 2-D arrays
//////			int[][,] jagged_arr1 = new int[4][,] {new int[, ] {{1, 3}, {5, 7}},
//////									new int[, ] {{0, 2}, {4, 6}, {8, 10}},
//////									new int[, ] {{7, 8}, {3, 1}, {0, 6}},
//////									new int[, ] {{11, 22}, {99, 88}, {0, 9}}};

//////			// Display the array elements:
//////			// Length method returns the number of
//////			// arrays contained in the jagged array
//////			for (int i = 0; i < jagged_arr1.Length; i++)
//////			{
//////				int x = 0;

//////				// GetLength method takes integer x which
//////				// specifies the dimension of the array
//////				for (int j = 0; j < jagged_arr1[i].GetLength(x); j++)
//////				{

//////					// Rank is used to determine the total
//////					// dimensions of an array
//////					for (int k = 0; k < jagged_arr1[j].Rank; k++)
//////						Console.Write("Jagged_Array[" + i + "][" + j + ", " + k + "]: "
//////													+ jagged_arr1[i][j, k] + " ");
//////					Console.WriteLine();
//////				}
//////				x++;
//////				Console.WriteLine();
//////			}
//////		}
//////	}
//////}

////// ARRAY CLASS

//////// C# program to creating an array
//////// of the string as coffee name, store
//////// coffee name in the store,
//////// and prints each value.
//////using System;
//////namespace EnigmaCamp
//////{
//////    class Enigma
//////    {
//////        // Main Method
//////        public static void Main()
//////        {
//////            // declares an 1D Array of string
//////            string[] store;

//////            // allocating memory for coffee names.
//////            store = new string[] {"Americano, ", "Cafe au lait, ",
//////                            "Espresso, ", "Cappuccino, ",
//////                            "Long Black, ", "Macchiato" };

//////            // Displaying Elements of the array
//////            Console.WriteLine("Different types of coffee: ");
//////            Console.WriteLine();
//////            foreach (string coffeename in store)
//////                Console.WriteLine(coffeename + " ");
//////        }
//////    }
//////}

//////// C# program to illustrate
//////// Length property of Array class
//////using System;
//////namespace EnigmaCamp
//////{
//////	class EC
//////	{
//////		// Main Method
//////		public static void Main()
//////		{
//////			// declares an 1D Array of string.
//////			string[] topic;

//////			// allocating memory for topic.
//////			topic = new string[] {"Array, ", "String, ",
//////							"Stack, ", "Queue, ",
//////							"Exception, ", "Operators"};

//////			// Displaying Elements of the array
//////			Console.WriteLine("Topic of C#:");
//////			Console.WriteLine();

//////			// Here we calculate and print
//////			// the length of the array, i.e. 6
//////			Console.WriteLine("Length of the array: {0}",
//////										topic.Length);
//////			foreach (string ele in topic)
//////				Console.WriteLine(ele + " ");
//////		}
//////	}
//////}

//////// C# program to illustrate the
//////// Rank property of Array class
//////using System;
//////namespace EnigmaCamp
//////{
//////	class EC
//////	{
//////		// Main Method
//////		public static void Main()
//////		{

//////			// declares an 1D Array of string.
//////			string[] topic;

//////			// allocating memory for topic.
//////			topic = new string[] {"Array, ", "String, ",
//////							"Stack, ", "Queue, ",
//////							"Exception, ", "Operators" };

//////			// Displaying Elements of array
//////			Console.WriteLine("Topic of C#:");
//////			Console.WriteLine();

//////			// Rank property provides the dimension rank
//////			// here we use 1-D array so it return 1
//////			// if we use 2-D array then it will return 2
//////			Console.WriteLine("Rank of the array: {0}",
//////											topic.Rank);
//////			foreach (string ele in topic)
//////				Console.WriteLine(ele + " ");
//////		}
//////	}
//////}

//////// C# program to illustrate the Reverse() Method
//////using System;
//////namespace EnigmaCamp
//////{
//////	class EC
//////	{
//////		// Main Method
//////		public static void Main()
//////		{
//////			// declares an 1D Array of string.
//////			string[] topic;

//////			// allocating memory for topic.
//////			topic = new string[] {"Array, ", "String, ",
//////							"Stack, ", "Queue, ",
//////							"Exception, ", "Operators" };

//////			// Displaying Elements of
//////			// the array before reverse
//////			Console.WriteLine("Topic of C# before reverse:");
//////			Console.WriteLine();
//////			foreach (string ele in topic)
//////			{
//////				Console.WriteLine(ele + " ");
//////			}
//////			Console.WriteLine();

//////			// using Reverse() method to
//////			// reverse the given array
//////			Array.Reverse(topic);

//////			// Displaying Elements of array after reverse
//////			Console.WriteLine("Topic of C# after reverse:");
//////			Console.WriteLine();
//////			foreach (string val in topic)
//////			{
//////				Console.WriteLine(val + " ");
//////			}
//////		}
//////	}
//////}


//////// C# program to illustrate the Sort() Method
//////using System;
//////namespace EnigmaCamp
//////{
//////	class EC
//////	{
//////		// Main Method
//////		public static void Main()
//////		{
//////			// declares an 1D Array of string.
//////			string[] topic;

//////			// allocating memory for topic.
//////			topic = new string[] {"Array, ", "String, ",
//////							"Stack, ", "Queue, ",
//////							"Exception, ", "Operators" };

//////			// Displaying Elements of the array before sort
//////			Console.WriteLine("Topic of C# before reverse:");
//////			Console.WriteLine();
//////			foreach (string ele in topic)
//////			{
//////				Console.WriteLine(ele + " ");
//////			}
//////			Console.WriteLine();

//////			// using Sort() method to
//////			// sort the given array
//////			Array.Sort(topic);

//////			// Displaying Elements of
//////			// array after sort
//////			Console.WriteLine("Topic of C# after reverse:");
//////			Console.WriteLine();
//////			foreach (string val in topic)
//////			{
//////				Console.WriteLine(val + " ");
//////			}
//////		}
//////	}
//////}

//////ARRAY SORT

//////// C# Program to illustrate the use
//////// of the Array.Sort<T>(T[]) Method
//////using System;
//////using System.Collections.Generic;
//////class EnigmaCamp
//////{

//////	// Main Method
//////	public static void Main()
//////	{
//////		// array elements
//////		string[] arr = new string[5] { "A",
//////					"D", "X", "G", "M" };

//////		foreach (string g in arr)
//////		{
//////			Console.WriteLine(g);
//////			// display original array
//////		}

//////		Console.WriteLine("\nAfter Sort:");
//////		Array.Sort(arr);

//////		foreach (string g in arr)
//////		{
//////			Console.WriteLine(g);
//////			// display sorted array
//////		}

//////		Console.WriteLine("\nB sorts between :");

//////		// binary Search for "B"
//////		int index = Array.BinarySearch(arr, "B");

//////		// call "sortT" function
//////		// which is the Sort<T>(T[]) function
//////		sortT(arr, index);

//////		Console.WriteLine("\nF sorts between :");
//////		index = Array.BinarySearch(arr, "F");
//////		sortT(arr, index);
//////	}

//////	public static void sortT<T>(T[] arr, int index)
//////	{
//////		// If the index is negative,
//////		// it represents the bitwise
//////		// complement of the next larger
//////		// element in the array.
//////		if (index < 0)
//////		{
//////			index = ~index;

//////			if (index == 0)
//////				Console.Write("beginning of array");
//////			else
//////				Console.Write("{0} and ", arr[index - 1]);

//////			if (index == arr.Length)
//////				Console.WriteLine("end of array.");
//////			else
//////				Console.WriteLine("{0}", arr[index]);
//////		}
//////	}
//////}

//////// C# program to demonstrate the use of the
//////// Array.Sort<T>(T[], IComparer<T>) method
//////using System;
//////using System.Collections.Generic;
//////public class EnigmaCamp : IComparer<string>
//////{
//////	public int Compare(string x, string y)
//////	{
//////		// Compare x and y in reverse order.
//////		return x.CompareTo(y);
//////	}
//////}

//////class EC
//////{
//////	// Main Method
//////	public static void Main()
//////	{
//////		// array elements
//////		string[] arr = new string[5] {"A",
//////					"D", "X", "G", "M" };

//////		foreach (string g in arr)
//////		{

//////			// display original array
//////			Console.WriteLine(g);
//////		}

//////		Console.WriteLine("\nAfter Sort: ");
//////		EnigmaCamp ec = new EnigmaCamp();

//////		// Sort<T>(T[], IComparer<T>) method
//////		Array.Sort(arr, ec);

//////		foreach (string g in arr)
//////		{
//////			// display sorted array
//////			Console.WriteLine(g);
//////		}

//////		Console.WriteLine("\nD Sorts between :");

//////		// binary Search for "D"
//////		int index = Array.BinarySearch(arr, "D");

//////		// call "sortT" function
//////		sortT(arr, index);

//////		Console.WriteLine("\nF Sorts between :");
//////		index = Array.BinarySearch(arr, "F");
//////		sortT(arr, index);
//////	}

//////	public static void sortT<T>(T[] arr, int index)
//////	{
//////		if (index < 0)
//////		{

//////			// If the index is negative,
//////			// it represents the bitwise
//////			// complement of the next
//////			// larger element in the array.
//////			index = ~index;

//////			Console.Write("Not found. Sorts between: ");

//////			if (index == 0)
//////				Console.Write("Beginning of array and ");
//////			else
//////				Console.Write("{0} and ", arr[index - 1]);

//////			if (index == arr.Length)
//////				Console.WriteLine("end of array.");
//////			else
//////				Console.WriteLine("{0}.", arr[index]);
//////		}
//////		else
//////		{
//////			Console.WriteLine("Found at index {0}.", index);
//////		}
//////	}
//////}


//////// C# program to demonstrate the use of
//////// Array.Sort<T>(T[], Int32, Int32) method
//////using System;
//////using System.Collections.Generic;
//////public class EnigmaCamp : IComparer<string>
//////{
//////	public int Compare(string x, string y)
//////	{
//////		// Compare y and x in reverse order.
//////		return y.CompareTo(x);
//////	}
//////}

//////public class Example
//////{
//////	// Main Method
//////	public static void Main()
//////	{
//////		// Array elements
//////		string[] arr = {"AB", "CD",
//////		"GH", "EF", "MN", "IJ"};

//////		Console.WriteLine("Original Array :");

//////		Display(arr);

//////		Console.WriteLine("\nSort the array between " +
//////									"index 1 to 4");

//////		// Array.Sort(T[], Int32, Int32) method
//////		// sort will happen in between
//////		// index 1 to 4
//////		Array.Sort(arr, 1, 4);
//////		Display(arr);

//////		Console.WriteLine("\nSort the array reversely" +
//////						" in between index 1 to 4");

//////		// sort will happen in between
//////		// index 1 to 4 reversely		
//////		Array.Sort(arr, 1, 4, new EnigmaCamp());

//////		Display(arr);
//////	}

//////	public static void Display(string[] arr)
//////	{
//////		foreach (string g in arr)
//////		{
//////			Console.WriteLine(g);
//////		}
//////	}
//////}

//////// C# program to demonstrate the use of the
//////// Array.Sort<T>(T[ ], Comparison<T>) Method
//////using System;
//////using System.Collections.Generic;
//////class EnigmaCamp
//////{
//////	private static int CompareComp(string x, string y)
//////	{
//////		if (y == null && x == null)
//////		{
//////			// If x and y is null
//////			// then x and y are same
//////			return 0;
//////		}
//////		else
//////		{
//////			// If x is null but y is not
//////			// null then y is greater.
//////			return -1;
//////		}
//////	}

//////	// Main method
//////	public static void Main()
//////	{
//////		string[] arr = {"Java", "C++", "Scala",
//////						"C", "Ruby", "Python"};

//////		Console.WriteLine("Original Array: ");

//////		// display original array
//////		Display(arr);

//////		Console.WriteLine("\nSort with Comparison: ");

//////		// Array.Sort<T>(T[], Comparison<T>)
//////		// Method
//////		Array.Sort(arr, CompareComp);

//////		// display sorted array
//////		Display(arr);

//////	}

//////	// Display function
//////	public static void Display(string[] arr)
//////	{
//////		foreach (string g in arr)
//////		{
//////			Console.WriteLine(g);
//////		}
//////	}
//////}

//////// ARRAY RANK
//////// Contoh 1
//////// C# program to illustrate the
//////// Array.Rank Property
//////using System;
//////namespace EnigmaCamp
//////{
//////	class EC
//////	{

//////		// Main Method
//////		public static void Main()
//////		{
//////			// declares a 1D Array of string.
//////			string[] weekDays;

//////			// allocating memory for days.
//////			weekDays = new string[] {"Sun", "Mon", "Tue", "Wed",
//////									"Thu", "Fri", "Sat" };

//////			// using Rank Property
//////			Console.WriteLine("Dimension of weekDays array: "
//////										+ weekDays.Rank);
//////		}
//////	}
//////}

//////// Contoh 2
//////// C# program to illustrate the
//////// Array.Rank Property
//////using System;
//////namespace EnigmaCamp
//////{
//////	class EC
//////	{
//////		// Main Method
//////		public static void Main()
//////		{
//////			// declaring an 2-D array
//////			int[,] arr2d = new int[4, 2];

//////			// declaring an 3-D array
//////			int[,,] arr3d = new int[4, 2, 3];

//////			// declaring an jagged array
//////			int[][] jdarr = new int[2][];

//////			// using Rank Property
//////			Console.WriteLine("Dimension of arr2d array: "
//////											+ arr2d.Rank);

//////			Console.WriteLine("Dimension of arr3d array: "
//////											+ arr3d.Rank);

//////			// for the jagged array it
//////			// will always return 1
//////			Console.WriteLine("Dimension of jdarr array: "
//////											+ jdarr.Rank);
//////		}
//////	}
//////}

////// ArrayList
//////// C# program to demonstrate the ArrayList
//////using System;
//////using System.Collections;
//////class EnigmaCamp
//////{
//////	// Main Method
//////	static public void Main()
//////	{

//////		// Creating ArrayList
//////		ArrayList My_array = new ArrayList();

//////		// Adding elements in the
//////		// My_array ArrayList
//////		// This ArrayList contains elements
//////		// of different types
//////		My_array.Add(12.56);
//////		My_array.Add("EnigmaCamp");
//////		My_array.Add(null);
//////		My_array.Add('E');
//////		My_array.Add(1234);

//////		// Accessing the elements
//////		// of My_array ArrayList
//////		// Using foreach loop
//////		foreach (var elements in My_array)
//////		{
//////			Console.WriteLine(elements);
//////		}
//////	}
//////}

//////// C# program to find the number of
//////// elements and capacity of ArrayList
//////using System;
//////using System.Collections;
//////class EnigmaCamp
//////{
//////	// Driver code
//////	public static void Main()
//////	{
//////		// Creating an ArrayList
//////		ArrayList myList = new ArrayList();

//////		// Adding elements to ArrayList
//////		myList.Add(1);
//////		myList.Add(2);
//////		myList.Add(3);
//////		myList.Add(4);
//////		myList.Add(5);

//////		// Displaying count of elements of ArrayList
//////		Console.WriteLine("Number of elements: " + myList.Count);

//////		// Displaying Current capacity of ArrayList
//////		Console.WriteLine("Current capacity: " + myList.Capacity);
//////	}
//////}

//////// C# program to illustrate how
//////// to remove elements from the
//////// ArrayList
//////using System;
//////using System.Collections;
//////class EnigmaCamp
//////{
//////	static public void Main()
//////	{
//////		// Creating ArrayList
//////		ArrayList My_array = new ArrayList();

//////		// Adding elements in the
//////		// My_array ArrayList
//////		// This ArrayList contains elements
//////		// of the same types
//////		My_array.Add('G');
//////		My_array.Add('E');
//////		My_array.Add('E');
//////		My_array.Add('K');
//////		My_array.Add('S');
//////		My_array.Add('F');
//////		My_array.Add('O');
//////		My_array.Add('R');
//////		My_array.Add('G');
//////		My_array.Add('E');
//////		My_array.Add('E');
//////		My_array.Add('K');
//////		My_array.Add('S');

//////		Console.WriteLine("Initial number of elements : "
//////									+ My_array.Count);

//////		// Remove the 'G' element
//////		// from the ArrayList
//////		// Using Remove() method
//////		My_array.Remove('G');
//////		Console.WriteLine("After Remove() method the " +
//////			"number of elements: " + My_array.Count);

//////		// Remove the element present at index 8
//////		// Using RemoveAt() method
//////		My_array.RemoveAt(8);
//////		Console.WriteLine("After RemoveAt() method the " +
//////				"number of elements: " + My_array.Count);

//////		// Remove 3 elements starting from index 1
//////		// using RemoveRange() method
//////		My_array.RemoveRange(1, 3);
//////		Console.WriteLine("After RemoveRange() method the" +
//////				" number of elements: " + My_array.Count);

//////		// Remove the all element
//////		// present in ArrayList
//////		// Using Clear() method
//////		My_array.Clear();
//////		Console.WriteLine("After Clear() method the " +
//////			"number of elements: " + My_array.Count);
//////	}
//////}

//////// C# program to illustrate
//////// sorting of ArrayList
//////using System;
//////using System.Collections;
//////public class EnigmaCamp
//////{
//////	static public void Main()
//////	{
//////		// Creating ArrayList
//////		ArrayList My_array = new ArrayList();

//////		// Adding elements in the
//////		// My_array ArrayList
//////		// This ArrayList contains
//////		// elements of the same types
//////		My_array.Add(1);
//////		My_array.Add(6);
//////		My_array.Add(40);
//////		My_array.Add(10);
//////		My_array.Add(5);
//////		My_array.Add(3);
//////		My_array.Add(2);
//////		My_array.Add(4);

//////		// ArrayList before sorting
//////		Console.WriteLine("ArrayList before using Sort() method:");

//////		foreach (var elements in My_array)
//////		{
//////			Console.WriteLine(elements);
//////		}

//////		// Sort the elements of the ArrayList
//////		// Using sort() method
//////		My_array.Sort();

//////		// ArrayList after sorting
//////		Console.WriteLine("ArrayList after using Sort() method:");
//////		foreach (var elements in My_array)
//////		{
//////			Console.WriteLine(elements);
//////		}
//////	}
//////}

//////ARRAYLIST CLASS
////// C# code to create an ArrayList
//////using System;
//////using System.Collections;
//////using System.Collections.Generic;
//////class EnigmaCamp
//////{

//////	// Driver code
//////	public static void Main()
//////	{
//////		// Creating an ArrayList
//////		ArrayList myList = new ArrayList();

//////		// Adding elements to ArrayList
//////		myList.Add("Hello");
//////		myList.Add("World");

//////		Console.WriteLine("Count : " + myList.Count);
//////		Console.WriteLine("Capacity : " + myList.Capacity);
//////	}
//////}

//////// C# program to illustrate the
//////// ArrayList Class Properties
//////using System;
//////using System.Collections;
//////using System.Collections.Generic;
//////class EnigmaCamp
//////{
//////	// Driver code
//////	public static void Main()
//////	{
//////		// Creating an ArrayList
//////		ArrayList myList = new ArrayList();

//////		// Adding elements to ArrayList
//////		myList.Add("A");
//////		myList.Add("B");
//////		myList.Add("C");
//////		myList.Add("D");
//////		myList.Add("E");
//////		myList.Add("F");

//////		// -------- IsFixedSize Property --------

//////		// To check if the ArrayList has fixed size or not
//////		Console.WriteLine(myList.IsFixedSize);

//////		// -------- IsReadOnly Property --------

//////		// To check if the ArrayList is read-only or not
//////		Console.WriteLine(myList.IsReadOnly);
//////	}
//////}

//////// C# code to check if an element is
//////// contained in ArrayList or not
//////using System;
//////using System.Collections;
//////using System.Collections.Generic;
//////class EnigmaCamp
//////{
//////	// Driver code
//////	public static void Main()
//////	{
//////		// Creating an ArrayList
//////		ArrayList myList = new ArrayList();

//////		// Adding elements to ArrayList
//////		myList.Add("A");
//////		myList.Add("B");
//////		myList.Add("C");
//////		myList.Add("D");
//////		myList.Add("E");
//////		myList.Add("F");
//////		myList.Add("G");
//////		myList.Add("H");

//////		// To check if the ArrayList Contains element "E"
//////		// If yes, then display it's index, else
//////		// display the message
//////		if (myList.Contains("E"))
//////			Console.WriteLine("Yes, exists at index " + myList.IndexOf("E"));
//////		else
//////			Console.WriteLine("No, doesn't exists");
//////	}
//////}

//////// C# code to remove a range of
//////// elements from the ArrayList
//////using System;
//////using System.Collections;
//////using System.Collections.Generic;
//////class EnigmaCamp
//////{
//////	// Driver code
//////	public static void Main()
//////	{
//////		// Creating an ArrayList
//////		ArrayList myList = new ArrayList(10);

//////		// Adding elements to ArrayList
//////		myList.Add(2);
//////		myList.Add(4);
//////		myList.Add(6);
//////		myList.Add(8);
//////		myList.Add(10);
//////		myList.Add(12);
//////		myList.Add(14);
//////		myList.Add(16);
//////		myList.Add(18);
//////		myList.Add(20);

//////		// Displaying the elements in ArrayList
//////		Console.WriteLine("The initial ArrayList: ");

//////		foreach (int i in myList)
//////		{
//////			Console.WriteLine(i);
//////		}

//////		// removing 4 elements starting from index 0
//////		myList.RemoveRange(0, 4);

//////		// Displaying the modified ArrayList
//////		Console.WriteLine("The ArrayList after Removing elements: ");

//////		// Displaying the elements in ArrayList
//////		foreach (int i in myList)
//////		{
//////			Console.WriteLine(i);
//////		}
//////	}
//////}

////class Program
////{
////    static void Main()
////    {
////        int[] arr = new int[5];
////        arr[0] = 1;
////        arr[1] = 2;
////        arr[2] = 3;
////        arr[3] = 4;
////        arr[4] = 5;

////        Array.Resize(ref arr, 10);
////        foreach(var item in arr)
////        {
////            Console.WriteLine(item);
////        }
////    }
////}