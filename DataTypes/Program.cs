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
//        return $"Name: {Name}, Age: {Age}";
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        List<Person> people = new List<Person>();

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
//                    people.Add(person);
//                    break;
//                case 2:
//                    // Read all people
//                    foreach (Person p in people)
//                    {
//                        Console.WriteLine(p.ToString());
//                    }
//                    break;
//                case 3:
//                    // Update a person
//                    Console.Write("Enter the name of the person to update: ");
//                    string updateName = Console.ReadLine();
//                    Console.Write("Enter the new age of the person: ");
//                    int updateAge = int.Parse(Console.ReadLine());
//                    Person personToUpdate = null;
//                    foreach (Person p in people)
//                    {
//                        if (p.Name == updateName)
//                        {
//                            personToUpdate = p;
//                            break;
//                        }
//                    }
//                    if (personToUpdate != null)
//                    {
//                        personToUpdate.Age = updateAge;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Person not found.");
//                    }
//                    break;
//                case 4:
//                    // Delete a person
//                    Console.Write("Enter the name of the person to delete: ");
//                    string deleteName = Console.ReadLine();
//                    Person personToDelete = null;
//                    foreach (Person p in people)
//                    {
//                        if (p.Name == deleteName)
//                        {
//                            personToDelete = p;
//                            break;
//                        }
//                    }
//                    if (personToDelete != null)
//                    {
//                        people.Remove(personToDelete);
//                    }
//                    else
//                    {
//                        Console.WriteLine("Person not found.");
//                    }
//                    break;
//                case 5:
//                    // Exit
//                    return;
//            }
//        }
//    }
//}


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

//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myFile.txt";

//        using (FileStream stream = File.OpenWrite(filePath))
//        using (StreamWriter writer = new StreamWriter(stream))
//        {
//            // Write a list of names to the file
//            List<string> names = new List<string> { "Alice", "Bob", "Charlie" };
//            writer.WriteLine("Names:");
//            foreach (string name in names)
//            {
//                writer.WriteLine(name);
//            }

//            // Write a dictionary of phone numbers to the file
//            Dictionary<int, string> phoneNumbers = new Dictionary<int, string>
//    {
//        { 1, "Alice" },
//        { 2, "Bob" },
//        { 3, "Charlie" }
//    };
//            writer.WriteLine("Phone Numbers:");
//            foreach (KeyValuePair<int, string> entry in phoneNumbers)
//            {
//                writer.WriteLine($"{entry.Key}: {entry.Value}");
//            }
//        }

//        //string filePath = "C:\\temp\\myfile.txt";

//        //using (FileStream stream = File.OpenRead(filePath))
//        using (StreamReader reader = new StreamReader(filePath))
//        {
//            // Read the names from the file
//            List<string> names = new List<string>();
//            reader.ReadLine(); // skip the "Names:" line
//            string line;
//            while ((line = reader.ReadLine()) != null && line != "Phone Numbers:")
//            {
//                names.Add(line);
//            }

//            // Read the phone numbers from the file
//            Dictionary<int, string> phoneNumbers = new Dictionary<int, string>();
//            reader.ReadLine(); // skip the "Phone Numbers:" line
//            while ((line = reader.ReadLine()) != null)
//            {
//                string[] parts = line.Split(':');
//                int key = int.Parse(parts[0]);
//                string value = parts[1];
//                phoneNumbers.Add(key, value);
//            }

//            // Do something with the data
//            Console.WriteLine("Names:");
//            foreach (string name in names)
//            {
//                Console.WriteLine(name);
//            }
//            Console.WriteLine("Phone Numbers:");
//            foreach (KeyValuePair<int, string> entry in phoneNumbers)
//            {
//                Console.WriteLine($"{entry.Key}: {entry.Value}");
//            }
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


//using System;
//using System.IO;

//namespace MyApplication
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            // Read the contents of a file into a byte array
//            byte[] data = File.ReadAllBytes(@"C:\TestFile\myFile.txt");

//            // Get the memory address of the data
//            unsafe
//            {
//                fixed (byte* pData = data)
//                {
//                    // The pData variable now holds the memory address of the data
//                    Console.WriteLine("Memory address of the data: 0x{0:X}", (int)pData);
//                }
//            }
//        }
//    }
//}

//using System;
//using System.IO;

//namespace MyApplication
//{
//    public class Program
//    {
//        public static void Main()
//        {
//            // Open the file for reading
//            using (FileStream stream = new FileStream(@"C:\TestFile\myFile.txt", FileMode.Open, FileAccess.Read))
//            {
//                // Read the contents of the file into a byte array
//                byte[] data = new byte[stream.Length];
//                stream.Read(data, 0, data.Length);

//                // Get the memory address of the data
//                unsafe
//                {
//                    fixed (byte* pData = data)
//                    {
//                        // The pData variable now holds the memory address of the data
//                        Console.WriteLine("Memory address of the data: 0x{0:X}", (int)pData);
//                    }
//                }
//            }
//        }
//    }
//}

