using DataTypes.Applications.Employees.Dto;

namespace DataTypes.Applications.Employees
{
    public interface IEmployeeAppService
    {
        void SaveEmp(EmployeeDto emp);
        void UpdateEmp(EmployeeDto emp);
        void DeleteEmp(string id);
        EmployeeDto GetById(string id);
        List<EmployeeDto> GetAllEmployee();
    }
}
