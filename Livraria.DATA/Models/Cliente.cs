﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Livraria.DATA.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            LivrosCliente = new HashSet<LivrosClientes>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [Column("CPF")]
        [StringLength(14)]
        public string Cpf { get; set; }
        [Required]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [StringLength(50)]
        public string Endereco { get; set; }
        [Required]
        [StringLength(50)]
        public string Bairro { get; set; }
        [Required]
        [StringLength(50)]
        public string Cidade { get; set; }

        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<LivrosClientes> LivrosCliente { get; set; }
    }
}