//string fileName = "myfile.txt";
//string appPath = AppDomain.CurrentDomain.BaseDirectory;
//string filePath = Path.Combine(appPath, fileName);

//using (StreamWriter writer = new StreamWriter(filePath))
//{
//    writer.WriteLine("Hello, world!");
//    writer.WriteLine("This is a test.");
//}

//using System.Runtime.Serialization.Formatters.Binary;

//class Program
//{
//    [Serializable]
//    public class Person
//    {
//        public string Name { get; set; }
//        public int Age { get; set; }

//        public Person(string name, int age)
//        {
//            Name = name;
//            Age = age;
//        }
//    }

//    static void Main()
//    {
//        // Save the object to a file
//        string filePath = @"C:\TestFile\myFile.txt";
//        Person person = new Person("Andik", 20); // replace this with your own method to get the Person object

//        using (FileStream stream = File.OpenWrite(filePath))
//        using (BinaryWriter writer = new BinaryWriter(stream))
//        {
//            BinaryFormatter formatter = new BinaryFormatter();
//            formatter.Serialize(writer.BaseStream, person);
//        }

//        // Load the object from the file
//        using (FileStream stream = File.OpenRead(filePath))
//        using (BinaryReader reader = new BinaryReader(stream))
//        {
//            BinaryFormatter formatter = new BinaryFormatter();
//            Person readPerson = (Person)formatter.Deserialize(reader.BaseStream);

//            Console.WriteLine($"{readPerson.Name} - {readPerson.Age}");
//        }

//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;

//namespace MyApplication
//{
//    public class Person
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public int Age { get; set; }

//        public Person(string firstName, string lastName, int age)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//            Age = age;
//        }
//    }

//    public class Program
//    {
//        private static List<Person> people = new List<Person>();
//        private static readonly string filePath = @"C:\TestFile\Person.txt";

//        public static void Main()
//        {
//            while (true)
//            {
//                Console.WriteLine("1. Create person");
//                Console.WriteLine("2. Read people");
//                Console.WriteLine("3. Update person");
//                Console.WriteLine("4. Delete person");
//                Console.WriteLine("5. Exit");
//                Console.Write("Enter your choice: ");

//                int choice = int.Parse(Console.ReadLine());
//                Console.WriteLine();

//                switch (choice)
//                {
//                    case 1:
//                        CreatePerson();
//                        break;
//                    case 2:
//                        ReadPeople();
//                        break;
//                    case 3:
//                        UpdatePerson();
//                        break;
//                    case 4:
//                        DeletePerson();
//                        break;
//                    case 5:
//                        return;
//                    default:
//                        Console.WriteLine("Invalid choice. Try again.");
//                        break;
//                }
//            }
//        }

//        private static void CreatePerson()
//        {
//            Console.Write("Enter first name: ");
//            string firstName = Console.ReadLine();

//            Console.Write("Enter last name: ");
//            string lastName = Console.ReadLine();

//            Console.Write("Enter age: ");
//            int age = int.Parse(Console.ReadLine());

//            Person person = new Person(firstName, lastName, age);
//            people.Add(person);

//            SavePeople();
//        }

//        private static void ReadPeople()
//        {
//            LoadPeople();

//            Console.WriteLine("People:");
//            foreach (Person person in people)
//            {
//                Console.WriteLine("{0} {1}, Age: {2}", person.FirstName, person.LastName, person.Age);
//            }
//        }

//        private static void UpdatePerson()
//        {
//            LoadPeople();

//            Console.Write("Enter index of person to update: ");
//            int index = int.Parse(Console.ReadLine());

//            Console.Write("Enter first name: ");
//            string firstName = Console.ReadLine();

//            Console.Write("Enter last name: ");
//            string lastName = Console.ReadLine();

//            Console.Write("Enter age: ");
//            int age = int.Parse(Console.ReadLine());

//            Person person = new Person(firstName, lastName, age);
//            people[index] = person;

//            SavePeople();
//        }
//        private static void DeletePerson()
//        {
//            LoadPeople();

//            Console.Write("Enter index of person to delete: ");
//            int index = int.Parse(Console.ReadLine());

//            people.RemoveAt(index);

//            SavePeople();
//        }

//        private static void SavePeople()
//        {
//            using (StreamWriter writer = new StreamWriter(filePath))
//            {
//                foreach (Person person in people)
//                {
//                    writer.WriteLine("{0},{1},{2}", person.FirstName, person.LastName, person.Age);
//                }
//            }
//        }

//        private static void LoadPeople()
//        {
//            people.Clear();

//            if (File.Exists(filePath))
//            {
//                using (StreamReader reader = new StreamReader(filePath))
//                {
//                    while (!reader.EndOfStream)
//                    {
//                        string line = reader.ReadLine();
//                        string[] parts = line.Split(',');

//                        string firstName = parts[0];
//                        string lastName = parts[1];
//                        int age = int.Parse(parts[2]);

//                        Person person = new Person(firstName, lastName, age);
//                        people.Add(person);
//                    }
//                }
//            }
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Runtime.Serialization.Formatters.Binary;

