//using System;
//using System.IO;  // include the System.IO namespace

//namespace MyApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string writeText = "Hello World!";  // Create a text string
//            File.WriteAllText(@"c:\Dokumen\filename.txt", writeText);  // Create a file and write the contents of writeText to it

//            string readText = File.ReadAllText(@"c:\Dokumen\filename.txt"); // Read the contents of the file

//            string[] readRecord = readText.Split(",");
//            string cari = "Anton";
//            var caristr = readRecord.FirstOrDefault(cari);
//            string[] listdata = caristr.Split(";");
//            foreach (var item in listdata)
//            {
//                Console.WriteLine(item); // Output the content
//            }

//            //Console.WriteLine(caristr);
//            //foreach (var item in readRecord)
//            //{
//            //    Console.WriteLine(item); // Output the content
//            //}
//        }
//    }
//}

//using System;
//using System.IO;  // include the System.IO namespace

//namespace MyApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //string writeText = "Hello World!";  // Create a text string
//            //File.WriteAllText(@"c:\Dokumen\filename.txt", writeText);  // Create a file and write the contents of writeText to it

//            string readText = File.ReadAllText(@"c:\Dokumen\filename.txt"); // Read the contents of the file

//            string[] readRecord = readText.Split(",");
//            string cari = "Anton";
//            var caristr = readRecord.FirstOrDefault(cari);
//            string[] listdata = caristr.Split(";");
//            foreach (var item in listdata)
//            {
//                Console.WriteLine(item); // Output the content
//            }

//            //Console.WriteLine(caristr);
//            //foreach (var item in readRecord)
//            //{
//            //    Console.WriteLine(item); // Output the content
//            //}
//        }
//    }
//}


//Contoh 2
using System;
using System.IO;  // include the System.IO namespace
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;

namespace MyApplication
{
    [Serializable]
    public enum DogColor
    {
        Brown,
        Black,
        Mottled
    }

    [Serializable]
    public class Dog
    {
        public String Name
        {
            get; set;
        }

        public DogColor Color
        {
            get; set;
        }

        public override String ToString()
        {
            return String.Format("Dog: {0}/{1}", Name, Color);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog1 = new Dog();
            myDog1.Name = "Foo";
            myDog1.Color = DogColor.Brown;

            Dog myDog2 = new Dog();
            myDog2.Name = "Faa";
            myDog2.Color = DogColor.Black;

            List<Dog> listDog = new List<Dog>();
            listDog.Add(myDog1);
            listDog.Add(myDog2);

            MemoryStream stream = SerializeToStream(listDog);
            using (FileStream file = new FileStream(@"c:\Dokumen\db.dat", FileMode.Create, System.IO.FileAccess.Write))
            {
                stream.Seek(0, SeekOrigin.Begin);
                stream.CopyTo(file);
                file.Flush();
            }

            MemoryStream ms = new MemoryStream();
            using (FileStream file = new FileStream(@"c:\Dokumen\db.dat", FileMode.Open, FileAccess.Read))
                file.CopyTo(ms);

            List<Dog> newDog = (List<Dog>)DeserializeFromStream(ms);

            System.Console.WriteLine("{0}", newDog.ToString());
        }

        public static MemoryStream SerializeToStream(object o)
        {
            MemoryStream ms = new MemoryStream();
            var formatter = new BinaryFormatter();
            formatter.Serialize(ms, o);
            return ms;
        }

        public static object DeserializeFromStream(MemoryStream stream)
        {
            IFormatter formatter = new BinaryFormatter();
            stream.Seek(0, SeekOrigin.Begin);
            object o = formatter.Deserialize(stream);
            return o;
        }

        public static byte[] ReadBytes(MemoryStream input)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }
    }
}