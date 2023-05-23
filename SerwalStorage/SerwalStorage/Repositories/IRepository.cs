using GenericPower.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericPower.Repositories
{
    public interface IRepository<T> :I_ReadRepository<T>, I_WriteRepository<T> where T : class, IEntity
    {
    }
}
