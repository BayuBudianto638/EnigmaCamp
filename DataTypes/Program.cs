//CONTOH 1
public interface IMonster
{
    public void Makan();
    public void Tidur();
}

public class Kaiju : IMonster
{
    public void Makan()
    {
        Console.WriteLine("Kaiju Makan");
    }

    public void Tidur()
    {
        Console.WriteLine("Kaiju Tidur");
    }
}

public class Dinosaurus : IMonster
{
    public void Makan()
    {
        Console.WriteLine("Dinosaurus Makan");
    }

    public void Tidur()
    {
        Console.WriteLine("Dinosaurus Tidur");
    }
}

public class KeturunanKaiju : Kaiju
{

}

class program
{
    static void Main()
    {
        Kaiju kaiju = new Kaiju();
        kaiju.Makan();
        kaiju.Tidur();

        Dinosaurus dino = new Dinosaurus();
        dino.Makan();
        dino.Tidur();

        KeturunanKaiju ketKaiju = new KeturunanKaiju();
        ketKaiju.Makan();
        ketKaiju.Tidur();
    }
}


// CONTOH 2
//using DataTypes.Interface;

//public class MotorDOHC : IMotor
//{
//    public void Engkol()
//    {
//        Console.WriteLine("MotorDOHC gak pake engkol");
//    }

//    public void Mesin()
//    {
//        Console.WriteLine("MotorDOHC mesinnya DOHC 4 klep");
//    }

//    public void Roda()
//    {
//        Console.WriteLine("MotorDOHC punya 2 ban");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        MotorDOHC dohc = new MotorDOHC();
//        dohc.Engkol();
//        dohc.Mesin();
//        dohc.Roda();
//    }
//}

// CONTOH 3
//using DataTypes.Interface;
//public class Barang : IBarang
//{
//    public void GetBarangById()
//    {
//        Console.WriteLine("GetBarangById");
//    }

//    public void Simpan()
//    {
//        Console.WriteLine("Simpan Barang");
//    }

//    public void Update()
//    {
//        Console.WriteLine("Update Barang");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        Barang barang = new Barang();
//        barang.GetBarangById();
//        barang.Simpan();
//        barang.Update();
//    }
//}

//// CONTOH 4
//// C# program to demonstrate working of
//// interface
//using System;

//// A simple interface
//interface IDisplay
//{
//    // method having only declaration
//    // not definition
//    void display();
//}

//// A class that implements interface.
//class testClass : IDisplay
//{
//    // providing the body part of function
//    public void display()
//    {
//        Console.WriteLine("Sudo Placement EnigmaCamp");
//    }

//    // Main Method
//    public static void Main(String[] args)
//    {
//        // Creating object
//        testClass t = new testClass();

//        // calling method
//        t.display();
//    }
//}


// CONTOH 5
//// C# program to illustrate the interface
//using System;

//// interface declaration
//interface Vehicle
//{
//    // all are the abstract methods.
//    void changeGear(int a);
//    void speedUp(int a);
//    void applyBrakes(int a);
//}

//// class implements interface
//class Bicycle : Vehicle
//{
//    int speed;
//    int gear;

//    // to change gear
//    public void changeGear(int newGear)
//    {
//        gear = newGear;
//    }

//    // to increase speed
//    public void speedUp(int increment)
//    {
//        speed = speed + increment;
//    }

//    // to decrease speed
//    public void applyBrakes(int decrement)
//    {
//        speed = speed - decrement;
//    }

//    public void printStates()
//    {
//        Console.WriteLine("speed: " + speed +
//                        " gear: " + gear);
//    }
//}

//// class implements interface
//class Bike : Vehicle
//{
//    int speed;
//    int gear;

//    // to change gear
//    public void changeGear(int newGear)
//    {
//        gear = newGear;
//    }

//    // to increase speed
//    public void speedUp(int increment)
//    {
//        speed = speed + increment;
//    }

//    // to decrease speed
//    public void applyBrakes(int decrement)
//    {
//        speed = speed - decrement;
//    }

//    public void printStates()
//    {
//        Console.WriteLine("speed: " + speed +
//                        " gear: " + gear);
//    }

//}

//class EnigmaCamp
//{
//    // Main Method
//    public static void Main(String[] args)
//    {
//        // creating an instance of Bicycle
//        // doing some operations
//        Bicycle bicycle = new Bicycle();
//        bicycle.changeGear(2);
//        bicycle.speedUp(3);
//        bicycle.applyBrakes(1);

//        Console.WriteLine("Bicycle present state :");
//        bicycle.printStates();

//        // creating instance of bike.
//        Bike bike = new Bike();
//        bike.changeGear(1);
//        bike.speedUp(4);
//        bike.applyBrakes(3);

//        Console.WriteLine("Bike present state :");
//        bike.printStates();
//    }
//}


// CONTOH 6
// Interface using Dependcy Injection
// Penjelasan lengkap di SOLID Principles
//using DataTypes.Interface;
//using Microsoft.Extensions.DependencyInjection;
//public class Barang : IBarang
//{
//    public void GetBarangById()
//    {
//        Console.WriteLine("GetBarangById");
//    }

//    public void Simpan()
//    {
//        Console.WriteLine("Simpan Barang");
//    }

//    public void Update()
//    {
//        Console.WriteLine("Update Barang");
//    }
//}

//public class Transaksi : ITransaksi
//{
//    private readonly IBarang _barang;

//    public Transaksi (IBarang barang)
//    {
//        _barang = barang;
//    }

//    public void SimpanTransaksi()
//    {
//        _barang.GetBarangById();
//        Console.WriteLine("Simpan Transaksi");
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        //setup our DI
//        var serviceProvider = new ServiceCollection()
//            .AddSingleton<IBarang, Barang>()
//            .AddSingleton<ITransaksi, Transaksi>()
//            .BuildServiceProvider();

//        //do the actual work here
//        var transaksi = serviceProvider.GetService<ITransaksi>();
//        transaksi.SimpanTransaksi();
//    }
//}