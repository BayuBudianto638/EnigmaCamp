//// Contoh 1
//// Create file
//using System;
//using System.IO;
//using System.Text;

//namespace FileHandlinDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Set the File Path
//            string FilePath = @"D:\MyFile.txt";
//            FileStream fileStream = new FileStream(FilePath, FileMode.Create);
//            fileStream.Close();
//            Console.Write("File has been created and the Path is D:\\MyFile.txt");
//            Console.ReadKey();
//        }
//    }
//}

////Contoh 2
////Open file and write
//using System;
//using System.IO;
//using System.Text;
//namespace FileHandlinDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Set the File Path
//            string FilePath = @"D:\MyFile.txt";
//            FileStream fileStream = new FileStream(FilePath, FileMode.Append);
//            byte[] bdata = Encoding.Default.GetBytes("C# Is an Object Oriented Programming Language");
//            fileStream.Write(bdata, 0, bdata.Length);
//            fileStream.Close();
//            Console.WriteLine("Successfully saved file with data : C# Is an Object Oriented Programming Language");
//            Console.ReadKey();
//        }
//    }
//}

////Contoh 3
//// File Read
//using System;
//using System.IO;
//namespace FileHandlinDemo
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string FilePath = @"D:\MyFile.txt";
//            string data;
//            FileStream fileStream = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
//            using (StreamReader streamReader = new StreamReader(fileStream))
//            {
//                data = streamReader.ReadToEnd();
//            }
//            Console.WriteLine(data);
//            Console.ReadLine();
//        }
//    }
//}


////Contoh 4
//using System;
//using System.IO;  // include the System.IO namespace
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization;
//using System.Text;

//namespace MyApplication
//{
//    [Serializable]
//    public enum DogColor
//    {
//        Brown,
//        Black,
//        Mottled
//    }

//    [Serializable]
//    public class Dog
//    {
//        public String Name
//        {
//            get; set;
//        }

//        public DogColor Color
//        {
//            get; set;
//        }

//        public override String ToString()
//        {
//            return String.Format("Dog: {0}/{1}", Name, Color);
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Dog myDog1 = new Dog();
//            myDog1.Name = "Foo";
//            myDog1.Color = DogColor.Brown;

//            Dog myDog2 = new Dog();
//            myDog2.Name = "Faa";
//            myDog2.Color = DogColor.Black;

//            List<Dog> listDog = new List<Dog>();
//            listDog.Add(myDog1);
//            listDog.Add(myDog2);

//            string namaFile = @"c:\Dokumen\db.dat";

//            if (!File.Exists(namaFile))
//            {
//                MemoryStream stream = SerializeToStream(listDog);
//                using (FileStream file = new FileStream(namaFile, FileMode.Create, System.IO.FileAccess.Write))
//                {
//                    stream.Seek(0, SeekOrigin.Begin);
//                    stream.CopyTo(file);
//                    file.Flush();
//                }
//            }

//            MemoryStream ms = new MemoryStream();
//            using (FileStream file = new FileStream(namaFile, FileMode.Open, FileAccess.Read))
//                file.CopyTo(ms);

//            List<Dog> newDog = (List<Dog>)DeserializeFromStream(ms);

//            foreach (Dog dog in newDog)
//            {
//                System.Console.WriteLine($"Dog : {dog.Name} - {dog.Color}");
//            }
//        }

//        public static MemoryStream SerializeToStream(object o)
//        {
//            MemoryStream ms = new MemoryStream();
//            var formatter = new BinaryFormatter();
//            formatter.Serialize(ms, o);
//            return ms;
//        }

//        public static object DeserializeFromStream(MemoryStream stream)
//        {
//            IFormatter formatter = new BinaryFormatter();
//            stream.Seek(0, SeekOrigin.Begin);
//            object o = formatter.Deserialize(stream);
//            return o;
//        }

//        public static byte[] ReadBytes(MemoryStream input)
//        {
//            using (MemoryStream ms = new MemoryStream())
//            {
//                input.CopyTo(ms);
//                return ms.ToArray();
//            }
//        }
//    }
//}

//Contoh 5
using System;
using System.IO;  // include the System.IO namespace
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;

namespace MyApplication
{
    [Serializable]
    public class Perpustakaan
    {
        public List<Buku> listBuku { get; set; }
        public List<Penerbit> listPenerbit { get; set; }
    }

    [Serializable]
    public class Penerbit
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    [Serializable]
    public class Buku
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public virtual Penerbit penerbit { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Perpustakaan perpustakaan = new Perpustakaan()
            {
                listBuku = new List<Buku>(),
                listPenerbit = new List<Penerbit>()
            };
            
            Penerbit penerbit = new Penerbit();
            penerbit.Code = "Penerbit-001";
            penerbit.Name = "Penerbit Jaya";

            Buku buku = new Buku();
            buku.Code = "Book-001";
            buku.Name = "Delphi Fundamental";
            buku.penerbit = penerbit;

            perpustakaan.listBuku.Add(buku);
            perpustakaan.listPenerbit.Add(penerbit);

            string namaFile = @"c:\Dokumen\perpustakaan.dat";

            if (!File.Exists(namaFile))
            {
                MemoryStream stream = SerializeToStream(perpustakaan);
                using (FileStream file = new FileStream(namaFile, FileMode.Create, System.IO.FileAccess.Write))
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    stream.CopyTo(file);
                    file.Flush();
                }
            }

            MemoryStream ms = new MemoryStream();
            using (FileStream file = new FileStream(namaFile, FileMode.Open, FileAccess.Read))
                file.CopyTo(ms);

          var  listPerpustakaan = (Perpustakaan)DeserializeFromStream(ms);

            foreach (var itemBuku in listPerpustakaan.listBuku)
            {
                System.Console.WriteLine($"Buku : {itemBuku.Code} - {itemBuku.Name} - {itemBuku.penerbit.Name}");
            }
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