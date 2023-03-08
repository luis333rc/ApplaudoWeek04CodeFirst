using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplaudoWeek04CodeFirst.Domain
{
    public class MovieLike
    {
        public int MovieId { get; set; }

        public int CustomerId { get; set; }

        public int Likes { get; set; }

        public virtual Movie Movie { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
