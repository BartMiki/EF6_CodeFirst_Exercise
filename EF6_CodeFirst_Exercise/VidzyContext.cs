using System.Data.Entity;

namespace EF6_CodeFirst_Exercise
{
    public class VidzyContext : DbContext
    {
        public VidzyContext() : base("DefaultConnection") { }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}