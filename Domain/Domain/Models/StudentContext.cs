﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions options) : base(options)
        {
            
        }

        
        public DbSet<Student> Students { get; set; }
        public DbSet<Major> Majors { get; set; }
        public DbSet<Login> Logins { get; set; }

    }
}
