﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Livraria.WEB.Models
{
    public partial class LivroCliente
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public int? IdLivro { get; set; }
        public DateTime? DataEmprestimo { get; set; }
        public DateTime? DataEntrega { get; set; }
        public bool? Entregue { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Livro IdLivroNavigation { get; set; }
    }
}