using DataTypes.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataTypes.Model
{
    [Table("Courses", Schema = "dbo")]
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Course Id")]
        public int CourseId { get; set; }
        [Required]
        [Column(TypeName = "Nvarchar(100)")]
        [Display(Name = "Course Name")]
        public string CourseName { get; set; }
        public StudentCourse StudentCourse { get; set; }
        public ICollection<StudentClass> StudentClasses { get; set; }
    }
}
