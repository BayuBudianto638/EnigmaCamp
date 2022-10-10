//// DB using Class

//class DBUsingClass
//{
//    public class Person
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Address { get; set; }
//    }

//    static void Main()
//    {
//        Person person = new Person();
//        person.Id = 10;
//        person.Name = "Itachi Uchiha";
//        person.Address = "Konoha";

//        Console.WriteLine($"{person.Id} - {person.Name} - {person.Address}");
//    }
//}

//class DBUsingClass
//{
//    public class Person
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Address { get; set; }
//    }

//    static void Main()
//    {
//        List<Person> listPerson = new List<Person>();

//        Person person_1 = new Person();
//        person_1.Id = 10;
//        person_1.Name = "Itachi Uchiha";
//        person_1.Address = "Konoha";
//        listPerson.Add(person_1);

//        Person person_2 = new Person();
//        person_2.Id = 11;
//        person_2.Name = "Madara Uchiha";
//        person_2.Address = "Konoha";
//        listPerson.Add(person_2);

//        Person person_3 = new Person();
//        person_3.Id = 12;
//        person_3.Name = "Sasuke Uchiha";
//        person_3.Address = "Konoha";
//        listPerson.Add(person_3);

//        foreach (var item in listPerson)
//        {
//            Console.WriteLine($"{item.Id} - {item.Name} - {item.Address}");
//        }
//    }
//}

// The example creates a file named "Test.data" and writes the integers 0 through 10 to it in binary format.
// It then writes the contents of Test.data to the console with each integer on a separate line.


////// CONTOH 1
////// CREATE DATABASE VIA ADO.NET
////using System;
////using System.Data.SqlClient;
////using System.Xml.Linq;

////namespace EnigmaCampADONetConsole
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            new Program().CreateTable();
////        }
////        public void CreateTable()
////        {
////            SqlConnection con = null;
////            try
////            {
////                // Creating Connection  
////                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");
////                // writing sql query  
////                SqlCommand cm = new SqlCommand(@"create table student(studentId int not null,   
////                name varchar(100))", con);  
////                // Opening Connection  
////                con.Open();
////                // Executing the SQL query  
////                cm.ExecuteNonQuery();
////                // Displaying a message  
////                Console.WriteLine("Table created Successfully");
////            }
////            catch (Exception e)
////            {
////                Console.WriteLine("OOPs, something went wrong." + e);
////            }
////            // Closing the connection  
////            finally
////            {
////                con.Close();
////            }
////        }
////    }
////}


//// CONTOH 2
//// INSERT TABLE VIA ADO.NET
////using System;
////using System.Data.SqlClient;
////using System.Xml.Linq;

////namespace EnigmaCampADONetConsole
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            new Program().CreateTable();
////        }
////        public void CreateTable()
////        {
////            SqlConnection con = null;
////            try
////            {
////                // Creating Connection  
////                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");
////                // writing sql query  
////                SqlCommand cm = new SqlCommand(@"insert into student  
////                (studentid, name)values('101', 'Ronald Trump')", con);
////                // Opening Connection  
////                con.Open();
////                // Executing the SQL query  
////                cm.ExecuteNonQuery();
////                // Displaying a message  
////                Console.WriteLine("Record Inserted Successfully");
////            }
////            catch (Exception e)
////            {
////                Console.WriteLine("OOPs, something went wrong." + e);
////            }
////            // Closing the connection  
////            finally
////            {
////                con.Close();
////            }
////        }
////    }
////}

//// CONTOH 3
//// Get Data via ADONET
//using System;
//using System.Data.SqlClient;
//namespace EnigmaCampADONetConsole
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            new Program().CreateTable();
//        }
//        public void CreateTable()
//        {
//            SqlConnection con = null;
//            SqlTransaction sqlTransaction = null;
//            try
//            {
//                // Creating Connection  
//                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");

//                sqlTransaction = con.BeginTransaction();
//                // writing sql query  
//                SqlCommand cm = new SqlCommand("Select * from student", con);
//                // Opening Connection  
//                con.Open();
//                // Executing the SQL query  
//                SqlDataReader sdr = cm.ExecuteReader();
//                sqlTransaction.Commit();

//                // Iterating Data  
//                while (sdr.Read())
//                {
//                    Console.WriteLine(sdr["id"] + " " + sdr["name"] + " "); // Displaying Record  
//                }
//            }
//            catch (Exception e)
//            {
//                sqlTransaction.Rollback();
//                Console.WriteLine("OOPs, something went wrong.\n" + e);
//            }
//            // Closing the connection  
//            finally
//            {
//                con.Close();
//            }
//        }
//    }
//}


////// CONTOH 4
////// Menghapus Data
////using System;
////using System.Data.SqlClient;
////namespace EnigmaCampADONetConsole
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            new Program().CreateTable();
////        }
////        public void CreateTable()
////        {
////            SqlConnection con = null;
////            try
////            {
////                // Creating Connection  
////                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");
////                // writing sql query  
////                SqlCommand cm = new SqlCommand("delete from student where id = '101'", con);
////                // Opening Connection  
////                con.Open();
////                // Executing the SQL query  
////                cm.ExecuteNonQuery();
////                Console.WriteLine("Record Deleted Successfully");
////            }
////            catch (Exception e)
////            {
////                Console.WriteLine("OOPs, something went wrong.\n" + e);
////            }
////            // Closing the connection  
////            finally
////            {
////                con.Close();
////            }
////        }
////    }
////}

