using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Payment
    {
        [Key]
        public int paymentId { get; set; }
        [Required]
        public Booking Booking { get; set; }
        public DateTime? dateOfPayment { get; set; }
        public int total { get; set; }
    }
}
