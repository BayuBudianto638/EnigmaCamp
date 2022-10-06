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

using System;
using System.IO;

class MyStream
{
    private const string FILE_NAME = "Test.data";

    public static void Main()
    {
        if (File.Exists(FILE_NAME))
        {
            Console.WriteLine($"{FILE_NAME} already exists!");
            return;
        }

        using (FileStream fs = new FileStream(FILE_NAME, FileMode.CreateNew))
        {
            using (BinaryWriter w = new BinaryWriter(fs))
            {
                for (int i = 0; i < 11; i++)
                {
                    w.Write(i);
                }
            }
        }

        using (FileStream fs = new FileStream(FILE_NAME, FileMode.Open, FileAccess.Read))
        {
            using (BinaryReader r = new BinaryReader(fs))
            {
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(r.ReadInt32());
                }
            }
        }
    }
}


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

//// CONTOH 9
////// DATASET
////using System;
////using System.Data.SqlClient;
////using System.Data;
////namespace DataSetExample
////{
////    public partial class DataSetDemo : System.Web.UI.Page
////    {
////        protected void Page_Load(object sender, EventArgs e)
////        {
////            using (SqlConnection con = new SqlConnection("data source=.; database=student; integrated security=SSPI"))
////            {
////                SqlDataAdapter sde = new SqlDataAdapter("Select * from student", con);
////                DataSet ds = new DataSet();
////                sde.Fill(ds);
////                GridView1.DataSource = ds;
////                GridView1.DataBind();
////            }
////        }
////    }
////}

//// CONTOH 10
//// DataAdapter
////using System;
////using System.Data.SqlClient;
////using System.Data;
////namespace DataSetExample
////{
////    public partial class DataSetDemo : System.Web.UI.Page
////    {
////        protected void Page_Load(object sender, EventArgs e)
////        {
////            using (SqlConnection con = new SqlConnection("data source=.; database=student; integrated security=SSPI"))
////            {
////                SqlDataAdapter sde = new SqlDataAdapter("Select * from student", con);
////                DataSet ds = new DataSet();
////                sde.Fill(ds);
////                GridView1.DataSource = ds;
////                GridView1.DataBind();
////            }
////        }
////    }
////}

////// CONTOH11
////// DATATABLE
////using System;
////using System.Collections.Generic;
////using System.Data;
////using System.Linq;
////using System.Web;
////using System.Web.UI;
////using System.Web.UI.WebControls;
////namespace DataTableDemo
////{
////    public partial class DataTableForm : System.Web.UI.Page
////    {
////        protected void Page_Load(object sender, EventArgs e)
////        {
////            DataTable table = new DataTable();
////            table.Columns.Add("ID");
////            table.Columns.Add("Name");
////            table.Columns.Add("Email");
////            table.Rows.Add("101", "Rameez", "rameez@example.com");
////            table.Rows.Add("102", "Sam Nicolus", "sam@example.com");
////            table.Rows.Add("103", "Subramanium", "subramanium@example.com");
////            table.Rows.Add("104", "Ankur Kumar", "ankur@example.com");
////            GridView1.DataSource = table;
////            GridView1.DataBind();
////        }
////    }
////}