using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Bill
    {
        [Key]
        public int bill { get; set; }
        [StringLength(100)]
        public string customerName { get; set; }
        public string displayRoom { get; set; }
        public DateTime checkin { get; set; }
        public DateTime checkout { get; set; }
        public DateTime dateOfPayment { get; set; }
        public int total { get; set; }
    }
}
