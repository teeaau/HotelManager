using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Booking
    {
        [Key]
        public int bookingId { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
        public bool isPaid { get; set; } = false;
        [ForeignKey("Room")]
        public int roomId { get; set; }
        public Room Room { get; set; }
        [ForeignKey("Customer")]
        public string customerId;
        public Customer Customer { get; set; }
        public ICollection<BookingRoom> BookingRooms { get; set; }
    }
}
