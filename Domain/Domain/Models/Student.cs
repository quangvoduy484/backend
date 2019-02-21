using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        public string Code { get; set; }

        [Column("Name")]
        [MaxLength(100)]
        public string StudentName { get; set; }

        public int MajorId { get; set; }

        [ForeignKey("MajorId")]
        public virtual Major Major { get; set; }
    }
}
