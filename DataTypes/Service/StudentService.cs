using DataTypes.Interface;
using DataTypes.Model;

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
                    Name = student.Name
                };

                context.Students.Add(std);
                context.SaveChanges();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (var context = new SchoolContext())
            {
                var studentData = context.Students.FirstOrDefault(w => w.StudentId 
                                        == student.StudentId);

                studentData.Name = student.Name;

                context.Students.Update(studentData);
                context.SaveChanges();
            }
        }
    }
}
