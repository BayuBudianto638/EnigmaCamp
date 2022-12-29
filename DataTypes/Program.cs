using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new person");
            Console.WriteLine("2. Read all people");
            Console.WriteLine("3. Update a person");
            Console.WriteLine("4. Delete a person");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    // Create a new person
                    Console.Write("Enter the name of the person: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the age of the person: ");
                    int age = int.Parse(Console.ReadLine());
                    Person person = new Person(name, age);
                    people.Add(person);
                    break;
                case 2:
                    // Read all people
                    foreach (Person p in people)
                    {
                        Console.WriteLine(p.ToString());
                    }
                    break;
                case 3:
                    // Update a person
                    Console.Write("Enter the name of the person to update: ");
                    string updateName = Console.ReadLine();
                    Console.Write("Enter the new age of the person: ");
                    int updateAge = int.Parse(Console.ReadLine());
                    Person personToUpdate = null;
                    foreach (Person p in people)
                    {
                        if (p.Name == updateName)
                        {
                            personToUpdate = p;
                            break;
                        }
                    }
                    if (personToUpdate != null)
                    {
                        personToUpdate.Age = updateAge;
                    }
                    else
                    {
                        Console.WriteLine("Person not found.");
                    }
                    break;
                case 4:
                    // Delete a person
                    Console.Write("Enter the name of the person to delete: ");
                    string deleteName = Console.ReadLine();
                    Person personToDelete = null;
                    foreach (Person p in people)
                    {
                        if (p.Name == deleteName)
                        {
                            personToDelete = p;
                            break;
                        }
                    }
                    if (personToDelete != null)
                    {
                        people.Remove(personToDelete);
                    }
                    else
                    {
                        Console.WriteLine("Person not found.");
                    }
                    break;
                case 5:
                    // Exit
                    return;
            }
        }
    }
}


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
//            string namaFile = @"c:\Dokumen\myFile.dat";
//            FileStream fileStream = new FileStream(namaFile, FileMode.Create);
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
//            string namaFile = @"c:\Dokumen\myFile.dat";
//            FileStream fileStream = new FileStream(namaFile, FileMode.Append);
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
//            string namaFile = @"c:\Dokumen\myFile.dat";
//            string data;
//            FileStream fileStream = new FileStream(namaFile, FileMode.Open, FileAccess.Read);
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
//    /*
//     *The object is serialized to a stream that carries the data. The stream may also have information about the object's type, 
//     *such as its version, culture, and assembly name. From that stream, the object can be stored in a database, a file, or memory.
//     */
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

//////Contoh 5
////using System;
////using System.IO;  // include the System.IO namespace
////using System.Runtime.Serialization.Formatters.Binary;
////using System.Runtime.Serialization;
////using System.Text;

////namespace MyApplication
////{
////    [Serializable]
////    public class Perpustakaan
////    {
////        public List<Buku> listBuku { get; set; }
////        public List<Penerbit> listPenerbit { get; set; }
////    }

////    [Serializable]
////    public class Penerbit
////    {
////        public string Code { get; set; }
////        public string Name { get; set; }
////    }

////    [Serializable]
////    public class Buku
////    {
////        public string Code { get; set; }
////        public string Name { get; set; }
////        public virtual Penerbit penerbit { get; set; }
////    }

////    class Program
////    {
////        static void Main(string[] args)
////        {
////            Perpustakaan perpustakaan = new Perpustakaan()
////            {
////                listBuku = new List<Buku>(),
////                listPenerbit = new List<Penerbit>()
////            };

////            Penerbit penerbit = new Penerbit();
////            penerbit.Code = "Penerbit-001";
////            penerbit.Name = "Penerbit Jaya";

////            Buku buku = new Buku();
////            buku.Code = "Book-001";
////            buku.Name = "Delphi Fundamental";
////            buku.penerbit = penerbit;

////            perpustakaan.listBuku.Add(buku);
////            perpustakaan.listPenerbit.Add(penerbit);

////            string namaFile = @"c:\Dokumen\perpustakaan.dat";

////            if (!File.Exists(namaFile))
////            {
////                MemoryStream stream = SerializeToStream(perpustakaan);
////                using (FileStream file = new FileStream(namaFile, FileMode.Create, System.IO.FileAccess.Write))
////                {
////                    stream.Seek(0, SeekOrigin.Begin);
////                    stream.CopyTo(file);
////                    file.Flush();
////                }
////            }

////            // Open File
////            MemoryStream ms = new MemoryStream();
////            using (FileStream file = new FileStream(namaFile, FileMode.Open, FileAccess.Read))
////                file.CopyTo(ms);

