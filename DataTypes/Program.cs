// CONTOH 1
// Abstract class
abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
    public override void animalSound()
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Pig myPig = new Pig(); // Create a Pig object
        myPig.animalSound();  // Call the abstract method
        myPig.sleep();  // Call the regular method
    }
}

//// CONTOH 2
//public abstract class Monster
//{
//    public abstract void Tidur();
//}

//public class Kaiju : Monster
//{
//    public override void Tidur()
//    {
//        Console.WriteLine("Kaiju Tidur");
//    }
//}

//public class Godzilla : Monster
//{
//    public override void Tidur()
//    {
//        Console.WriteLine("Godzilla Tidur");
//    }

//    public void AtomicBreath()
//    {
//        Console.WriteLine("Godzilla Atomic Breath");
//    }
//}

//class program
//{
//    static void Main(string[] args)
//    {
//        Kaiju kaiju = new Kaiju();
//        kaiju.Tidur();

//        Godzilla godzilla = new Godzilla();
//        godzilla.Tidur();
//        godzilla.AtomicBreath();

//        Console.ReadKey();
//    }
//}

// CONTOH 3
//using DataTypes;

//public class GurrenLagann : Mecha
//{
//    public override void BomNuklir()
//    {
//        Console.WriteLine("TGGL Bom Nuklir");
//    }

//    public override void MataLaser()
//    {
//        Console.WriteLine("TGGL Mengeluarkan mata laser");
//    }

//    public void GigaDrill()
//    {
//        Console.WriteLine("TGGL GigaDrill");
//    }
//}

//public class Patlabor : Mecha
//{
//    public override void BomNuklir()
//    {
//        Console.WriteLine("Patlabor tidak memiliki bom nuklir");
//    }

//    public override void MataLaser()
//    {
//        Console.WriteLine("Patlabor tidak memiliki mata laser");
//    }

//    public void PistolRevolver()
//    {
//        Console.WriteLine("Patlabor mengeluarkan pistol revolver");
//    }
//}

//class program
//{
//    static void Main()
//    {
//        GurrenLagann gl = new GurrenLagann();
//        gl.BomNuklir();
//        gl.MataLaser();
//        gl.GigaDrill();

//        Patlabor pl = new Patlabor();
//        pl.BomNuklir();
//        pl.MataLaser();
//        pl.PistolRevolver();

//        Console.ReadKey();
//    }
//}
