using DataTypes.Interface;
using DataTypes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Service
{
    public class StudentService : IStudent
    {
        public StudentService()
        {

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

        public void SimpanStudent(Student student)
        {
            using (var context = new SchoolContext())
            {
                var std = new Student()
                {
                    Name = "Bill"
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
        }

        public void UpdateStudent(int studentId)
        {
            using (var context = new SchoolContext())
            {
                var std = new Student()
                {
                    Name = "Bill"
                };

                context.Students.Update(std);
                context.SaveChanges();
            }
        }
    }
}
