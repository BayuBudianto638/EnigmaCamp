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
    [Table("Students", Schema = "dbo")]
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Student Id")]
        public int StudentId { get; set; }

        [Required]
        [Column(TypeName = "NVarchar(20)")]
        [Display(Name = "Student Code")]
        public string Code { get; set; }

        [Required]
        [Column(TypeName = "Nvarchar(100)")]
        [Display(Name = "Student Name")]
        public string Name { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public StudentCourse StudentCourse { get; set; }
        public StudentAddress StudentAddress { get; set; }
        public ICollection<StudentClass> StudentClasses { get; set; }
    }
}
