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
    public class CourseService 
    {
        private readonly IRepository<Course> _repository;
        public CourseService(IRepository<Course> repository)
        {
            _repository = repository;
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
