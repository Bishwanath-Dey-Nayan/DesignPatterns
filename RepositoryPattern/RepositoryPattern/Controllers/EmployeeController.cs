using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IDataRepository<Employee> _repo;

        public EmployeeController(IDataRepository<Employee> repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Employee> employees = _repo.GetAll();
            return Ok(employees);
        }
    }
}
