
using Livraria.DATA.Interfaces;
using Livraria.DATA.Models;

namespace Livraria.DATA.Repositories
{
    public class RepositoryLivro : RepositoryBase<Livro>, IRepositoryLivro
    {
        public RepositoryLivro(bool SaveChanges = true) : base(SaveChanges)
        {

        }
    }
}
