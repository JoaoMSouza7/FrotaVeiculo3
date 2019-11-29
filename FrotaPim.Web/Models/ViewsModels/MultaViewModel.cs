using System;
using System.Collections.Generic;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class MultaViewModel
    {
        public int Id { get; set; }
        public Pessoa Motorista { get; set; }
        public IEnumerable<PessoaViewModel> Pessoas { get; set; }
        public string NomePessoa { get; set; }
        public string Gravidade { get; set; }
        public string TipoMulta { get; set; }
        public DateTime DataMulta { get; set; }
        public decimal ValorMulta { get; set; }
        public Carro Carro { get; set; }
        public IEnumerable<CarroViewModel> Carros { get; set; }
        public string Placa { get; set; }
    }
}