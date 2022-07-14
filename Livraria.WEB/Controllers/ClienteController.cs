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

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oClienteService.oRepositoryCliente.Incluir(cliente);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var c = oClienteService.oRepositoryCliente.SelecionarPK(id);   
            return View(c);
        }
    }
}
