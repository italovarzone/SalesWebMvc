using SalesWebMvc.Models;
using SalesWebMvc.Models.Enums;

namespace SalesWebMvc.Data
{
    public class SeedingService
    {
        private SalesWebMvcContext _context;

        public SeedingService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Department.Any() || _context.Seller.Any() || _context.SalesRecord.Any())
            {
                return;
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "Bob Brown", "bob@gmail.com", DateTime.SpecifyKind(new DateTime(1998, 4, 21), DateTimeKind.Utc), 1000.50, d1);
            Seller s2 = new Seller(2, "Alice White", "alice@gmail.com", DateTime.SpecifyKind(new DateTime(1990, 12, 15), DateTimeKind.Utc), 1200.75, d2);
            Seller s3 = new Seller(3, "Charlie Green", "charlie@gmail.com", DateTime.SpecifyKind(new DateTime(1985, 8, 5), DateTimeKind.Utc), 900.30, d3);
            Seller s4 = new Seller(4, "David Black", "david@gmail.com", DateTime.SpecifyKind(new DateTime(1995, 2, 10), DateTimeKind.Utc), 800.20, d4);
            Seller s5 = new Seller(5, "Eva Red", "eva@gmail.com", DateTime.SpecifyKind(new DateTime(1982, 6, 30), DateTimeKind.Utc), 1100.60, d1);
            Seller s6 = new Seller(6, "Frank Yellow", "frank@gmail.com", DateTime.SpecifyKind(new DateTime(1993, 10, 8), DateTimeKind.Utc), 950.40, d2);

