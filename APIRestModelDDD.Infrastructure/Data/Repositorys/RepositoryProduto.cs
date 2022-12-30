using APIRestModelDDD.Domain.Core.Interfaces.Repositorys;
using APIRestModelDDD.Domain.Entitys;

namespace APIRestModelDDD.Infrastructure.Data.Repositorys
{
    internal class RepositoryProduto : RepositoryBase<Produto>, IRepositoryProduto
    {
        private readonly ContextoDB contextoDB;

        public RepositoryProduto(ContextoDB contextoDB) : base(contextoDB)
        {
            this.contextoDB = contextoDB;
        }
    }
}
