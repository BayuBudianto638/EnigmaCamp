using EnigmaCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaCore.Interface
{
    public interface IStudent
    {
        void SaveStudent(StudentModel student);
        void UpdateStudent(StudentModel student);
        void DeleteStudent(int studentId);
        List<StudentModel> GetAllStudent();
    }
}
