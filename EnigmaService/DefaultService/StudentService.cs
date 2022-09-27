using EnigmaCore.Interface;
using EnigmaCore.Model;
using EnigmaData.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaService.DefaultService
{
    public class StudentService : IStudent
    {
        private readonly SchoolContext _schoolContext;
        public StudentService(SchoolContext schoolContext)
        {
            _schoolContext = schoolContext;
        }

        public void DeleteStudent(int studentId)
        {
            var data = _schoolContext.Students.FirstOrDefault(w => w.StudentId == studentId);

            if (data != null)
            {
                _schoolContext.Students.Remove(data);
                _schoolContext.SaveChanges();
            }
        }

        public List<StudentModel> GetAllStudent()
        {
            var listStudent = _schoolContext.Students.ToList();

            var studentModelList = new List<StudentModel>();

            foreach (var item in listStudent)
            {
                var student = new StudentModel();

                student.StudentId = item.StudentId;
                student.Name = item.Name;
                student.Address = item.Address;
                student.Country = item.Country;

                studentModelList.Add(student);
            }

            return studentModelList;
        }

        public void SaveStudent(StudentModel studentModel)
        {
            var student = new Student()
            {
                Name = studentModel.Name,
                Address = studentModel.Address,
                Country = studentModel.Country
            };

            _schoolContext.Students.Add(student);
            _schoolContext.SaveChanges();
        }

        public void UpdateStudent(StudentModel studentModel)
        {
            var student = new Student()
            {
                StudentId = studentModel.StudentId,
                Name = studentModel.Name,
                Address = studentModel.Address,
                Country = studentModel.Country
            };

            _schoolContext.Students.Update(student);
            _schoolContext.SaveChanges();
        }
    }
}
