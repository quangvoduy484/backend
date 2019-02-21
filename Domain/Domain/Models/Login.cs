using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    [Table("Logins")]
    public class Login
    {
        [Key]
        public int LoginId { get; set; }

        [Column("Name")]
        public string Username { get; set; }

       
        public string Password { get; set; }
    }
}