//namespace Library
//{
//    [Serializable]
//    public class Perpustakaan
//    {
//        public List<Buku> listBuku { get; set; }
//        public List<Penerbit> listPenerbit { get; set; }

//        public Perpustakaan()
//        {
//            listBuku = new List<Buku>();
//            listPenerbit = new List<Penerbit>();
//        }
//    }

//    [Serializable]
//    public class Penerbit
//    {
//        public string Code { get; set; }
//        public string Name { get; set; }

//        public Penerbit(string code, string name)
//        {
//            Code = code;
//            Name = name;
//        }
//    }

//    [Serializable]
//    public class Buku
//    {
//        public string Code { get; set; }
//        public string Name { get; set; }
//        public virtual Penerbit Penerbit { get; set; }

//        public Buku(string code, string name, Penerbit penerbit)
//        {
//            Code = code;
//            Name = name;
//            Penerbit = penerbit;
//        }
//    }

//    class Program
//    {
//        static Perpustakaan perpustakaan;

//        static void Main(string[] args)
//        {
//            LoadPerpustakaan();

//            int choice;
//            do
//            {
//                Console.Clear();
//                Console.WriteLine("1. View Buku");
//                Console.WriteLine("2. Add Buku");
//                Console.WriteLine("3. Update Buku");
//                Console.WriteLine("4. Delete Buku");
//                Console.WriteLine("5. View Penerbit");
//                Console.WriteLine("6. Add Penerbit");
//                Console.WriteLine("7. Update Penerbit");
//                Console.WriteLine("8. Delete Penerbit");
//                Console.WriteLine("9. Exit");
//                Console.Write("Enter choice: ");
//                choice = int.Parse(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        ViewBuku();
//                        break;
//                    case 2:
//                        CreateBuku();
//                        break;
//                    case 3:
//                        UpdateBuku();
//                        break;
//                    case 4:
//                        DeleteBuku();
//                        break;
//                    case 5:
//                        ViewPenerbit();
//                        break;
//                    case 6:
//                        CreatePenerbit();
//                        break;
//                    case 7:
//                        UpdatePenerbit();
//                        break;
//                    case 8:
//                        DeletePenerbit();
//                        break;
//                }
//            } while (choice != 9);
//        }

//        private static void LoadPerpustakaan()
//        {
//            using (FileStream fs = new FileStream("perpustakaan.dat", FileMode.OpenOrCreate))
//            {
//                BinaryFormatter formatter = new BinaryFormatter();
//                if (fs.Length > 0)
//                {
//                    perpustakaan = (Perpustakaan)formatter.Deserialize(fs);
//                }
//                else
//                {
//                    perpustakaan = new Perpustakaan();
//                }
//            }
//        }

//        private static void SavePerpustakaan()
//        {
//            using (FileStream fs = new FileStream("perpustakaan.dat", FileMode.Create))
//            {
//                BinaryFormatter formatter = new BinaryFormatter();
//                formatter.Serialize(fs, perpustakaan);
//            }
//        }

//        private static void ViewBuku()
//        {
//            Console.WriteLine("Code\tName\tPenerbit");
//            foreach (Buku buku in perpustakaan.listBuku)
//            {
//                Console.WriteLine(buku.Code + "\t" + buku.Name + "\t" + buku.Penerbit.Name);
//            }
//            Console.ReadKey();
//        }

//        private static void CreateBuku()
//        {
//            Console.Write("Enter code: ");
//            string code = Console.ReadLine();

//            Console.Write("Enter name: ");
//            string name = Console.ReadLine();

//            Console.Write("Enter penerbit code: ");
//            string penerbitCode = Console.ReadLine();

//            Penerbit penerbit = perpustakaan.listPenerbit.Find(p => p.Code == penerbitCode);
//            if (penerbit == null)
//            {
//                Console.WriteLine("Penerbit not found");
//                return;
//            }

//            Buku buku = new Buku(code, name, penerbit);
//            perpustakaan.listBuku.Add(buku);
//            SavePerpustakaan();
//        }

//        private static void UpdateBuku()
//        {
//            Console.Write("Enter code: ");
//            string code = Console.ReadLine();

//            Buku buku = perpustakaan.listBuku.Find(b => b.Code == code);
//            if (buku == null)
//            {
//                Console.WriteLine("Buku not found");
//                return;
//            }

//            Console.Write("Enter new name: ");
//            string name = Console.ReadLine();
//            buku.Name = name;

//            Console.Write("Enter new penerbit code: ");
//            string penerbitCode = Console.ReadLine();
//            Penerbit penerbit = perpustakaan.listPenerbit.Find(p => p.Code == penerbitCode);
//            if (penerbit == null)
//            {
//                Console.WriteLine("Penerbit not found");
//                return;
//            }
//            buku.Penerbit = penerbit;

//            SavePerpustakaan();
//        }

//        private static void DeleteBuku()
//        {
//            Console.Write("Enter code: ");
//            string code = Console.ReadLine();

