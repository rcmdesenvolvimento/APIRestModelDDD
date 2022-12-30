using APIRestModelDDD.Domain.Core.Interfaces.Repositorys;
using APIRestModelDDD.Domain.Core.Interfaces.Services;
using System;
using System.Collections.Generic;

namespace APIRestModelDDD.Domain.Services
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            this.repositoryBase = repositoryBase;
        }

        public void Add(TEntity entity)
        {
            repositoryBase.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return repositoryBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return repositoryBase.GetById(id);
        }

        public void Remove(TEntity entity)
        {
            repositoryBase.Remove(entity);  
        }

        public void Update(TEntity entity)
        {
            repositoryBase.Update(entity);
        }
    }
}