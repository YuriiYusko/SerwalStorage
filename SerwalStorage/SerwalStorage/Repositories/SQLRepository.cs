using GenericPower.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericPower.Repositories
{
    internal class SQLRepository<T_Item> : IRepository<T_Item> 
        where T_Item : class, IEntity, new()
    {
        private readonly DbSet<T_Item> _dbSet;
        private readonly DbContext _dbContext;

        public SQLRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T_Item>();
        }

        public T_Item GetById(int id) 
        {
            return _dbSet.Find(id);
        }

        public void Add(T_Item item) 
        {
            _dbSet.Add(item);
        }

        public void Remove(T_Item item)
        {
            _dbSet.Remove(item);
        }

        public void Save() 
        {
            _dbContext.SaveChanges();
        }

        public IEnumerable<T_Item> GetAll()
        {
            return _dbSet.OrderBy(item => item.Id).ToList();
        }
    }
}
