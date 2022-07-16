
using Livraria.DATA.Interfaces;
using Livraria.DATA.Models;

namespace Livraria.DATA.Repositories
{
    public class RepositoryVwEmprestimo : RepositoryBase<VwEmprestimo>, IRepositoryEmprestimo
    {
        public RepositoryVwEmprestimo(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
