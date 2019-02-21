using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interface;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Domain.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : Controller
    {
        StudentContext _context;
        public LoginController(StudentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Login>>> Get()
        {
            return await _context.Logins.AsNoTracking().ToListAsync();


        }

        [HttpGet("CheckLogin")]
        public ActionResult<LoginRespone> CheckLogin(string username,string password)
        {
            // select đặt trước singleofdefault 
            // oderby and thenby đặt trước select 
            var user = _context.Logins.Where(us => us.Username == username && us.Password==password)
                      .SingleOrDefault();
            var s = _context.Logins.OrderBy(x => x.LoginId).Max(x => x.LoginId);
            if(user == null)
            {
                return new LoginRespone { errorcode = 1,nameacount="" };
            }

            return new LoginRespone { errorcode = 0,nameacount=username };

        }

    }
}
