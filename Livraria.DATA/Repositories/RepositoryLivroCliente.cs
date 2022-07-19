using Livraria.DATA.Models;

namespace Livraria.DATA.Repositories
{
    public class RepositoryLivroCliente : RepositoryBase<LivroCliente>, IRepositoryLivroCliente
    {
        public RepositoryLivroCliente(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