////            // Assign to Object
////            var listPerpustakaan = (Perpustakaan)DeserializeFromStream(ms);
////            listPerpustakaan.listBuku.Add(buku);

////            //// Save to stream
////            //MemoryStream stream1 = SerializeToStream(listPerpustakaan);
////            //using (FileStream file = new FileStream(namaFile, FileMode.Open, System.IO.FileAccess.Write))
////            //{
////            //    stream1.Seek(0, SeekOrigin.Begin);
////            //    stream1.CopyTo(file);
////            //    file.Flush();
////            //}

////            MemoryStream ms2 = new MemoryStream();
////            using (FileStream file = new FileStream(namaFile, FileMode.Open, FileAccess.Read))
////                file.CopyTo(ms2);

////            var listPerpustakaan2 = (Perpustakaan)DeserializeFromStream(ms2);

////            foreach (var itemBuku in listPerpustakaan2.listBuku)
////            {
////                System.Console.WriteLine($"Buku : {itemBuku.Code} - {itemBuku.Name} - {itemBuku.penerbit.Name}");
////            }
////        }

////        public static MemoryStream SerializeToStream(object o)
////        {
////            MemoryStream ms = new MemoryStream();
////            var formatter = new BinaryFormatter();
////            formatter.Serialize(ms, o);
////            return ms;
////        }

////        public static object DeserializeFromStream(MemoryStream stream)
////        {
////            IFormatter formatter = new BinaryFormatter();
////            stream.Seek(0, SeekOrigin.Begin);
////            object o = formatter.Deserialize(stream);
////            return o;
////        }

////        public static byte[] ReadBytes(MemoryStream input)
////        {
////            using (MemoryStream ms = new MemoryStream())
////            {
////                input.CopyTo(ms);
////                return ms.ToArray();
////            }
////        }
////    }
////}

////Contoh 3 Using Menu like basic Pascal/C++ Console
//using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization;
//using System.Xml.Linq;

//namespace MyApplication
//{
//    [Serializable]
//    public class Perpustakaan
//    {
//        public List<Buku> listBuku { get; set; }
//        public List<Penerbit> listPenerbit { get; set; }
//    }

//    [Serializable]
//    public class Penerbit
//    {
//        public string Code { get; set; }
//        public string Name { get; set; }
//    }

//    [Serializable]
//    public class Buku
//    {
//        public string Code { get; set; }
//        public string Name { get; set; }
//        public virtual Penerbit penerbit { get; set; }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool showMenu = true;
//            while (showMenu)
//            {
//                showMenu = MainMenu();
//            }
//        }

//        private static bool MainMenu()
//        {
//            Console.Clear();
//            Console.WriteLine("Choose an option:");
//            Console.WriteLine("1) Create File Perpustakaan");
//            Console.WriteLine("2) Hapus File Perpustakaan");
//            Console.WriteLine("3) Create Penerbit");
//            Console.WriteLine("4) Create Buku");
//            Console.WriteLine("5) Get All Penerbit");
//            Console.WriteLine("6) Get All Buku");
//            Console.WriteLine("7) Get Penerbit by Name");
//            Console.WriteLine("8) Get Buku by Name");
//            Console.Write("\r\nSelect an option: ");

//            switch (Console.ReadLine())
//            {
//                case "1":
//                    CreateFilePerpustakaan();
//                    return true;
//                case "2":
//                    HapusFilePerpustakaan();
//                    return true;
//                case "3":
//                    CreatePenerbit();
//                    return true;
//                case "4":
//                    CreateBuku();
//                    return true;
//                case "5":
//                    GetAllPenerbit();
//                    return true;
//                case "6":
//                    GetAllBuku();
//                    return true;
//                case "7":
//                    GetAllBuku();
//                    return true;
//                case "8":
//                    return false;
//                default:
//                    return true;
//            }
//        }

//        private static void CreateFilePerpustakaan()
//        {
//            string namaFile = @"c:\Dokumen\perpustakaan.dat";

//            if (!File.Exists(namaFile))
//            {
//                Perpustakaan perpustakaan = new Perpustakaan()
//                {
//                    listBuku = new List<Buku>(),
//                    listPenerbit = new List<Penerbit>()
//                };

//                MemoryStream stream = SerializeToStream(perpustakaan);
//                using (FileStream file = new FileStream(namaFile, FileMode.Create, System.IO.FileAccess.Write))
//                {
//                    stream.Seek(0, SeekOrigin.Begin);
//                    stream.CopyTo(file);
//                    file.Flush();
//                }
//            }
//        }

//        private static void HapusFilePerpustakaan()
//        {
//            string namaFile = @"c:\Dokumen\perpustakaan.dat";

