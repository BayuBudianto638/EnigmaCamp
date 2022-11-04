using DataTypes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Services.Students
{
    public interface IStudentService
    {
        void SimpanStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(int id);
        Student GetById(int studentId);
        List<Student> GetAllStudents();
        Student GetByName(string name);

    }
}
