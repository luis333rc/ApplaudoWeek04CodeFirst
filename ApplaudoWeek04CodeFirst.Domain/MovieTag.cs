using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplaudoWeek04CodeFirst.Domain
{
    public class MovieTag
    {
        public int TagId { get; set; }

        public int MovieId { get; set; }

        public virtual Tag Tag { get; set; }

        public virtual Movie Movie { get; set; }
    }
}
