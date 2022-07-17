using Livraria.DATA.Repositories;

using System;
using System.Collections.Generic;
using System.Text;

namespace Livraria.DATA.Services
{
    public class LivroClienteEmprestimoService
    {
        public RepositoryVwLivroClienteEmprestimo oRepositoryVwLivroClienteEmprestimo { get; set; }
        public RepositoryLivro oRepositoryLivro { get; set; }        
        public RepositoryCliente oRepositoryCliente { get; set; }


        public LivroClienteEmprestimoService()
        {
            oRepositoryVwLivroClienteEmprestimo = new RepositoryVwLivroClienteEmprestimo();
            oRepositoryLivro = new RepositoryLivro();
            oRepositoryCliente = new RepositoryCliente();

        }
    }
}
