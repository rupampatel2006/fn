using System.Linq;

namespace JM.Database.Repository
{
    public interface IRepository
    {
        T Get<T>(int id) where T : EntityBase;
        IQueryable<T> GetAll<T>() where T : EntityBase;
        void SaveOrUpdate<T>(T entity) where T : EntityBase;
        void Delete<T>(T entity) where T : EntityBase;
    }
}