            SalesRecord r1 = new SalesRecord(1, DateTime.SpecifyKind(new DateTime(2018, 9, 25), DateTimeKind.Utc), 11000.0, SaleStatus.Billed, s1);
            SalesRecord r2 = new SalesRecord(2, DateTime.SpecifyKind(new DateTime(2018, 10, 3), DateTimeKind.Utc), 7500.0, SaleStatus.Billed, s2);
            SalesRecord r3 = new SalesRecord(3, DateTime.SpecifyKind(new DateTime(2018, 10, 10), DateTimeKind.Utc), 3200.0, SaleStatus.Pending, s3);
            SalesRecord r4 = new SalesRecord(4, DateTime.SpecifyKind(new DateTime(2018, 10, 15), DateTimeKind.Utc), 5500.0, SaleStatus.Pending, s4);
            SalesRecord r5 = new SalesRecord(5, DateTime.SpecifyKind(new DateTime(2018, 10, 20), DateTimeKind.Utc), 8700.0, SaleStatus.Canceled, s5);
            SalesRecord r6 = new SalesRecord(6, DateTime.SpecifyKind(new DateTime(2018, 11, 8), DateTimeKind.Utc), 4200.0, SaleStatus.Billed, s6);
            SalesRecord r7 = new SalesRecord(7, DateTime.SpecifyKind(new DateTime(2018, 11, 15), DateTimeKind.Utc), 6000.0, SaleStatus.Billed, s1);
            SalesRecord r8 = new SalesRecord(8, DateTime.SpecifyKind(new DateTime(2018, 11, 22), DateTimeKind.Utc), 3000.0, SaleStatus.Pending, s2);
            SalesRecord r9 = new SalesRecord(9, DateTime.SpecifyKind(new DateTime(2018, 12, 5), DateTimeKind.Utc), 9000.0, SaleStatus.Billed, s3);
            SalesRecord r10 = new SalesRecord(10, DateTime.SpecifyKind(new DateTime(2018, 12, 13), DateTimeKind.Utc), 7500.0, SaleStatus.Canceled, s4);
            SalesRecord r11 = new SalesRecord(11, DateTime.SpecifyKind(new DateTime(2018, 12, 18), DateTimeKind.Utc), 4000.0, SaleStatus.Billed, s5);
            SalesRecord r12 = new SalesRecord(12, DateTime.SpecifyKind(new DateTime(2019, 1, 2), DateTimeKind.Utc), 6200.0, SaleStatus.Pending, s6);
            SalesRecord r13 = new SalesRecord(13, DateTime.SpecifyKind(new DateTime(2019, 1, 10), DateTimeKind.Utc), 5300.0, SaleStatus.Billed, s1);
            SalesRecord r14 = new SalesRecord(14, DateTime.SpecifyKind(new DateTime(2019, 2, 1), DateTimeKind.Utc), 4800.0, SaleStatus.Canceled, s2);
            SalesRecord r15 = new SalesRecord(15, DateTime.SpecifyKind(new DateTime(2019, 2, 8), DateTimeKind.Utc), 6200.0, SaleStatus.Billed, s3);
            SalesRecord r16 = new SalesRecord(16, DateTime.SpecifyKind(new DateTime(2019, 2, 16), DateTimeKind.Utc), 6300.0, SaleStatus.Pending, s4);
            SalesRecord r17 = new SalesRecord(17, DateTime.SpecifyKind(new DateTime(2019, 2, 25), DateTimeKind.Utc), 4100.0, SaleStatus.Billed, s5);
            SalesRecord r18 = new SalesRecord(18, DateTime.SpecifyKind(new DateTime(2019, 3, 4), DateTimeKind.Utc), 5900.0, SaleStatus.Billed, s6);
            SalesRecord r19 = new SalesRecord(19, DateTime.SpecifyKind(new DateTime(2019, 3, 11), DateTimeKind.Utc), 5200.0, SaleStatus.Pending, s1);
            SalesRecord r20 = new SalesRecord(20, DateTime.SpecifyKind(new DateTime(2019, 3, 20), DateTimeKind.Utc), 6100.0, SaleStatus.Billed, s2);
            SalesRecord r21 = new SalesRecord(21, DateTime.SpecifyKind(new DateTime(2019, 4, 3), DateTimeKind.Utc), 8900.0, SaleStatus.Canceled, s3);
            SalesRecord r22 = new SalesRecord(22, DateTime.SpecifyKind(new DateTime(2019, 4, 10), DateTimeKind.Utc), 6500.0, SaleStatus.Billed, s4);
            SalesRecord r23 = new SalesRecord(23, DateTime.SpecifyKind(new DateTime(2019, 4, 18), DateTimeKind.Utc), 5900.0, SaleStatus.Pending, s5);
            SalesRecord r24 = new SalesRecord(24, DateTime.SpecifyKind(new DateTime(2019, 4, 25), DateTimeKind.Utc), 7300.0, SaleStatus.Billed, s6);
            SalesRecord r25 = new SalesRecord(25, DateTime.SpecifyKind(new DateTime(2019, 5, 2), DateTimeKind.Utc), 8100.0, SaleStatus.Billed, s1);
            SalesRecord r26 = new SalesRecord(26, DateTime.SpecifyKind(new DateTime(2019, 5, 10), DateTimeKind.Utc), 9300.0, SaleStatus.Pending, s2);
            SalesRecord r27 = new SalesRecord(27, DateTime.SpecifyKind(new DateTime(2019, 5, 20), DateTimeKind.Utc), 7800.0, SaleStatus.Canceled, s3);
            SalesRecord r28 = new SalesRecord(28, DateTime.SpecifyKind(new DateTime(2019, 5, 28), DateTimeKind.Utc), 6700.0, SaleStatus.Billed, s4);
            SalesRecord r29 = new SalesRecord(29, DateTime.SpecifyKind(new DateTime(2019, 6, 5), DateTimeKind.Utc), 5600.0, SaleStatus.Pending, s5);
            SalesRecord r30 = new SalesRecord(30, DateTime.SpecifyKind(new DateTime(2019, 6, 12), DateTimeKind.Utc), 9000.0, SaleStatus.Billed, s6);

            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);
            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SaveChanges();
        }
    }
}
