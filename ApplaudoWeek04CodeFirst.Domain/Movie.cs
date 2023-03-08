using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplaudoWeek04CodeFirst.Domain
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string PosterUrl { get; set; }

        public string TrailerUrl { get; set; }

        public double Price { get; set; }

        public int Stock { get; set; }

        public bool Available { get; set; }

        public virtual ICollection<MovieCopy> MovieCopies { get; set; }

        public virtual ICollection<MovieTag> MovieTags { get; set; }

        public virtual ICollection<MovieLike> MovieLikes { get; set; }
    }
}
