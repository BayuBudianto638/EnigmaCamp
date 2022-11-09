using Dapper;
using System.Data.SqlClient;
using DataTypes.Repositories;
using DataTypes.Application.Dto;

namespace DataTypes.Application
{
    public class StudentRepository : BaseRepository<Student>, IStudentsRepository
    {
        public void Delete(Student student)
        {
            base.Delete(student);
        }

        public StudentDto GetById(int Id)
        {
            var studentRepo = base.Query("Where StudentId = " + Id);
            var studentModel = studentRepo.FirstOrDefault();

            var studentDto = new StudentDto();
            studentDto.StudentName = studentModel.Name;

            return studentDto;
        }

        public override void Insert(Student student)
        {
            if (string.IsNullOrWhiteSpace(student.Name))
                throw new Exception("The name cant be empty!");
            base.Insert(student);
        }

        public void Update(Student student)
        {
            base.Update(student);
        }

        IEnumerable<Student> Query(string where)
        {
            var data = base.Query();
            return data;
        }
    }
}
