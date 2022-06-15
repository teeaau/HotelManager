﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        [Key]
        [StringLength(50)]
        public string customerId { get; set; }
        [StringLength(100)]
        public string customerName { get; set; }
        public DateTime? customerBirthday { get; set; }
    }
}