//            Buku buku = perpustakaan.listBuku.Find(b => b.Code == code);
//            if (buku == null)
//            {
//                Console.WriteLine("Buku not found");
//                return;
//            }

//            perpustakaan.listBuku.Remove(buku);
//            SavePerpustakaan();
//        }

//        private static void ViewPenerbit()
//        {
//            Console.WriteLine("Code\tName");
//            foreach (Penerbit penerbit in perpustakaan.listPenerbit)
//            {
//                Console.WriteLine(penerbit.Code + "\t" + penerbit.Name);
//            }
//            Console.ReadKey();
//        }

//        private static void CreatePenerbit()
//        {
//            Console.Write("Enter code: ");
//            string code = Console.ReadLine();

//            Console.Write("Enter name: ");
//            string name = Console.ReadLine();

//            Penerbit penerbit = new Penerbit(code, name);
//            perpustakaan.listPenerbit.Add(penerbit);
//            SavePerpustakaan();
//        }

//        private static void UpdatePenerbit()
//        {
//            Console.Write("Enter code: ");
//            string code = Console.ReadLine();

//            Penerbit penerbit = perpustakaan.listPenerbit.Find(p => p.Code == code);
//            if (penerbit == null)
//            {
//                Console.WriteLine("Penerbit not found");
//                return;
//            }

//            Console.Write("Enter new name: ");
//            string name = Console.ReadLine();
//            penerbit.Name = name;

//            SavePerpustakaan();
//        }

//        private static void DeletePenerbit()
//        {
//            Console.Write("Enter code: ");
//            string code = Console.ReadLine();

//            Penerbit penerbit = perpustakaan.listPenerbit.Find(p => p.Code == code);
//            if (penerbit == null)
//            {
//                Console.WriteLine("Penerbit not found");
//                return;
//            }

//            perpustakaan.listPenerbit.Remove(penerbit);
//            SavePerpustakaan();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.IO;

//namespace MyApplication
//{
//    public class Person
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public int Age { get; set; }

//        public Person(string firstName, string lastName, int age)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//            Age = age;
//        }
//    }

//    public class Program
//    {
//        private static List<Person> people = new List<Person>();
//        private static readonly string filePath = @"C:\TestFile\myPersons.txt";

//        public static void Main()
//        {
//            while (true)
//            {
//                Console.Clear();
//                Console.WriteLine("1. Create person");
//                Console.WriteLine("2. Read people");
//                Console.WriteLine("3. Update person");
//                Console.WriteLine("4. Delete person");
//                Console.WriteLine("5. Exit");
//                Console.Write("Enter your choice: ");

//                int choice = int.Parse(Console.ReadLine());
//                Console.WriteLine();

//                switch (choice)
//                {
//                    case 1:
//                        CreatePerson();
//                        break;
//                    case 2:
//                        ReadPeople();
//                        break;
//                    case 3:
//                        UpdatePerson();
//                        break;
//                    case 4:
//                        DeletePerson();
//                        break;
//                    case 5:
//                        return;
//                    default:
//                        Console.WriteLine("Invalid choice. Try again.");
//                        break;
//                }
//            }
//        }

//        private static void CreatePerson()
//        {
//            Console.Write("Enter first name: ");
//            string firstName = Console.ReadLine();

//            Console.Write("Enter last name: ");
//            string lastName = Console.ReadLine();

//            Console.Write("Enter age: ");
//            int age = int.Parse(Console.ReadLine());

//            Person person = new Person(firstName, lastName, age);
//            people.Add(person);

//            SavePeople();
//        }

//        private static void ReadPeople()
//        {
//            LoadPeople();

//            Console.WriteLine("People:");
//            foreach (Person person in people)
//            {
//                Console.WriteLine("{0} {1}, Age: {2}", person.FirstName, person.LastName, person.Age);
//            }
//        }

//        private static void UpdatePerson()
//        {
//            LoadPeople();

//            Console.Write("Enter index of person to update: ");
//            int index = int.Parse(Console.ReadLine());

//            Console.Write("Enter first name: ");
//            string firstName = Console.ReadLine();

//            Console.Write("Enter last name: ");
//            string lastName = Console.ReadLine();

//            Console.Write("Enter age: ");
//            int age = int.Parse(Console.ReadLine());

//            Person person = new Person(firstName, lastName, age);
//            people[index] = person;

//            SavePeople();
//        }

//        private static void DeletePerson()
//        {
//            LoadPeople();

//            Console.Write("Enter index of person to delete: ");
//            int index = int.Parse(Console.ReadLine());

//            people.RemoveAt(index);

//            SavePeople();
//        }

//        private static void SavePeople()
//        {
//            using (StreamWriter writer = new StreamWriter(filePath))
//            {
//                foreach (Person person in people)
//                {
//                    writer.WriteLine("{0},{1},{2}", person.FirstName, person.LastName, person.Age);
//                }
//            }
//        }

//        private static void LoadPeople()
//        {
//            people.Clear();

//            if (File.Exists(filePath))
//            {
//                using (StreamReader reader = new StreamReader(filePath))
//                {
//                    while (!reader.EndOfStream)
//                    {
//                        string line = reader.ReadLine();
//                        string[] parts = line.Split(',');

