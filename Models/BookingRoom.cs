using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BookingRoom
    {
        public int bookingId { get; set; }
        public int roomId { get; set; }
        public Booking Booking { get; set; }
        public Room Room { get; set; }
    }
}
