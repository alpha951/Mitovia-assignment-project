using Microsoft.EntityFrameworkCore;
using Mitovia.Models;

namespace Mitovia.data
{
    public class MitoviaDbContext : DbContext
    {
        public MitoviaDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Measure> Measure { get; set; }
        public DbSet<MeasureScale> MeasureScale { get; set; }

        public DbSet<ValueDial> ValueDial { get; set; }

    }

}
