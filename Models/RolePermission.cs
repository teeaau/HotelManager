using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class RolePermission
    {
        public int roleId { get; set; }
        public int permissionId { get; set; }
        public Role Role { get; set; }
        public Permission Permission { get; set; }
    }
}
