using DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class GenericRepository<TEntity>
    where TEntity : class
    {
        protected readonly HotelDbContext Context = new HotelDbContext();

        protected GenericRepository()
        {
        }
        public void Add(TEntity model)
        {
            Context.Set<TEntity>().Add(model);
        }

        public async Task<ICollection<TEntity>> GetAllAsync()
        {
            return await Context.Set<TEntity>().ToListAsync();
        }

        public void Remove(TEntity model)
        {
            Context.Set<TEntity>().Remove(model);
        }

        public void AddOrUpdate(TEntity model)
        {
            Context.Set<TEntity>().AddOrUpdate(model);
        }

        public async Task SaveAsync()
        {
            await Context.SaveChangesAsync();
        }

        public void Save()
        {
            Context.SaveChanges();
        }
    }
}