//                        string firstName = parts[0];
//                        string lastName = parts[1];
//                        int age = int.Parse(parts[2]);

//                        Person person = new Person(firstName, lastName, age);
//                        people.Add(person);
//                    }
//                }
//            }
//        }
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        string filePath = @"C:\TestFile\myBinary.bin";
//        using (FileStream fs = new FileStream(filePath, FileMode.Create))
//        using (BinaryWriter bw = new BinaryWriter(fs))
//        {
//            bw.Write("Hello World");
//            bw.Write(123);
//        }

//        using (FileStream fs = new FileStream(filePath, FileMode.Open))
//        using (BinaryReader br = new BinaryReader(fs))
//        {
//            string s = br.ReadString();
//            Console.WriteLine(s);
//            int n = br.ReadInt32();
//            Console.WriteLine(n);
//        }

//    }
//}


//using System;
//using System.IO;

//namespace MyApplication
//{
//    public class Person
//    {
//        public string FirstName { get; set; }
//        public string LastName { get; set; }
//        public int Age { get; set; }

//        public Person(string firstName, string lastName, int age)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//            Age = age;
//        }
//    }

//    public class Program
//    {
//        private static readonly string filePath = "C:\\MyPeople.txt";

//        public static void Main()
//        {
//            // Save the person to the file
//            Person person = new Person("John", "Doe", 30);
//            SavePerson(person);

//            // Read the person from the file
//            Person readPerson = ReadPerson();
//            Console.WriteLine("{0} {1}, Age: {2}", readPerson.FirstName, readPerson.LastName, readPerson.Age);
//        }

//        private static void SavePerson(Person person)
//        {
//            using (FileStream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
//            using (StreamWriter writer = new StreamWriter(stream))
//            {
//                string line = string.Format("{0},{1},{2}", person.FirstName, person.LastName, person.Age);
//                writer.WriteLine(line);
//            }
//        }

//        private static Person ReadPerson()
//        {
//            using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
//            using (StreamReader reader = new StreamReader(stream))
//            {
//                string line = reader.ReadLine();
//                string[] parts = line.Split(',');

//                string firstName = parts[0];
//                string lastName = parts[1];
//                int age = int.Parse(parts[2]);

//                Person person = new Person(firstName, lastName, age);
//                return person;
//            }
//        }
//    }
//}

//using System;

//public class Perpustakaan
//{
//    public List<Buku> listBuku { get; set; }
//    public List<Penerbit> listPenerbit { get; set; }
//}

//public class Penerbit
//{
//    public string Code { get; set; }
//    public string Name { get; set; }
//}

//public class Buku
//{
//    public string Code { get; set; }
//    public string Name { get; set; }
//    public Penerbit Penerbit { get; set; }
//}

//class Program
//{
//    private static readonly string filePath = @"C:\TestFile\perpustakaan.txt";
//    private static Perpustakaan perpustakaan;

//    static void Main(string[] args)
//    {
//        perpustakaan = LoadPerpustakaan();

//        int option;
//        do
//        {
//            Console.Clear();
//            Console.WriteLine("1. View Buku");
//            Console.WriteLine("2. Create Buku");
//            Console.WriteLine("3. Update Buku");
//            Console.WriteLine("4. Delete Buku");
//            Console.WriteLine("5. View Penerbit");
//            Console.WriteLine("6. Create Penerbit");
//            Console.WriteLine("7. Update Penerbit");
//            Console.WriteLine("8. Delete Penerbit");
//            Console.WriteLine("9. Exit");
//            Console.Write("Enter option: ");
//            option = int.Parse(Console.ReadLine());

//            switch (option)
//            {
//                case 1:
//                    ViewBuku();
//                    break;
//                case 2:
//                    CreateBuku();
//                    break;
//                case 3:
//                    UpdateBuku();
//                    break;
//                case 4:
//                    DeleteBuku();
//                    break;
//                case 5:
//                    ViewPenerbit();
//                    break;
//                case 6:
//                    CreatePenerbit();
//                    break;
//                case 7:
//                    UpdatePenerbit();
//                    break;
//                case 8:
//                    DeletePenerbit();
//                    break;
//            }
//        } while (option != 9);

//        SavePerpustakaan();
//    }

//    private static void SavePerpustakaan()
//    {
//        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
//        using (StreamWriter sw = new StreamWriter(fs))
//        {
//            foreach (Buku buku in perpustakaan.listBuku)
//            {
//                sw.WriteLine("B|" + buku.Code + "|" + buku.Name + "|" + buku.Penerbit.Code);
//            }

//            foreach (Penerbit penerbit in perpustakaan.listPenerbit)
//            {
//                sw.WriteLine("P|" + penerbit.Code + "|" + penerbit.Name);
//            }
//        }
//    }


//    private static Perpustakaan LoadPerpustakaan()
//    {
//        Perpustakaan perpustakaan = new Perpustakaan();
//        perpustakaan.listBuku = new List<Buku>();
//        perpustakaan.listPenerbit = new List<Penerbit>();

