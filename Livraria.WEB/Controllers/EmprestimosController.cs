using System.Collections.Generic;

using Livraria.DATA.Models;
using Livraria.DATA.Services;

using Microsoft.AspNetCore.Mvc;

namespace Livraria.WEB.Controllers
{
    public class EmprestimosController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }

    }
}
