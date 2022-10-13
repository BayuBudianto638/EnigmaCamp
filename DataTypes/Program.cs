﻿//class Program
//{
//    static void Main()
//    {
//        Program.CreateFileAsync("test.txt").Wait();
//    }
//    public static async Task CreateFileAsync(string filename)
//    {
//        using (StreamWriter writer = File.CreateText(filename))
//            await writer.WriteAsync("Enigma Camp.");
//    }
//}

//class Program
//{
//    static async Task Main(string[] args)
//    {
//        var async = new Async();
//        async.SayGreeting();

//        string str2 = await async.ReturnGreeting();
//        Console.WriteLine(str2);
//    }
//}

//class Async
//{
//    public async Task<string> ReturnGreeting()
//    {
//        await Task.Delay(1000);
//        return "Hello";
//    }

//    public async void SayGreeting()
//    {
//        await Task.Delay(1000);
//        Console.WriteLine("Hello");
//    }

//}

//using System;
//using System.Threading.Tasks;

//namespace AsyncBreakfast
//{
//    // These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
//    internal class Bacon { }
//    internal class Coffee { }
//    internal class Egg { }
//    internal class Juice { }
//    internal class Toast { }

//    class Program
//    {
//        //static void Main(string[] args)
//        //{
//        //    Coffee cup = PourCoffee();
//        //    Console.WriteLine("coffee is ready");

//        //    Egg eggs = FryEggs(2);
//        //    Console.WriteLine("eggs are ready");

//        //    Bacon bacon = FryBacon(3);
//        //    Console.WriteLine("bacon is ready");

//        //    Toast toast = ToastBread(2);
//        //    ApplyButter(toast);
//        //    ApplyJam(toast);
//        //    Console.WriteLine("toast is ready");

//        //    Juice oj = PourOJ();
//        //    Console.WriteLine("oj is ready");
//        //    Console.WriteLine("Breakfast is ready!");
//        //}

//        //static async Task Main(string[] args)
//        //{
//        //    Coffee cup = PourCoffee();
//        //    Console.WriteLine("coffee is ready");

//        //    Egg eggs = await FryEggsAsync(2);
//        //    Console.WriteLine("eggs are ready");

//        //    Bacon bacon = await FryBaconAsync(3);
//        //    Console.WriteLine("bacon is ready");

//        //    Toast toast = await ToastBreadAsync(2);
//        //    ApplyButter(toast);
//        //    ApplyJam(toast);
//        //    Console.WriteLine("toast is ready");

//        //    Juice oj = PourOJ();
//        //    Console.WriteLine("oj is ready");
//        //    Console.WriteLine("Breakfast is ready!");
//        //}

//        private static Juice PourOJ()
//        {
//            Console.WriteLine("Pouring orange juice");
//            return new Juice();
//        }

//        private static void ApplyJam(Toast toast) =>
//            Console.WriteLine("Putting jam on the toast");

//        private static void ApplyButter(Toast toast) =>
//            Console.WriteLine("Putting butter on the toast");

//        private static async Task<Toast> ToastBreadAsync(int slices)
//        {
//            for (int slice = 0; slice < slices; slice++)
//            {
//                Console.WriteLine("Putting a slice of bread in the toaster");
//            }
//            Console.WriteLine("Start toasting...");
//            Task.Delay(3000).Wait();
//            Console.WriteLine("Remove toast from toaster");

//            return await Task.Run(() => new Toast());
//        }

//        private static Toast ToastBread(int slices)
//        {
//            for (int slice = 0; slice < slices; slice++)
//            {
//                Console.WriteLine("Putting a slice of bread in the toaster");
//            }
//            Console.WriteLine("Start toasting...");
//            Task.Delay(3000).Wait();
//            Console.WriteLine("Remove toast from toaster");

//            return new Toast();
//        }

//        private static async Task<Bacon> FryBaconAsync(int slices)
//        {
//            Console.WriteLine($"putting {slices} slices of bacon in the pan");
//            Console.WriteLine("cooking first side of bacon...");
//            Task.Delay(3000).Wait();
//            for (int slice = 0; slice < slices; slice++)
//            {
//                Console.WriteLine("flipping a slice of bacon");
//            }
//            Console.WriteLine("cooking the second side of bacon...");
//            Task.Delay(3000).Wait();
//            Console.WriteLine("Put bacon on plate");

//            return await Task.Run(() => new Bacon());
//        }

//        private static Bacon FryBacon(int slices)
//        {
//            Console.WriteLine($"putting {slices} slices of bacon in the pan");
//            Console.WriteLine("cooking first side of bacon...");
//            Task.Delay(3000).Wait();
//            for (int slice = 0; slice < slices; slice++)
//            {
//                Console.WriteLine("flipping a slice of bacon");
//            }
//            Console.WriteLine("cooking the second side of bacon...");
//            Task.Delay(3000).Wait();
//            Console.WriteLine("Put bacon on plate");

//            return new Bacon();
//        }

//        private static async Task<Egg> FryEggsAsync(int howMany)
//        {
//            Console.WriteLine("Warming the egg pan...");
//            Task.Delay(3000).Wait();
//            Console.WriteLine($"cracking {howMany} eggs");
//            Console.WriteLine("cooking the eggs ...");
//            Task.Delay(3000).Wait();
//            Console.WriteLine("Put eggs on plate");

//            return await Task.Run(() => new Egg());
//        }

//        private static Egg FryEggs(int howMany)
//        {
//            Console.WriteLine("Warming the egg pan...");
//            Task.Delay(3000).Wait();
//            Console.WriteLine($"cracking {howMany} eggs");
//            Console.WriteLine("cooking the eggs ...");
//            Task.Delay(3000).Wait();
//            Console.WriteLine("Put eggs on plate");

//            return new Egg();
//        }

//        private static Coffee PourCoffee()
//        {
//            Console.WriteLine("Pouring coffee");
//            return new Coffee();
//        }
//    }
//}