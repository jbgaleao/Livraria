
using Livraria.DATA.Interfaces;
using Livraria.DATA.Models;

namespace Livraria.DATA.Repositories
{
    public class RepositoryCliente : RepositoryBase<Cliente>, IRepositoryCliente
    {
        public RepositoryCliente(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
