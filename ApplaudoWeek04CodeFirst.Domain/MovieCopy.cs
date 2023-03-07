using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplaudoWeek04CodeFirst.Domain
{
    public class MovieCopy
    {
        public int Id { get; set; }

        public int MovieId { get; set; }

        public bool Available { get; set; }

        public Movie Movie { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
