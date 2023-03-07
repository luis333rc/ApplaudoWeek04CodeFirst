using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplaudoWeek04CodeFirst.Domain
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstMidName { get; set; }

        public string LastName { get; set; }

        public virtual ICollection<Rental> Rentals { get; set; }

        public virtual ICollection<MovieLike> MovieLikes { get; set; }
    }
}
