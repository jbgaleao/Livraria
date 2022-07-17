using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Livraria.WEB.Models
{
    public class EmprestimoViewModel
    {
        public Livro oLivro { get; set; }
        public Cliente oCliente { get; set; }
        public DateTime dataEmprestimo { get; set; }
        public DateTime dataEntrega { get; set; }
        public List<Cliente> oListCliste { get; set; }

    }
}