//            if (File.Exists(namaFile))
//            {
//                File.Delete(namaFile);
//            }
//        }

//        private static void SaveFile(Perpustakaan perpustakaan)
//        {
//            string namaFile = @"c:\Dokumen\perpustakaan.dat";

//            MemoryStream stream = SerializeToStream(perpustakaan);
//            using (FileStream file = new FileStream(namaFile, FileMode.Open, System.IO.FileAccess.Write))
//            {
//                stream.Seek(0, SeekOrigin.Begin);
//                stream.CopyTo(file);
//                file.Flush();
//            }
//        }

//        private static Perpustakaan OpenFile()
//        {
//            string namaFile = @"c:\Dokumen\perpustakaan.dat";

//            MemoryStream ms = new MemoryStream();
//            using (FileStream file = new FileStream(namaFile, FileMode.Open, FileAccess.Read))
//                file.CopyTo(ms);

//            var listPerpustakaan = (Perpustakaan)DeserializeFromStream(ms);

//            return listPerpustakaan;
//        }

//        private static void CreatePenerbit()
//        {
//            string namaFile = @"c:\Dokumen\perpustakaan.dat";

//            var perpustakaan = OpenFile();

//            Console.Clear();
//            Console.WriteLine("Create Penerbit");
//            Console.WriteLine("---------------");

//            Console.Write("Code:");
//            string code = Console.ReadLine();

//            Console.Write("Name:");
//            string name = Console.ReadLine();

//            var updatePenerbit = GetPenerbitByNama(name);

//            Penerbit penerbit = new Penerbit();
//            penerbit.Code = code;
//            penerbit.Name = name;

//            perpustakaan.listPenerbit.Add(penerbit);

//            SaveFile(perpustakaan);

//            //if (!File.Exists(namaFile))
//            //{
//            //    MemoryStream stream = SerializeToStream(perpustakaan);
//            //    using (FileStream file = new FileStream(namaFile, FileMode.Open, System.IO.FileAccess.Write))
//            //    {
//            //        stream.Seek(0, SeekOrigin.Begin);
//            //        stream.CopyTo(file);
//            //        file.Flush();
//            //    }
//            //}

//            Console.ReadKey();
//        }

//        private static Penerbit GetPenerbitByNama(string name)
//        {
//            var perpustakaan = OpenFile();

//            Penerbit penerbit = new Penerbit();

//            for (var i = 0; i < perpustakaan.listPenerbit.Count; i++)
//            {
//                if (perpustakaan.listPenerbit[i].Name.Contains(name))
//                {
//                    penerbit = perpustakaan.listPenerbit[i];
//                }
//            }

//            return penerbit;
//        }

//        private static void CreateBuku()
//        {
//            var perpustakaan = OpenFile();

//            Console.Clear();
//            Console.WriteLine("Create Buku");
//            Console.WriteLine("---------------");
//            Buku buku = new Buku();

//            string namaPenerbit = "";
//            var penerbit = GetPenerbitByNama(namaPenerbit);

//            Console.Write("Kode Buku : ");
//            var code = Console.ReadLine();

//            Console.Write("Nama Buku : ");
//            var nama = Console.ReadLine();

//            buku.Code = code;
//            buku.Name = nama;

//            perpustakaan.listBuku.Add(buku);

//            SaveFile(perpustakaan);

//            Console.ReadKey();
//        }

//        private static void GetAllPenerbit()
//        {
//            Console.Clear();
//            Console.WriteLine("Get All Penerbit");
//            Console.WriteLine("---------------");
//            var perpustakaan = OpenFile();

//            foreach (var itemPenerbit in perpustakaan.listPenerbit)
//            {
//                Console.WriteLine($"{itemPenerbit.Code} - {itemPenerbit.Name}");
//            }

//            Console.ReadKey();
//        }

//        private static void GetAllBuku()
//        {
//            Console.Clear();
//            Console.WriteLine("Get All Buku");
//            Console.WriteLine("---------------");

//            var perpustakaan = OpenFile();

//            foreach (var itemBuku in perpustakaan.listBuku)
//            {
//                Console.WriteLine($"{itemBuku.Code} - {itemBuku.Name} - {itemBuku.penerbit.Name}");
//            }

//            Console.ReadKey();
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

//using DecisionProject;
//using System.Runtime.InteropServices;

//namespace BelajarCollection
//{
//    class Program
//    {
//        static void Main() // Entry point
//        {
//            bool showMenu = true;
//            while (showMenu)
//            {
//                showMenu = MainMenu();
//            }
//        }

