//////CONTOH 1 ENUM
////class Program
////{
////    enum Season
////    {
////        Spring,
////        Summer,
////        Autumn,
////        Winter
////    }

////    static void Main()
////    {
////        var enumList = from EnumSeason in Enum.GetNames(typeof(Season))
////                       select
////                       new
////                       {
////                           Value = EnumSeason
////                       };

////        foreach (var item in enumList)
////        {
////            Console.WriteLine(item);
////        }

////        Console.ReadKey();
////    }
////}

////CONTOH 2 ENUM
//class Program
//{
//    enum Season
//    {
//        Spring,
//        Summer,
//        Autumn,
//        Winter
//    }

//    static void Main()
//    {
//        var enumList = from EnumSeason in Enum.GetNames(typeof(Season))
//                       select
//                       new
//                       {
//                           Value = (int)Enum.Parse(typeof(Season), EnumSeason)
//                       };

//        foreach (var item in enumList)
//        {
//            Console.WriteLine(item);
//        }

//        Console.ReadKey();
//    }
//}


////// CONTOH 3 ENUM
////class Program
////{
////    enum Season
////    {
////        Spring,
////        Summer,
////        Autumn,
////        Winter
////    }

////    static void Main()
////    {
////        Console.WriteLine($"{Season.Spring}");
////        Console.ReadKey();
////    }
////}
///


//// CONTOH 1 STRUCT
//class Program
//{
//    public readonly struct Coords
//    {
//        public Coords(double x, double y)
//        {
//            X = x;
//            Y = y;
//        }

//        public double X { get; init; }
//        public double Y { get; init; }

//        public override string ToString() => $"({X}, {Y})";
//    }

//    public static void Main()
//    {
//        var p1 = new Coords(0, 0);
//        Console.WriteLine(p1);  // output: (0, 0)

//        var p2 = p1 with { X = 3 };
//        Console.WriteLine(p2);  // output: (3, 0)

//        var p3 = p1 with { X = 1, Y = 4 };
//        Console.WriteLine(p3);  // output: (1, 4)

//        Console.ReadKey();
//    }
//}

//// CONTOH 2 STRUCT
//class Program
//{
//    public readonly struct Measurement
//    {
//        public Measurement()
//        {
//            Value = double.NaN;
//            Description = "Undefined";
//        }

//        public Measurement(double value, string description)
//        {
//            Value = value;
//            Description = description;
//        }

//        public double Value { get; init; }
//        public string Description { get; init; }

//        public override string ToString() => $"{Value} ({Description})";
//    }

//    public static void Main()
//    {
//        var m1 = new Measurement();
//        Console.WriteLine(m1);  // output: NaN (Undefined)

//        var m2 = default(Measurement);
//        Console.WriteLine(m2);  // output: 0 ()

//        var ms = new Measurement[2];
//        Console.WriteLine(string.Join(", ", ms));  // output: 0 (), 0 ()
//    }
//}

//// CONTOH 3 STRUCT
//class Program
//{
//    public readonly struct Measurement
//    {
//        public Measurement(double value)
//        {
//            Value = value;
//        }

//        public Measurement(double value, string description)
//        {
//            Value = value;
//            Description = description;
//        }

//        public double Value { get; init; }
//        public string Description { get; init; } = "Ordinary measurement";

//        public override string ToString() => $"{Value} ({Description})";
//    }

//    public static void Main()
//    {
//        var m1 = new Measurement(5);
//        Console.WriteLine(m1);  // output: 5 (Ordinary measurement)

//        var m2 = new Measurement();
//        Console.WriteLine(m2);  // output: 0 ()

//        var m3 = default(Measurement);
//        Console.WriteLine(m3);  // output: 0 ()
//    }
//}

// CONTOH 4 STRUCT
public static class StructWithoutNew
{
    public struct Coords
    {
        public double x;
        public double y;
    }

    public static void Main()
    {
        Coords p;
        p.x = 3;
        p.y = 4;
        Console.WriteLine($"({p.x}, {p.y})");  // output: (3, 4)
    }
}