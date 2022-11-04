using DataTypes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Services.Students
{
    public class StudentService : IStudentService
    {
        public StudentService()
        {

        }

        public void DeleteStudent(int id)
        {
            using (var context = new SchoolContext())
            {
                var student = context.Students.FirstOrDefault(w => w.StudentId == id);

                context.Students.Remove(student);
                context.SaveChanges();
            }
        }

        public List<Student> GetAllStudents()
        {
            var context = new SchoolContext();
            var listStudent = context.Students.ToList();

            return listStudent;
        }

        public Student GetById(int studentId)
        {
            var context = new SchoolContext();
            var student = context.Students.FirstOrDefault(w => w.StudentId == studentId);

            return student;
        }

        public Student GetByName(string name)
        {
            var context = new SchoolContext();
            var student = context.Students.FirstOrDefault(w => w.Name.Contains(name));
            return student;
        }

        public void SimpanStudent(Student student)
        {
            using (var context = new SchoolContext())
            {
                var std = new Student()
                {
                    Code = student.Code,
                    Name = student.Name,
                    Address = student.Address,
                    Country = student.Country
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (var context = new SchoolContext())
            {
                var studentData = new Student();

                studentData.StudentId = student.StudentId;
                studentData.Name = student.Name;
                studentData.Address = student.Address;
                studentData.Country = student.Country;

                context.Students.Update(studentData);
                context.SaveChanges();
            }
        }
    }
}
