using Lab.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Lab.DAL.EF
{
    public class TimesheetContext
        : DbContext
    {
        public DbSet<Timesheet> Phones { get; set; }

        public DbSet<Record> Orders { get; set; }

        public TimesheetContext(DbContextOptions options)
            : base(options)
        {

        }
    }
}
