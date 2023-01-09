using DapperExample;
using DataTypes.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Application
{
    public interface IStudentsRepository
    {
        void Insert(Student entity);
        void Delete(Student entity);
        void Update(Student entity);
        IEnumerable<Student> Query(string where = null);
        StudentDto GetById(int Id);
    }
}
