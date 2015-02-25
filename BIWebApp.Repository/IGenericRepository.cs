using System.Linq;
using BIWebApp.Data;

namespace BIWebApp.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }
    }
}