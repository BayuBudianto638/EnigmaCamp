using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataTypes.Model;

namespace DataTypes.Models
{
    [Table("StudentCourses", Schema = "dbo")]
    public class StudentCourse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Student Course Id")]
        public int StudentCourseId { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(20)")]
        [Display(Name = "Student Course Code")]
        public string StudentCourseCode { get; set; }

        [Required]
        [Column(TypeName = "Nvarchar(100)")]
        [Display(Name = "Student Course Name")]
        public string StudentCourseName { get; set; }

        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Course> Courses { get; set; }

    }
}
