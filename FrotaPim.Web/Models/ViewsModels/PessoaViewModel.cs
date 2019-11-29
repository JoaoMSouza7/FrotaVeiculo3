using System;
using System.Collections.Generic;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class PessoaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public int CargoId { get; set; }
        public IEnumerable<CargoViewModel> Cargos { get; set; }
        public string NomeCargo { get; set; }
        public int EnderecoId { get; set; }
        public DateTime Admissao { get; set; }
        public string Telefone { get; set; } 
        public EnderecoViewModel Endereco { get; set; } 
    }
}