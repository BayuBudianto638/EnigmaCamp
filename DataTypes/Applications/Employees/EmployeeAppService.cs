using DataTypes.Applications.Employees.Dto;
using DataTypes.SqlServices;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;

namespace DataTypes.Applications.Employees
{
    public class EmployeeAppService : IEmployeeAppService
    {        
        private SqlConnection _sqlConnection;
        private SqlCommands _sqlCommands;
        private SqlTransaction _sqlTransaction;
        public EmployeeAppService(
            SqlConnection sqlConnection
            )
        {           
            _sqlConnection = sqlConnection;
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

            SqlDataAdapter sde = new SqlDataAdapter("SELECT * FROM Employee", _sqlConnection);
            _sqlTransaction.Commit();

            DataSet ds = new DataSet();
            sde.Fill(ds);

            foreach (DataRow row in ds.Tables["Table"].Rows)
            {
                var employee = new EmployeeDto();
                employee.EmployeeId = row["EmployeeId"].ToString();
                employee.EmployeeName = row["EmployeeName"].ToString();
                employee.Salary = Convert.ToInt32(row["Salary"]);
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