//// CONTOH 5
//// SQL Connection
////using System;
////using System.Data.SqlClient;
////namespace EnigmaCampADONetConsole
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            new Program().Connecting();
////        }
////        public void Connecting()
////        {
////            using (
////                     // Creating Connection  
////                     SqlConnection con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI")
////                 )
////            {
////                con.Open();
////                Console.WriteLine("Connection Established Successfully");
////            }
////        }
////    }
////}

//// CONTOH 6
//// SQLConnection
////using System;
////using System.Data.SqlClient;
////namespace EnigmaCampADONetConsole
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            new Program().Connecting();
////        }
////        public void Connecting()
////        {
////            SqlConnection con = null;
////            try
////            {
////                // Creating Connection  
////                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");
////                con.Open();
////                Console.WriteLine("Connection Established Successfully");
////            }
////            catch (Exception e)
////            {
////                Console.WriteLine("OOPs, something went wrong.\n" + e);
////            }
////            finally
////            {   // Closing the connection  
////                con.Close();
////            }
////        }
////    }
////}

////// CONTOH 7
////using System;
////using System.Data.SqlClient;
////namespace EnigmaCampADONetConsole
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            new Program().CreateTable();
////        }
////        public void CreateTable()
////        {
////            SqlConnection con = null;
////            try
////            {
////                // Creating Connection  
////                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");
////                // writing sql query  
////                SqlCommand cm = new SqlCommand("select * from student", con);
////                // Opening Connection  
////                con.Open();
////                // Executing the SQL query  
////                SqlDataReader sdr = cm.ExecuteReader();
////                while (sdr.Read())
////                {
////                    Console.WriteLine(sdr["name"] + " " + sdr["email"]);
////                }
////            }
////            catch (Exception e)
////            {
////                Console.WriteLine("OOPs, something went wrong." + e);
////            }
////            // Closing the connection  
////            finally
////            {
////                con.Close();
////            }
////        }
////    }
////}

//// CONTOH 8
////using System;
////using System.Data.SqlClient;
////namespace EnigmaCampADONetConsole
////{
////    class Program
////    {
////        static void Main(string[] args)
////        {
////            new Program().GetData();
////        }
////        public void GetData()
////        {
////            SqlConnection con = null;
////            try
////            {
////                // Creating Connection  
////                con = new SqlConnection("data source=---NAMA LOCALHOST---; database=student; integrated security=SSPI");
////                // writing sql query  
////                SqlCommand cm = new SqlCommand("select * from student", con);
////                // Opening Connection  
////                con.Open();
////                // Executing the SQL query  
////                SqlDataReader sdr = cm.ExecuteReader();
////                while (sdr.Read())
////                {
////                    Console.WriteLine(sdr["name"] + " " + sdr["email"]);
////                }
////            }
////            catch (Exception e)
////            {
////                Console.WriteLine("OOPs, something went wrong." + e);
////            }
////            // Closing the connection  
////            finally
////            {
////                con.Close();
////            }
////        }
////    }
////}

////CONTOH 9
////DATASET
//using System;
//using System.Data.SqlClient;
//using System.Data;
//namespace DataSetExample
//{
//    class sqlDataAdapter
//    {
//        static void Main()
//        {
//            using (SqlConnection con = new SqlConnection("data source=.; database=student; integrated security=SSPI"))
//            {
//                SqlDataAdapter sde = new SqlDataAdapter("Select * from student", con);
//                DataSet ds = new DataSet();
//                sde.Fill(ds);

//                Console.WriteLine("Using Data Table");
//                foreach (DataRow row in ds.Tables["student"].Rows)
//                {
//                    Console.WriteLine(row["StudentId"] + ",  " + row["Name"] + ",  " + row["Address"] + ",  " + row["Country"]);
//                }
//            }
//        }
//    }
//}

//// CONTOH11
//// DATATABLE
//using System;
//using System.Data;
//using System.Data.SqlClient;
//namespace AdoNetConsoleApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                string ConString = "data source=.; database=StudentDB; integrated security=SSPI";
//                using (SqlConnection connection = new SqlConnection(ConString))
//                {
//                    SqlDataAdapter da = new SqlDataAdapter("select * from students", connection);

//                    //Using Data Table
//                    DataTable dt = new DataTable();
//                    da.Fill(dt);
//                    Console.WriteLine("Using Data Table");
//                    foreach (DataRow row in dt.Rows)
//                    {
//                        Console.WriteLine(row["StudentId"] + ",  " + row["Name"] + ",  " + row["Address"] + ",  " + row["Country"]);
//                    }
//                    Console.WriteLine("---------------");
//                    //Using DataSet
//                    DataSet ds = new DataSet();
//                    da.Fill(ds, "student");
//                    Console.WriteLine("Using Data Set");
//                    foreach (DataRow row in ds.Tables["students"].Rows)
//                    {
//                        Console.WriteLine(row["StudentId"] + ",  " + row["Name"] + ",  " + row["Address"] + ",  " + row["Country"]);
//                    }
//                }
//            }
//            catch (Exception e)
//            {
//                Console.WriteLine("OOPs, something went wrong.\n" + e);
//            }
//            Console.ReadKey();
//        }
//    }
//}
