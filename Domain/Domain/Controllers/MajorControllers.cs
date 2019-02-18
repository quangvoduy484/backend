using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Domain.Controllers
{
    [Route("api/[controller]")]
    public class MajorControllers : Controller
    {
        StudentContext _context;
       
        public MajorControllers(StudentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Major>>> Get()
        {
            return await  _context.Majors.AsNoTracking().ToListAsync();


        }
    }
}
