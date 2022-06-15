using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Room
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int roomId { get; set; }
        [StringLength(50)]
        public string displayRoom { get; set; }
        public int price { get; set; }
        public ICollection<BookingRoom> BookingRooms { get; set; }
        public Floor Floor { get; set; }
        [ForeignKey("Floor")]
        public int floorId { get; set; }
    }
}
