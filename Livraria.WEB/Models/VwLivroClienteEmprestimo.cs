﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace Livraria.WEB.Models
{
    public partial class VwLivroClienteEmprestimo
    {
        public int Id { get; set; }
        public int? IdCliente { get; set; }
        public string Cpf { get; set; }
        public string NomeCliente { get; set; }
        public int? IdLivro { get; set; }
        public string NomeLivro { get; set; }
        public string Autor { get; set; }
        public DateTime? DataEmprestimo { get; set; }
        public DateTime? DataEntrega { get; set; }
        public bool? Entregue { get; set; }
    }
}