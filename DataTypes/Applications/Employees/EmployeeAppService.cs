using DataTypes.Applications.Employees.Dto;
using DataTypes.SqlServices;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataTypes.Applications.Employees
{
    public class EmployeeAppService : IEmployeeAppService
    {
        string strConn = ConfigurationManager.AppSettings["countoffiles"];
        private Connection _connection;
        private SqlConnection _sqlConnection;
        private SqlCommands _sqlCommands;
        private SqlTransaction _sqlTransaction;
        public EmployeeAppService(
            SqlConnection sqlConnection
            )
        {
            _connection = new Connection(strConn);
            _sqlConnection = sqlConnection;
            _sqlConnection.ConnectionString = _connection.ConnectionString;
        }

        public void DeleteEmp(string id)
        {
            SqlTransaction _sqlTransaction;

            try
            {
                _sqlTransaction = _sqlConnection.BeginTransaction();
                var data = _sqlCommands.ExecuteNonQuery("DELETE statement");
                _sqlConnection.Open();
                _sqlTransaction.Commit();
            }
            catch (DbException dbex)
            {
                //_sqlTransaction.Rollback();
            }
        }

        public List<EmployeeDto> GetAllEmployee()
        {
            var listEmployee = new List<EmployeeDto>();

            _sqlConnection.Open();
            _sqlTransaction = _sqlConnection.BeginTransaction();
            _sqlCommands = new SqlCommands(_sqlConnection, _sqlTransaction, 10000);

            var data = _sqlCommands.ExecuteReader("SELECT * FROM Employee");

            SqlDataReader dataReader = data;
            foreach (var item in dataReader)
            {
                var employee = new EmployeeDto();
                // VALUE HERE
                listEmployee.Add(employee);
            }

            return listEmployee;
        }

        public EmployeeDto GetById(string id)
        {
            var employee = new EmployeeDto();
            var data = _sqlCommands.ExecuteReader("SELECT * FROM Employee");
            _sqlConnection.Open();
            SqlDataReader dataReader = data;
            foreach (var item in dataReader)
            {
                // VALUE HERE
            }

            return employee;
        }

        public void SaveEmp(EmployeeDto emp)
        {
            try
            {
                _sqlTransaction = _sqlConnection.BeginTransaction();
                var data = _sqlCommands.ExecuteNonQuery("INSERT statement");
                _sqlConnection.Open();
                _sqlTransaction.Commit();
            }
            catch (DbException dbex)
            {
                _sqlTransaction.Rollback();
            }
        }

        public void UpdateEmp(EmployeeDto emp)
        {
            try
            {
                _sqlTransaction = _sqlConnection.BeginTransaction();
                var data = _sqlCommands.ExecuteNonQuery("UPDATE statement");
                _sqlConnection.Open();
                _sqlTransaction.Commit();
            }
            catch (DbException dbex)
            {
                _sqlTransaction.Rollback();
            }
        }
    }
}
