using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplaudoWeek04CodeFirst.Domain
{
    public class Rental
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public int MovieCopyId { get; set; }

        public DateTime RentalDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual MovieCopy MovieCopy { get; set; }
    }
}