//        if (!File.Exists(filePath))
//        {
//            return perpustakaan;
//        }

//        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
//        using (StreamReader sr = new StreamReader(fs))
//        {
//            string line;
//            while ((line = sr.ReadLine()) != null)
//            {
//                string[] parts = line.Split('|');
//                if (parts[0] == "B")
//                {
//                    Buku buku = new Buku();
//                    buku.Code = parts[1];
//                    buku.Name = parts[2];
//                    foreach (Penerbit p in perpustakaan.listPenerbit)
//                    {
//                        if (p.Code == parts[3])
//                        {
//                            buku.Penerbit = p;
//                            break;
//                        }
//                    }
//                    perpustakaan.listBuku.Add(buku);
//                }
//                else if (parts[0] == "P")
//                {
//                    Penerbit penerbit = new Penerbit();
//                    penerbit.Code = parts[1];
//                    penerbit.Name = parts[2];
//                    perpustakaan.listPenerbit.Add(penerbit);
//                }
//            }
//        }

//        return perpustakaan;
//    }


//    private static void ViewBuku()
//    {
//        Console.WriteLine("Code\tName\tPenerbit");
//        foreach (Buku buku in perpustakaan.listBuku)
//        {
//            Console.WriteLine(buku.Code + "\t" + buku.Name + "\t" + buku.Penerbit.Name);
//        }
//        Console.ReadKey();
//    }

//    private static void CreateBuku()
//    {
//        Console.Write("Enter code: ");
//        string code = Console.ReadLine();

//        Console.Write("Enter name: ");
//        string name = Console.ReadLine();

//        Console.Write("Enter penerbit code: ");
//        string penerbitCode = Console.ReadLine();

//        Penerbit penerbit = null;
//        foreach (Penerbit p in perpustakaan.listPenerbit)
//        {
//            if (p.Code == penerbitCode)
//            {
//                penerbit = p;
//                break;
//            }
//        }
//        if (penerbit == null)
//        {
//            Console.WriteLine("Penerbit not found");
//            return;
//        }

//        Buku buku = new Buku();
//        buku.Code = code;
//        buku.Name = name;
//        buku.Penerbit = penerbit;
//        perpustakaan.listBuku.Add(buku);
//        SavePerpustakaan();
//    }

//    private static void UpdateBuku()
//    {
//        Console.Write("Enter code: ");
//        string code = Console.ReadLine();

//        Buku buku = null;
//        for (int i = 0; i < perpustakaan.listBuku.Count; i++)
//        {
//            if (perpustakaan.listBuku[i].Code == code)
//            {
//                buku = perpustakaan.listBuku[i];
//                break;
//            }
//        }
//        if (buku == null)
//        {
//            Console.WriteLine("Buku not found");
//            return;
//        }

//        Console.Write("Enter new name: ");
//        string name = Console.ReadLine();
//        buku.Name = name;

//        Console.Write("Enter new penerbit code: ");
//        string penerbitCode = Console.ReadLine();
//        Penerbit penerbit = null;
//        for (int i = 0; i < perpustakaan.listPenerbit.Count; i++)
//        {
//            if (perpustakaan.listPenerbit[i].Code == penerbitCode)
//            {
//                penerbit = perpustakaan.listPenerbit[i];
//                break;
//            }
//        }
//        if (penerbit == null)
//        {
//            Console.WriteLine("Penerbit not found");
//            return;
//        }
//        buku.Penerbit = penerbit;

//        SavePerpustakaan();
//    }


//    private static void DeleteBuku()
//    {
//        Console.Write("Enter code: ");
//        string code = Console.ReadLine();

//        Buku buku = null;
//        for (int i = 0; i < perpustakaan.listBuku.Count; i++)
//        {
//            if (perpustakaan.listBuku[i].Code == code)
//            {
//                buku = perpustakaan.listBuku[i];
//                break;
//            }
//        }
//        if (buku == null)
//        {
//            Console.WriteLine("Buku not found");
//            return;
//        }

//        perpustakaan.listBuku.Remove(buku);
//        SavePerpustakaan();
//    }


//    private static void ViewPenerbit()
//    {
//        Console.WriteLine("Code\tName");
//        foreach (Penerbit penerbit in perpustakaan.listPenerbit)
//        {
//            Console.WriteLine(penerbit.Code + "\t" + penerbit.Name);
//        }
//        Console.ReadKey();
//    }

//    private static void CreatePenerbit()
//    {
//        Console.Write("Enter code: ");
//        string code = Console.ReadLine();

//        Console.Write("Enter name: ");
//        string name = Console.ReadLine();

//        Penerbit penerbit = new Penerbit();
//        penerbit.Code = code;
//        penerbit.Name = name;
//        perpustakaan.listPenerbit.Add(penerbit);
//    }

//    private static void UpdatePenerbit()
//    {
//        Console.Write("Enter code: ");
//        string code = Console.ReadLine();

