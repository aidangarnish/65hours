using _65hours.Repository.EFRepository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _65hours.Repository
{
    public abstract class RepositoryBase<T> where T : class
    {
        private ApplicationDbContext dataContext;
        private readonly IDbSet<T> dbset;
        protected RepositoryBase(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dbset = DataContext.Set<T>();
        }

        protected IDatabaseFactory DatabaseFactory
        {
            get;
            private set;
        }

        protected ApplicationDbContext DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }
        public virtual T Add(T entity)
        {
            T savedEntity = dbset.Add(entity);
            dataContext.SaveChanges();
            return savedEntity;
        }
        public virtual T Update(T entity)
        {
            T savedEntity = dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
            dataContext.SaveChanges();
            return savedEntity;
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
            dataContext.SaveChanges();
        }
        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
            dataContext.SaveChanges();
        }
        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }
        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }
        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).ToList();
        }
        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        } 
    }
}
