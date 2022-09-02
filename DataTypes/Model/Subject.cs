using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes.Model
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public string Semester { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student student { get; set; }
        public Course course { get; set; }
    }
}
