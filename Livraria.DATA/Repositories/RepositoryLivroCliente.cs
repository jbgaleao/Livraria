
using Livraria.DATA.Interfaces;
using Livraria.DATA.Models;

namespace Livraria.DATA.Repositories
{
    public class RepositoryLivroCliente : RepositoryBase<LivrosClientes>, IRepositoryLivroCliente
    {
        public RepositoryLivroCliente(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
