using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositories
{
    public class RoomRepository : GenericRepository<Room>
    {
        public RoomRepository() : base() { }
        
        public async Task<ICollection<Room>> GetIncludeAsync()
        {
            return await Context.Rooms.Include("Floor").ToListAsync();
        }

        public async Task<ICollection<Floor>> GetFloorAsync()
        {
            return await Context.Floors.ToListAsync();
        }
    }
}
