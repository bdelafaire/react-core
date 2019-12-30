using Microsoft.AspNetCore.Mvc;
using ReactCore.Models;
using ReactCore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReactCore.Controller
{
    [Route("api/student")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        public readonly IDataRepository<Student> _dataRepository;

        public StudentController(IDataRepository<Student> data)
        {
            _dataRepository = data;
        }

        // GET: api/student
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Student> student = _dataRepository.GetAll();
            return Ok(student);
        }
    }
}
