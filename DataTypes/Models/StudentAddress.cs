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
    [Table("StudentAddress", Schema = "dbo")]
    public class StudentAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "Address Id")]
        public int AddressId { get; set; }
        [Required]
        [Column(TypeName = "NVarchar(MAX)")]
        [Display(Name = "Address Description")]
        public string AddressDescription { get; set; }

        [ForeignKey("Student")]
        [Required]
        public int StudentId { get; set; }
        public virtual Student Student { get; set; }
    }
}
