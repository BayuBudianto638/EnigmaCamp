using System.Data.SqlClient;

var sql = "select * from products";
var products = new List<Product>();
using (var connection = new SqlConnection(connString))
{
    connection.Open();
    using (var command = new SqlCommand(sql, connection))
    {
        using (var reader = command.ExecuteReader())
        {
            var product = new Product
            {
                ProductId = reader.GetInt32(reader.GetOrdinal("ProductId")),
                ProductName = reader.GetString(reader.GetOrdinal("ProductName")),
                SupplierId = reader.GetInt32(reader.GetOrdinal("SupplierId")),
                CategoryId = reader.GetInt32(reader.GetOrdinal("CategoryId")),
                QuantityPerUnit = reader.GetString(reader.GetOrdinal("QuantityPerUnit")),   
                UnitPrice = reader.GetDecimal(reader.GetOrdinal("UnitPrice")),
                UnitsInStock = reader.GetInt16(reader.GetOrdinal("UnitsInStock")),
                UnitsOnOrder = reader.GetInt16(reader.GetOrdinal("UnitsOnOrder")),
                ReorderLevel = reader.GetInt16(reader.GetOrdinal("ReorderLevel")),
                Discontinued = reader.GetBoolean(reader.GetOrdinal("Discontinued")),
                DiscontinuedDate = reader.GetDateTime(reader.GetOrdinal("DiscontinuedDate"))
            };
            products.Add(product);
        }
    }
}