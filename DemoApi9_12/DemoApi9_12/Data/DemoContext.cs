using DemoApi9_12.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DemoApi9_12.Data
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {

        }

        public DbSet<Region> Region { get; set; }
        public DbSet<Walk> Walk { get; set; }
        public DbSet<Walkdiffculty> Walkdiffculty { get; set; }
    }
}