//        Penerbit penerbit = null;
//        for (int i = 0; i < perpustakaan.listPenerbit.Count; i++)
//        {
//            if (perpustakaan.listPenerbit[i].Code == code)
//            {
//                penerbit = perpustakaan.listPenerbit[i];
//                break;
//            }
//        }
//        if (penerbit == null)
//        {
//            Console.WriteLine("Penerbit not found");
//            return;
//        }

//        Console.Write("Enter new name: ");
//        penerbit.Name = Console.ReadLine();
//    }


//    private static void DeletePenerbit()
//    {
//        Console.Write("Enter code: ");
//        string code = Console.ReadLine();

//        Penerbit penerbit = null;
//        for (int i = 0; i < perpustakaan.listPenerbit.Count; i++)
//        {
//            if (perpustakaan.listPenerbit[i].Code == code)
//            {
//                penerbit = perpustakaan.listPenerbit[i];
//                break;
//            }
//        }
//        if (penerbit == null)
//        {
//            Console.WriteLine("Penerbit not found");
//            return;
//        }

//        perpustakaan.listPenerbit.Remove(penerbit);
//    }
//}

using System;
using System.IO;
using System.Collections.Generic;

// Define the Perpustakaan, Penerbit, and Buku classes
public class Perpustakaan
{
    public List<Buku> listBuku { get; set; }
    public List<Penerbit> listPenerbit { get; set; }
}

public class Penerbit
{
    public string Code { get; set; }
    public string Name { get; set; }
}

public class Buku
{
    public string Code { get; set; }
    public string Name { get; set; }
    public Penerbit Penerbit { get; set; }
}

// Define an interface for objects that can be saved to a file
public interface IFileSaver
{
    void SaveToFile(string filePath, Perpustakaan perpustakaan);
}

// Define an abstract class for objects that can be loaded from a file
public abstract class IFileLoader
{
    public abstract Perpustakaan LoadFromFile(string filePath);
}

// Define a class for reading and writing Perpustakaan objects to and from a file
public class PerpustakaanFile : IFileLoader, IFileSaver
{
    public void SaveToFile(string filePath, Perpustakaan perpustakaan)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        using (StreamWriter sw = new StreamWriter(fs))
        {      
            foreach (Penerbit penerbit in perpustakaan.listPenerbit)
            {
                sw.WriteLine("P|" + penerbit.Code + "|" + penerbit.Name);
            }

            foreach (Buku buku in perpustakaan.listBuku)
            {
                sw.WriteLine("B|" + buku.Code + "|" + buku.Name + "|" + buku.Penerbit.Code);
            }
        }
    }

    public override Perpustakaan LoadFromFile(string filePath)
    {
        Perpustakaan perpustakaan = new Perpustakaan();
        perpustakaan.listBuku = new List<Buku>();
        perpustakaan.listPenerbit = new List<Penerbit>();

        if (!File.Exists(filePath))
        {
            return perpustakaan;
        }

        using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
        using (StreamReader sr = new StreamReader(fs))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split('|');
                if (parts[0] == "P")
                {
                    Penerbit penerbit = new Penerbit();
                    penerbit.Code = parts[1];
                    penerbit.Name = parts[2];
                    perpustakaan.listPenerbit.Add(penerbit);
                }
                else if (parts[0] == "B")
                {
                    Buku buku = new Buku();
                    buku.Code = parts[1];
                    buku.Name = parts[2];
                    foreach (Penerbit p in perpustakaan.listPenerbit)
                    {
                        if (p.Code == parts[3])
                        {
                            buku.Penerbit = p;
                            break;
                        }
                    }
                    perpustakaan.listBuku.Add(buku);
                }

            }
        }

        return perpustakaan;

    }
}

class Program
{
    private static readonly string filePath = @"C:\TestFile\perpustakaan.txt";
    private static readonly PerpustakaanFile perpustakaanFile = new PerpustakaanFile();

    static void Main(string[] args)
    {
        Perpustakaan perpustakaan = perpustakaanFile.LoadFromFile(filePath);

        int option;
        do
        {
            Console.Clear();
            Console.WriteLine("1. View Buku");
            Console.WriteLine("2. Create Buku");
            Console.WriteLine("3. Update Buku");
            Console.WriteLine("4. Delete Buku");
            Console.WriteLine("5. View Penerbit");
            Console.WriteLine("6. Create Penerbit");
            Console.WriteLine("7. Update Penerbit");
            Console.WriteLine("8. Delete Penerbit");
            Console.WriteLine("9. Exit");
            Console.Write("Enter option: ");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ViewBuku(perpustakaan);
                    break;
                case 2:
                    CreateBuku(perpustakaan);
                    break;
                case 3:
                    UpdateBuku(perpustakaan);
                    break;
                case 4:
                    DeleteBuku(perpustakaan);
                    break;
                case 5:
                    ViewPenerbit(perpustakaan);
                    break;
                case 6:
                    CreatePenerbit(perpustakaan);
                    break;
                case 7:
                    UpdatePenerbit(perpustakaan);
                    break;
                case 8:
                    DeletePenerbit(perpustakaan);
                    break;
            }
        } while (option != 9);

