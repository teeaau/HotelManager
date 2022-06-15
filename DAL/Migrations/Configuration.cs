using Models;
using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace DAL.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<HotelDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(HotelDbContext context)
        {
            CreatePermissionDefault(context.Permissions);
            CreateRoleDefault(context.Roles);
            CreateRolePermissionDefault(context.RolePermissions);
            CreateUserDefault(context.Users);
            context.SaveChanges();
        }

        private void CreateUserDefault(DbSet<User> users)
        {
            users.Add(new User()
            {
                userId = "admin",
                userPassword = "21232f297a57a5a743894a0e4a801fc3",
                roleId = 1
            });
        }

        private void CreateRolePermissionDefault(DbSet<RolePermission> rolePermissions)
        {
            for(int i = 1; i <= 8; i++)
            {
                rolePermissions.Add(new RolePermission()
                {
                    roleId = 1,
                    permissionId = i
                });
            }
        }

        private void CreateRoleDefault(DbSet<Role> roles)
        {
            roles.AddRange(new Role[]
            {
                new Role()
                {
                    roleId = 1,
                    roleName = "Manager"
                },
                new Role()
                {
                    roleId = 2,
                    roleName = "Employee"
                }
            });
        }

        private void CreatePermissionDefault(DbSet<Permission> permissions)
        {
            permissions.AddRange(new Permission[] {
                new Permission()
                {
                    permissionId = 1,
                    permissionName = "Booking",
                    permissionDisplay = "ĐẶT PHÒNG"
                },
                new Permission()
                {
                    permissionId = 2,
                    permissionName = "Profile",
                    permissionDisplay = "TRANG CÁ NHÂN"
                },
                new Permission()
                {
                    permissionId = 3,
                    permissionName = "RoomConfig",
                    permissionDisplay = "CHỈNH SỬA PHÒNG"
                },
                new Permission()
                {
                    permissionId = 4,
                    permissionName = "Payment",
                    permissionDisplay = "THANH TOÁN"
                },
                new Permission()
                {
                    permissionId = 5,
                    permissionName = "Income",
                    permissionDisplay = "DOANH THU"
                },
                new Permission()
                {
                    permissionId = 6,
                    permissionName = "Chart",
                    permissionDisplay = "BIỂU ĐỒ"
                },
                new Permission()
                {
                    permissionId = 7,
                    permissionName = "User",
                    permissionDisplay = "QUẢN LÝ NGƯỜI DÙNG"
                },
                new Permission()
                {
                    permissionId = 8,
                    permissionName = "Customer",
                    permissionDisplay = "KHÁCH HÀNG"
                }
            });
        }
    }
}
