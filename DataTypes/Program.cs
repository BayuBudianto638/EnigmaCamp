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

using Dapper;
using System.Data.SqlClient;

public class DapperORM
{
    private string sqlConnectionString = @"Data Source = YourDatabaseServerAddress;initial catalog=YourDatabaseName;user id=YourDatabaseLoginId;password=YourDatabaseLoginPassword";

    //This method gets all record from student table    
    private List<Student> GetAllStudent()
    {
        List<Student> students = new List<Student>();
        using (var connection = new SqlConnection(sqlConnectionString))
        {
            connection.Open();
            students = connection.Query<Student>("Select Id, Name, Marks from Student").ToList();
            connection.Close();
        }
        return students;
    }

    //This method inserts a student record in database    
    private int InsertStudent(Student student)
    {
        using (var connection = new SqlConnection(sqlConnectionString))
        {
            connection.Open();
            var affectedRows = connection.Execute("Insert into Student (Name, Marks) values (@Name, @Marks)",
                        new { Name = student.Name });
            connection.Close();
            return affectedRows;
        }
    }

    //This method update student record in database    
    private int UpdateStudent(Student student)
    {
        using (var connection = new SqlConnection(sqlConnectionString))
        {
            connection.Open();
            var affectedRows = connection.Execute("Update Student set Name = @Name, Marks = @Marks Where Id = @Id",
                    new { Id = student.Id, Name = student.Name });
            connection.Close();
            return affectedRows;
        }
    }

    //This method deletes a student record from database    
    private int DeleteStudent(Student student)
    {
        using (SqlConnection connection = new SqlConnection(sqlConnectionString))
        {
            connection.Open();
            var affectedRows = connection.Execute("Delete from Student Where Id = @Id", new { Id = student.Id });
            connection.Close();
            return affectedRows;
        }
    }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {

    }
}