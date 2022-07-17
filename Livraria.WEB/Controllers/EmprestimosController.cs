using System.Collections.Generic;

using Livraria.DATA.Models;
using Livraria.DATA.Services;
using Livraria.WEB.Models;

using Microsoft.AspNetCore.Mvc;

using Cliente = Livraria.DATA.Models.Cliente;
using Livro = Livraria.DATA.Models.Livro;
using VwLivroClienteEmprestimo = Livraria.DATA.Models.VwLivroClienteEmprestimo;

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

            oEmprestimoViewModel.oListCliste = _oListCliente;

            return View();
        }

    }
}
