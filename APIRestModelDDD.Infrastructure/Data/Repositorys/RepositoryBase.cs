using APIRestModelDDD.Domain.Core.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace APIRestModelDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly ContextoDB contextoDB;

        public RepositoryBase(ContextoDB contextoDB)
        {
            this.contextoDB = contextoDB;
        }

        public void Add(TEntity entity)
        {
            try
            {
                contextoDB.Set<TEntity>().Add(entity);
                contextoDB.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll()
        {
            return contextoDB.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return contextoDB.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            try
            {
                contextoDB.Set<TEntity>().Remove(entity);
                contextoDB.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                contextoDB.Entry(entity).State = EntityState.Modified;
                contextoDB.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