        perpustakaanFile.SaveToFile(filePath, perpustakaan);
    }

    private static void ViewBuku(Perpustakaan perpustakaan)
    {
        Console.WriteLine("Code\tName\tPenerbit");
        foreach (Buku buku in perpustakaan.listBuku)
        {
            Console.WriteLine(buku.Code + "\t" + buku.Name + "\t" + buku.Penerbit.Name);
        }
        Console.ReadKey();
    }

    private static void CreateBuku(Perpustakaan perpustakaan)
    {
        Console.Write("Enter code: ");
        string code = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter penerbit code: ");
        string penerbitCode = Console.ReadLine();

        Penerbit penerbit = null;
        foreach (Penerbit p in perpustakaan.listPenerbit)
        {
            if (p.Code == penerbitCode)
            {
                penerbit = p;
                break;
            }
        }
        if (penerbit == null)
        {
            Console.WriteLine("Penerbit not found");
            return;
        }

        Buku buku = new Buku();
        buku.Code = code;
        buku.Name = name;
        buku.Penerbit = penerbit;
        perpustakaan.listBuku.Add(buku);
        perpustakaanFile.SaveToFile(filePath, perpustakaan);
    }

    private static void UpdateBuku(Perpustakaan perpustakaan)
    {
        Console.Write("Enter code: ");
        string code = Console.ReadLine();

        Buku buku = null;
        for (int i = 0; i < perpustakaan.listBuku.Count; i++)
        {
            if (perpustakaan.listBuku[i].Code == code)
            {
                buku = perpustakaan.listBuku[i];
                break;
            }
        }
        if (buku == null)
        {
            Console.WriteLine("Buku not found");
            return;
        }

        Console.Write("Enter new name: ");
        string name = Console.ReadLine();
        buku.Name = name;

        Console.Write("Enter new penerbit code: ");
        string penerbitCode = Console.ReadLine();
        Penerbit penerbit = null;
        for (int i = 0; i < perpustakaan.listPenerbit.Count; i++)
        {
            if (perpustakaan.listPenerbit[i].Code == penerbitCode)
            {
                penerbit = perpustakaan.listPenerbit[i];
                break;
            }
        }
        if (penerbit == null)
        {
            Console.WriteLine("Penerbit not found");
            return;
        }
        buku.Penerbit = penerbit;

        perpustakaanFile.SaveToFile(filePath, perpustakaan);
    }


    private static void DeleteBuku(Perpustakaan perpustakaan)
    {
        Console.Write("Enter code: ");
        string code = Console.ReadLine();

        Buku buku = null;
        for (int i = 0; i < perpustakaan.listBuku.Count; i++)
        {
            if (perpustakaan.listBuku[i].Code == code)
            {
                buku = perpustakaan.listBuku[i];
                break;
            }
        }
        if (buku == null)
        {
            Console.WriteLine("Buku not found");
            return;
        }

        perpustakaan.listBuku.Remove(buku);
        perpustakaanFile.SaveToFile(filePath, perpustakaan);
    }


    private static void ViewPenerbit(Perpustakaan perpustakaan)
    {
        Console.WriteLine("Code\tName");
        foreach (Penerbit penerbit in perpustakaan.listPenerbit)
        {
            Console.WriteLine(penerbit.Code + "\t" + penerbit.Name);
        }
        Console.ReadKey();
    }

    private static void CreatePenerbit(Perpustakaan perpustakaan)
    {
        Console.Write("Enter code: ");
        string code = Console.ReadLine();

        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Penerbit penerbit = new Penerbit();
        penerbit.Code = code;
        penerbit.Name = name;
        perpustakaan.listPenerbit.Add(penerbit);
        perpustakaanFile.SaveToFile(filePath, perpustakaan);
    }

    private static void UpdatePenerbit(Perpustakaan perpustakaan)
    {
        Console.Write("Enter code: ");
        string code = Console.ReadLine();

        Penerbit penerbit = null;
        for (int i = 0; i < perpustakaan.listPenerbit.Count; i++)
        {
            if (perpustakaan.listPenerbit[i].Code == code)
            {
                penerbit = perpustakaan.listPenerbit[i];
                break;
            }
        }
        if (penerbit == null)
        {
            Console.WriteLine("Penerbit not found");
            return;
        }

        Console.Write("Enter new name: ");
        penerbit.Name = Console.ReadLine();
    }


    private static void DeletePenerbit(Perpustakaan perpustakaan)
    {
        Console.Write("Enter code: ");
        string code = Console.ReadLine();

        Penerbit penerbit = null;
        for (int i = 0; i < perpustakaan.listPenerbit.Count; i++)
        {
            if (perpustakaan.listPenerbit[i].Code == code)
            {
                penerbit = perpustakaan.listPenerbit[i];
                break;
            }
        }
        if (penerbit == null)
        {
            Console.WriteLine("Penerbit not found");
            return;
        }

        perpustakaan.listPenerbit.Remove(penerbit);
    }
}