using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    [Table("Majors")]
    public class Major
    {
        [Key]
        public int MajorId { get; set; }

        [Column("Name")]
        public string MajorName { get; set; }
    }
}
