

using BackEndMVCDDD.Domain.Interfaces;
using BackEndMVCDDD.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BackEndMVCDDD.Infra.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected BackEndMVCDDDContext Db = new BackEndMVCDDDContext(); //Instância do context
        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges(); // Ou unity of work (modifica várias classes ao mesmo tempo)
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList(); // Ou utilizar o no tracking
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
