
using Livraria.DATA.Interfaces;
using Livraria.DATA.Models;

namespace Livraria.DATA.Repositories
{
    public class RepositoryVwLivroClienteEmprestimo : RepositoryBase<VwLivroClienteEmprestimo>, 
                                                        IRepositoryVwLivroClienteEmprestimo
    {
        public RepositoryVwLivroClienteEmprestimo(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
