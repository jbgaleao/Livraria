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

        public IActionResult Details(int Id)
        {
            Cliente c = oClienteService.oRepositoryCliente.SelecionarPK(Id);
            return View(c);
        }

        public IActionResult Edit(int Id)
        {
            Cliente c = oClienteService.oRepositoryCliente.SelecionarPK(Id);
            return View(c);
        }
        
        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oClienteService.oRepositoryCliente.Alterar(cliente);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            oClienteService.oRepositoryCliente.Excluir(Id);
            return RedirectToAction("Index");
        }

    }
}
