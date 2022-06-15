using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Permission
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int permissionId { get; set; }
        [StringLength(50)]
        public string permissionName { get; set; }
        public string permissionDisplay { get; set; }
        public ICollection<RolePermission> RolePermissions { get; set; }
    }
}
