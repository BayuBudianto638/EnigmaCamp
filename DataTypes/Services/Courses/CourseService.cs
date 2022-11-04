using DataTypes.Interfaces;
using DataTypes.Model;
using DataTypes.Services.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Services.Courses
{
    public class CourseService : ICourseService
    {
        private readonly IRepository<Course> _repository;
        public CourseService(IRepository<Course> repository)
        {
            _repository = repository;
        }

        public void Delete(int id)
        {
            var query = _repository.GetAll();
            var result = query.FirstOrDefault(w => w.CourseId == id);
            _repository.Delete(result);
        }

        public Course GetById(int id)
        {
            var query = _repository.GetAll();
            var result = query.FirstOrDefault(w => w.CourseId == id);
            return result;
        }

        public void Save(Course course)
        {
            _repository.Save(course);
        }

        public void Update(Course course)
        {
            _repository.Update(course);
        }
    }
}
