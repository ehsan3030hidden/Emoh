using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Emoh.Models.Interfaces;

namespace Emoh.Models.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly EmohContext _db;
        public Repository(EmohContext db)
        {
            _db = db;
        }
        protected void Finish() => _db.SaveChanges();
        //---------------------------------------------------------
        public int Count(Func<T, bool> predicate)
        {
            return _db.Set<T>().Where(predicate).Count();
        }
        public IEnumerable<T> Find(Func<T, bool> predicate)
        {
            return _db.Set<T>().Where(predicate);
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>();
        }
        public void Create(T entity)
        {
            _db.Add(entity);
            Finish();
        }
        public void Update(T entity)
        {
            _db.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Finish();
        }
        public void Delete(T entity)
        {
            _db.Remove(entity);
            Finish();
        }
    }
}
