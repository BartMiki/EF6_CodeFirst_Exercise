using System.Collections.Generic;

namespace EF6_CodeFirst_Exercise
{
    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public IList<Video> Video { get; set; }
    }
}