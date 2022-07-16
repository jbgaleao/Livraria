using System.Collections.Generic;

using Livraria.DATA.Models;
using Livraria.DATA.Services;

using Microsoft.AspNetCore.Mvc;

namespace Livraria.WEB.Controllers
{
    public class LivroController : Controller
    {
        private readonly LivroService oLivroService = new LivroService();


        public IActionResult Index()
        {
            List<Livro> oListLivro = oLivroService.oRepositoryLivro.SelecionarTodos();
            return View(oListLivro);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Livro livro)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oLivroService.oRepositoryLivro.Incluir(livro);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int Id)
        {
            Livro Livro = oLivroService.oRepositoryLivro.SelecionarPK(Id);
            return View(Livro);
        }

        public IActionResult Edit(int Id)
        {
            Livro livro = oLivroService.oRepositoryLivro.SelecionarPK(Id);
            return View(livro);
        }

        [HttpPost]
        public IActionResult Edit(Livro livro)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            oLivroService.oRepositoryLivro.Alterar(livro);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int Id)
        {
            oLivroService.oRepositoryLivro.Excluir(Id);
            return RedirectToAction("Index");
        }

    }
}
