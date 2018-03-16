using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6_CodeFirst_Exercise
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public Classification Classification { get; set; }
    }

    public enum Classification : byte
    {
        Silver = 1,
        Gold,
        Platinium
    }

    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public IList<Video> Video { get; set; }
    }

    public class VidzyContext : DbContext
    {
        public VidzyContext() : base("DefaultConnection") { }

        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
