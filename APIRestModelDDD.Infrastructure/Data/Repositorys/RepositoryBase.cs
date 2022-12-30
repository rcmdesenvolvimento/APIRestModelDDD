using APIRestModelDDD.Domain.Core.Interfaces.Repositorys;
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
            throw new NotImplementedException();
        }

        public void Remove(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