//        private static bool MainMenu()
//        {
//            Console.Clear();
//            Console.WriteLine("Choose an Option");
//            Console.WriteLine("1) Create Student");
//            Console.WriteLine("2) Update Student");
//            Console.WriteLine("3) Delete Student");
//            Console.WriteLine("4) Get All Student");
//            Console.WriteLine("5) Exit");
//            Console.Write("\r\nSelect an Option: ");

//            switch (Console.ReadLine())
//            {
//                case "1":
//                    CreateStudent();
//                    return true;
//                case "2":
//                    UpdateStudent();
//                    return true;
//                case "3":
//                    DeleteStudent();
//                    return true;
//                case "4":
//                    GetAllStudent();
//                    return true;
//                case "5":
//                    return false;
//                default:
//                    return true;
//            }
//        }

//        private static void CreateStudent()
//        {
//            Student student = new Student();
//            student.Id = 1;
//            student.Name = "Rahmi Safitri";

//            //Console.WriteLine($"{student.Id} - {student.Name}");
//            Console.ReadKey();
//        }

//        private static void UpdateStudent()
//        {

//        }

//        private static void DeleteStudent()
//        {

//        }

//        private static void GetAllStudent()
//        {
//            Student student = new Student();

//            Console.WriteLine($"{student.Id} - {student.Name}");
//            Console.ReadKey();
//        }
//    }
//}

//using System;

//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
//    }

//    public override string ToString()
//    {
//        return $"{Name},{Age}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string filePath = "c:\\Dokumen\\person.txt";

//        while (true)
//        {
//            Console.Clear();
//            Console.WriteLine("Menu:");
//            Console.WriteLine("1. Create a new person");
//            Console.WriteLine("2. Read all people");
//            Console.WriteLine("3. Update a person");
//            Console.WriteLine("4. Delete a person");
//            Console.WriteLine("5. Exit");
//            Console.Write("Enter your choice: ");
//            int choice = int.Parse(Console.ReadLine());

//            switch (choice)
//            {
//                case 1:
//                    // Create a new person
//                    Console.Write("Enter the name of the person: ");
//                    string name = Console.ReadLine();
//                    Console.Write("Enter the age of the person: ");
//                    int age = int.Parse(Console.ReadLine());
//                    Person person = new Person(name, age);
//                    using (StreamWriter writer = File.AppendText(filePath))
//                    {
//                        writer.WriteLine(person.ToString());
//                    }
//                    break;
//                case 2:
//                    // Read all people
//                    using (StreamReader reader = File.OpenText(filePath))
//                    {
//                        string line;
//                        while ((line = reader.ReadLine()) != null)
//                        {
//                            string[] parts = line.Split(',');
//                            string personName = parts[0];
//                            int personAge = int.Parse(parts[1]);
//                            Console.WriteLine($"Name: {personName}, Age: {personAge}");
//                        }
//                    }
//                    break;
//                case 3:
//                    // Update a person
//                    Console.Write("Enter the name of the person to update: ");
//                    string updateName = Console.ReadLine();
//                    Console.Write("Enter the new age of the person: ");
//                    int updateAge = int.Parse(Console.ReadLine());
//                    string tempFilePath = "c:\\Dokumen\\person_temp.txt";
//                    using (StreamReader reader = File.OpenText(filePath))
//                    using (StreamWriter writer = File.CreateText(tempFilePath))
//                    {
//                        string line;
//                        while ((line = reader.ReadLine()) != null)
//                        {
//                            string[] parts = line.Split(',');
//                            string personName = parts[0];
//                            int personAge = int.Parse(parts[1]);
//                            if (personName == updateName)
//                            {
//                                Person updatedPerson = new Person(updateName, updateAge);
//                                writer.WriteLine(updatedPerson.ToString());
//                            }
//                            else
//                            {
//                                writer.WriteLine(line);
//                            }
//                        }
//                    }
//                    File.Delete(filePath);
//                    File.Move(tempFilePath, filePath);
//                    break;
//                case 4:
//                    // Delete a person
//                    Console.Write("Enter the name of the person to delete: ");
//                    string deleteName = Console.ReadLine();
//                    string deleteTempFilePath = "c:\\Dokumen\\person_temp.txt";
//                    using (StreamReader reader = File.OpenText(filePath))
//                    using (StreamWriter writer = File.CreateText(deleteTempFilePath))
//                    {
//                        string line;
//                        while ((line = reader.ReadLine()) != null)
//                        {
//                            string[] parts = line.Split(',');
//                            string personName = parts[0];
//                            if (personName != deleteName)
//                            {
//                                writer.WriteLine(line);
//                            }
//                        }
//                    }
//                    File.Delete(filePath);
//                    File.Move(deleteTempFilePath, filePath);
//                    break;
//                case 5:
//                    // Exit
//                    return;
//            }
//        }

//    }
//}