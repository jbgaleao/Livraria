using Livraria.DATA.Models;
using Livraria.DATA.Services;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace Livraria.WEB.Controllers
{
    public class ClienteController : Controller
    {
        private ClienteService oClienteService = new ClienteService();
        public IActionResult Index()
        {
            List<Cliente> oListCliente = oClienteService.oRepositoryCliente.SelecionarTodos();
            return View(oListCliente);
        }

        public IActionResult Create()
        {
            return View();
        }

    }
}
