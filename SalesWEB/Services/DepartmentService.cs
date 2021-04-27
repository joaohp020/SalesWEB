using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWEB.Data;
using SalesWEB.Models;

namespace SalesWEB.Services
{
    public class DepartmentService
    {
        private readonly SalesWEBContext _context;

        public DepartmentService(SalesWEBContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
