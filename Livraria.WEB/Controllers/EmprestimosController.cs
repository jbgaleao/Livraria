using System.Collections.Generic;
using System;
using Livraria.DATA.Models;
using Livraria.DATA.Services;
using Livraria.WEB.Models;

using Microsoft.AspNetCore.Mvc;


namespace Livraria.WEB.Controllers
{
    public class EmprestimosController : Controller
    {

        private LivroClienteEmprestimoService _service = new LivroClienteEmprestimoService();

        public IActionResult Index()
        {
            List<VwLivroClienteEmprestimo> oListVwLivroClienteEmprestimo = _service.oRepositoryVwLivroClienteEmprestimo.SelecionarTodos();
            return View(oListVwLivroClienteEmprestimo);
        }

        public IActionResult Create()
        {
            EmprestimoViewModel oEmprestimoViewModel = new EmprestimoViewModel();

            List<Cliente> _oListCliente = _service.oRepositoryCliente.SelecionarTodos();
            List<Livro> _oListLivro = _service.oRepositoryLivro.SelecionarTodos();

            oEmprestimoViewModel.oListCliente = _oListCliente;
            oEmprestimoViewModel.oListLivro = _oListLivro;
            oEmprestimoViewModel.dataEmprestimo = DateTime.Now;
            oEmprestimoViewModel.dataEntrega = DateTime.Now.AddDays(7);

            return View(oEmprestimoViewModel);
        }

        [HttpPost]
        public IActionResult Create(LivroCliente oLivroCliente)
        {
            //LivroCliente oLivroCliente = new LivroCliente()
            //{
            //    DataEmprestimo = evm.dataEntrega,
            //    DataEntrega = evm.dataEntrega,
            //    Entregue = false,
            //    IdCliente = evm.hiddenIdCliente,
            //    IdLivro = evm.hiddenIdLivro
            //};

            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            _service.oRepositoryLivroClienteEmprestimo.Incluir();


            return View();
        }

    }
}
