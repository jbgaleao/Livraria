using Livraria.DATA.Repositories;

namespace Livraria.DATA.Services
{
    public class ClienteService
    {
        public RepositoryCliente oRepositoryCliente { get; set; }

        public ClienteService()
        {
            oRepositoryCliente = new RepositoryCliente();
        }

    }
}
