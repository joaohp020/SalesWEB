using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWEB.Models;
using SalesWEB.Models.Enums;

namespace SalesWEB.Data
{
    public class SeedingService
    {
        private SalesWEBContext _context;

        public SeedingService(SalesWEBContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() ||
                _context.Seller.Any() ||
                _context.SalesRecord.Any())
            {
                return; //o banco de dados já foi populado
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob", "bob@gmail.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "Maria", "maria@gmail.com", new DateTime(1979, 12, 31), 3500.0, d1);
            Seller s3 = new Seller(3, "Alex", "alex@gmail.com", new DateTime(1988, 1, 15), 2200.0, d1);
            Seller s4 = new Seller(4, "Martha", "martha@gmail.com", new DateTime(1993, 11, 30), 3000.0, d1);
            Seller s5 = new Seller(5, "Donald", "donald@gmail.com", new DateTime(2000, 1, 9), 4000.0, d1);
            Seller s6 = new Seller(6, "Jhon", "jhon@gmail.com", new DateTime(1997, 3, 4), 3000.0, d1);

            SalesRecord r1 = new SalesRecord(1, new DateTime(2021, 04, 15), 5000.0, SaleStatus.Billed, s3);
            SalesRecord r2 = new SalesRecord(2, new DateTime(2021, 04, 15), 1500.0, SaleStatus.Pending, s5);
            SalesRecord r3 = new SalesRecord(3, new DateTime(2021, 04, 15), 3000.0, SaleStatus.Canceled, s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3);

            _context.SaveChanges();
        }
    }
}
