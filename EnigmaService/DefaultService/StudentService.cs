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

        public StudentService()
        {

        }

        public void DeleteStudent(int studentId)
        {
            throw new NotImplementedException();
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

                studentModelList.Add(student);
            }

            return studentModelList;
        }

        public void SaveStudent(StudentModel studentModel)
        {
            var student = new Student()
            {
                Name = studentModel.Name
            };

            _schoolContext.Students.Add(student);
            _schoolContext.SaveChanges();

        }

        public void UpdateStudent(StudentModel studentModel)
        {
            var student = _schoolContext.Students.FirstOrDefault(
                w => w.Name == studentModel.Name);

            if (student != null)
            {
                student = new Student()
                {
                    Name = studentModel.Name
                };

                _schoolContext.Students.Update(student);
                _schoolContext.SaveChanges();
            };
        }
    }
}
