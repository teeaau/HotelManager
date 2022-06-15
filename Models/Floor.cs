using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Floor
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int floorId { get; set; }
        [StringLength(25)]
        public string displayFloor { get; set; }
        public ICollection<Room> Rooms { get; set; }
    }
}
