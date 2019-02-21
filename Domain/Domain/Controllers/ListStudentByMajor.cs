using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Domain.Models.ViewModel;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Domain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListStudentByMajor : Controller
    {
        StudentContext _context;

        public ListStudentByMajor(StudentContext context)
        {
            _context = context;
        }

        [HttpGet("getbymajorid/{id}")]
        public  async Task<ActionResult<IEnumerable<StudenInfo>>> Get(int id)
        {
            // thao tác với databse sẽ await 
            return await _context.Students.Include(b => b.Major).Where(a => a.MajorId == id).Select(x => new StudenInfo
            {
                StudentId = x.StudentId,
                Code = x.Code,
                Name = x.StudentName,
                MajorName=x.Major.MajorName
                
                
            }).OrderBy(x => x.Name).ToListAsync();

        }

    }
}
