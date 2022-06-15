using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class User
    {
        [Key]
        [StringLength(50)]
        public string userId { get; set; }
        [StringLength(100)]
        [Required]
        public string userPassword { get; set; }
        
        [StringLength(100)]
        public string name { get; set; }
        [StringLength(50)]
        public string email { get; set; }
        public DateTime? birthday { get; set; }
        public byte[] avatar { get; set; }

        [ForeignKey("Role")]
        public int roleId { get; set; }
        public Role Role { get; set; }
    }
}
