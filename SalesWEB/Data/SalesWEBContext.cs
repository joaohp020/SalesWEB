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

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
