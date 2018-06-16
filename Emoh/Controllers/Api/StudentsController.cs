using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Emoh.Models;

namespace Emoh.Controllers.Api
{
    [Produces("application/json")]
    [Route("api/Students")]
    public class StudentsController : Controller
    {
        private readonly EmohContext _context;

        public StudentsController(EmohContext context)
        {
            _context = context;
        }

        // GET: api/Test
        [HttpGet]
        public IEnumerable<Student> GetStudents(int turn)
        {
            //We load 24 domains per each request
            return _context
                .Students
                .OrderByDescending(s => s.Id)
                .Take(turn * 24)
                .Skip((turn - 1) * 24)
                .ToList();
        }
    }
}