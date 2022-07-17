using Livraria.DATA.Interfaces;
using Livraria.DATA.Models;

namespace Livraria.DATA.Repositories
{
    public class RepositoryLivroClienteEmprestimo : RepositoryBase<LivroClienteEmprestimo>, IRepositoryLivroClienteEmprestimo
    {
        public RepositoryLivroClienteEmprestimo(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
