using APIRestModelDDD.Domain.Core.Interfaces.Repositorys;
using APIRestModelDDD.Domain.Entitys;

namespace APIRestModelDDD.Infrastructure.Data.Repositorys
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        private readonly ContextoDB contextoDB;

        public RepositoryCliente(ContextoDB contextoDB) : base(contextoDB)
        {
            this.contextoDB = contextoDB;
        }
    }
}