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
    public class GenericEmployeeController : ControllerBase
    {
        private IGenericRepository<Employee> repo = null;

        public GenericEmployeeController(IGenericRepository<Employee> repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var model = repo.GetAll();
            return Ok(model);
        }

        [HttpGet("{id}", Name ="Get")]
        public  IActionResult Get(long id)
        {
            Employee employee = repo.GetById(id);
            if(employee == null)
            {
                return NotFound("The Employee record couldn't be found.");
            }
            return Ok(employee);
        }

        [HttpPost]
        public IActionResult Post(Employee employee)
        {
            if(employee == null)
            {
                return BadRequest("Employee is null");
            }
            repo.Insert(employee);
            return CreatedAtRoute("Get", new { Id = employee.EmployeeId}, employee);
        }

        [HttpPut]
        public IActionResult Put(Employee employee)
        {
            if(employee == null)
            {
                return BadRequest("Employee is null");
            }
            repo.Update(employee);
            return NoContent();
        }
    }
}
