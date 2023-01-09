//using System.Data.SqlClient;

//var sql = "select * from products";
//var products = new List<Product>();
//using (var connection = new SqlConnection(connString))
//{
//    connection.Open();
//    using (var command = new SqlCommand(sql, connection))
//    {
//        using (var reader = command.ExecuteReader())
//        {
//            var product = new Product
//            {
//                ProductId = reader.GetInt32(reader.GetOrdinal("ProductId")),
//                ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
//                SupplierId = reader.GetInt32(reader.GetOrdinal("SupplierId")),
//                CategoryId = reader.GetInt32(reader.GetOrdinal("CategoryId")),
//                QuantityPerUnit = reader.GetString(reader.GetOrdinal("QuantityPerUnit")),   
//                UnitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice")),
//                UnitsInStock = reader.GetInt16(reader.GetOrdinal("UnitsInStock")),
//                UnitsOnOrder = reader.GetInt16(reader.GetOrdinal("UnitsOnOrder")),
//                ReorderLevel = reader.GetInt16(reader.GetOrdinal("ReorderLevel")),
//                Discontinued = reader.GetBoolean(reader.GetOrdinal("Discontinued")),
//                DiscontinuedDate = reader.GetDateTime(reader.GetOrdinal("DiscontinuedDate"))
//            };
//            products.Add(product);
//        }
//    }
//}

//using Dapper;
//using DataTypes.Application;
//using System.Data.SqlClient;

//public class DapperORM
//{
//    private static string sqlConnectionString = @"Server=DESKTOP-QEO3NAA\SQLEXPRESS;Database=ShippingDB;Trusted_Connection=True;";

//    //This method gets all record from student table    
//    private static List<Student> GetAllStudent()
//    {
//        List<Student> students = new List<Student>();
//        using (var connection = new SqlConnection(sqlConnectionString))
//        {
//            connection.Open();
//            students = connection.Query<Student>("Select Id, Name from Student").ToList();
//            connection.Close();
//        }
//        return students;
//    }

//    private static Student GetById()
//    {
//        Student student = new Student();
//        var Id = 1002;
//        using (var connection = new SqlConnection(sqlConnectionString))
//        {
//            connection.Open();
//            var studentRepo = connection.Query<Student>("SELECT * FROM Student Where StudentId = @StudentId", new {StudentId = Id}).ToList();
//            student = studentRepo.FirstOrDefault();
//            connection.Close();
//        }
//        return student;
//    }

//    //This method inserts a student record in database    
//    private static int InsertStudent(Student student)
//    {
//        using (var connection = new SqlConnection(sqlConnectionString))
//        {
//            connection.Open();
//            var affectedRows = connection.Execute("Insert into Student (Name) values (@Name)",
//                        new { Name = student.Name });
//            connection.Close();
//            return affectedRows;
//        }
//    }

//    //This method update student record in database    
//    private static int UpdateStudent(Student student)
//    {
//        using (var connection = new SqlConnection(sqlConnectionString))
//        {
//            connection.Open();
//            var affectedRows = connection.Execute("Update Student set Name = @Name Where Id = @Id",
//                    new { Id = student.StudentId, Name = student.Name });
//            connection.Close();
//            return affectedRows;
//        }
//    }

//    //This method deletes a student record from database    
//    private static int DeleteStudent(Student student)
//    {
//        using (SqlConnection connection = new SqlConnection(sqlConnectionString))
//        {
//            connection.Open();
//            var affectedRows = connection.Execute("Delete from Student Where Id = @Id", new { Id = student.StudentId });
//            connection.Close();
//            return affectedRows;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            var student = new Student();
//            student.StudentId = 1001;
//            student.Name = "Anton";
//            var i = InsertStudent(student);
//        }
//    }
//}

//public class Student
//{
//    public int StudentId { get; set; }
//    public string Name { get; set; }
//}

////class Program
////{
////    static void Main()
////    {
////        var student = new Student();
////        student.StudentId = 1001;
////        student.Name = "Anton";
////        var studentRepo = new StudentRepository();
////        studentRepo.GetById(1002);
////        //studentRepo.Insert(student);
////    }
////}
///
using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace DapperExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Replace with your connection string
            string connectionString = "server=localhost;user=root;password=password;database=testdb";

            // Create a repository for students
            IStudentRepository repository = new StudentRepository(connectionString);

            // Insert a new student
            Student newStudent = new Student
            {
                Name = "John Smith",
                Age = 30,
                Gender = "Male"
            };
            repository.Insert(newStudent);

            // Select all students
            var students = repository.SelectAll();
            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
            }

            // Select a single student by ID
            Student student1 = repository.SelectById(1);
            Console.WriteLine(student1.Name);

            // Update a student
            student1.Name = "Jane Smith";
            repository.Update(student1);

            // Delete a student
            repository.Delete(1);
        }
    }

    // A simple POCO class to represent a student
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
    }

    // An interface for a student repository
    public interface IStudentRepository
    {
        void Insert(Student student);
        void Update(Student student);
        void Delete(int id);
        Student SelectById(int id);
        IEnumerable<Student> SelectAll();
    }

    // A concrete implementation of the student repository using Dapper
    public class StudentRepository : IStudentRepository
    {
        private readonly IDbConnection _connection;

        public StudentRepository(string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }

        public void Insert(Student student)
        {
            string sql = "INSERT INTO students (name, age, gender) VALUES (@Name, @Age, @Gender)";
            _connection.Execute(sql, student);
        }

        public void Update(Student student)
        {
            string sql = "UPDATE students SET name = @Name, age = @Age, gender = @Gender WHERE id = @Id";
            _connection.Execute(sql, student);
        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM students WHERE id = @Id";
            _connection.Execute(sql, new { Id = id });
        }

        public Student SelectById(int id)
        {
            string sql = "SELECT * FROM students WHERE id = @Id";
            return _connection.QuerySingle<Student>(sql, new { Id = id });
        }

        public IEnumerable<Student> SelectAll()
        {
            string sql = "SELECT * FROM students WHERE id = @Id";
            return _connection.Query<Student>(sql).AsEnumerable();
        }
    }
}
