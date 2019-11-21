using System;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class PessoaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public Cargo _Cargo { get; set; }
        public Endereco _Endereco { get; set; }
        public DateTime Admissao { get; set; }
        public string Telefone { get; set; }  
    }
}