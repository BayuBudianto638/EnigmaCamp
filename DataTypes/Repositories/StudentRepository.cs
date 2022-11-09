using DataTypes.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace DataTypes.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentsRepository
    {
        public void Delete(Student student)
        {
           base.Delete(student);
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
