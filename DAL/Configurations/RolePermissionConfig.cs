using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class RolePermissionConfig : EntityTypeConfiguration<RolePermission>
    {
        public RolePermissionConfig()
        {
            this.HasKey(k => new { k.roleId, k.permissionId });
            this.HasRequired(rp => rp.Role)
                .WithMany(r => r.RolePermissions)
                .HasForeignKey(r => r.roleId)
                .WillCascadeOnDelete(true);
            this.HasRequired(rp => rp.Permission)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(p => p.permissionId)
                .WillCascadeOnDelete(true);
        }
    }
}
