using RepositoryPattern.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern.DataManager
{
    public class EmployeeManager : IDataRepository<Employee>
    {
        readonly ApplicationContext _context;

        public EmployeeManager(ApplicationContext context)
        {
            _context = context;
        }
        public void Add(Employee entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Employee entity)
        {
            throw new NotImplementedException();
        }

        public Employee Get(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            return _context.Employees.ToList();
        }

        public void update(Employee dbEntity, Employee entity)
        {
            throw new NotImplementedException();
        }
    }
}
