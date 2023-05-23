using GenericPower.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericPower.Repositories
{
    public interface I_ReadRepository<out T> where T : class, IEntity
    {
        IEnumerable<T> GetAll();
        public T GetById(int id);
    }
}
