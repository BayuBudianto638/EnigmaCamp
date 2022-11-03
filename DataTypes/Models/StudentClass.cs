using DataTypes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataTypes.Models
{
    [Table("StudentClass", Schema = "dbo")]
    public class StudentClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Student Class Id")]
        public int StudentClassId { get; set; }
        [Required]
        [Column(TypeName = "NVarchar(MAX)")]
        [Display(Name = "Student Class Description")]
        public string StudentClassDescription { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
    }
}
