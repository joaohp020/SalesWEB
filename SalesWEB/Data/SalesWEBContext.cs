using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWEB.Models;

namespace SalesWEB.Data
{
    public class SalesWEBContext : DbContext
    {
        public SalesWEBContext (DbContextOptions<SalesWEBContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWEB.Models.Department> Department { get; set; }
    }
}
