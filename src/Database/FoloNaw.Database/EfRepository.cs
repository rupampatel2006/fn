using System;
using System.Collections.Concurrent;
using System.Data.Entity;
using System.Linq;
using JM.Database;
using JM.Database.Repository;

namespace FoloNow.Database
{
    public  class EfRepository : IRepository, IDisposable
    {
        private EFContext _context;
		private readonly ConcurrentDictionary<Type, object> _dbSets =
			new ConcurrentDictionary<Type, object>();

        public EfRepository(EFContext context)
		{
			_context = context;
		}

		public T Get<T>(int id) where T : EntityBase
		{
			return GetDbSet<T>().Find(id);
		}

        public IQueryable<T> GetAll<T>() where T : EntityBase
		{
			return GetDbSet<T>();
		}

        public void SaveOrUpdate<T>(T entity) where T : EntityBase
		{
			if (_context.Entry(entity).State == EntityState.Detached)
			{
				GetDbSet<T>().Add(entity);
			}
			else
			{
				_context.Entry(entity).State = EntityState.Modified;
			}

			_context.SaveChanges();
		}

        public void Delete<T>(T entity) where T : EntityBase
		{
			GetDbSet<T>().Remove(entity);
			_context.SaveChanges();
		}

        private DbSet<T> GetDbSet<T>() where T : EntityBase
		{
			return (DbSet<T>)_dbSets.GetOrAdd(typeof(T), x => _context.Set<T>());
		}

		public void Dispose()
		{
			if (_context != null)
			{
				_context.Dispose();
				_context = null;
			}
		}
    }
}
