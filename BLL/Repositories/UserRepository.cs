using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository() : base() { }
        public async Task<ICollection<User>> GetIncludeAsync()
        {
            return await Context.Users.Include("Role.RolePermissions.Permission").ToListAsync();
        }

        public async Task<User> GetByIdAsync(string userId)
        {
            return await Context.Users.Include("Role.RolePermissions.Permission").FirstOrDefaultAsync(u => u.userId == userId);
        }
    }
}
