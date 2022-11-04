using DataTypes.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Services.Courses
{
    public interface ICourseService
    {
        Course GetById(int id);
        void Save(Course course);
        void Update(Course course);
        void Delete(int id);
    }
}
