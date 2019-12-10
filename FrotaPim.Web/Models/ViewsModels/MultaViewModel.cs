using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class MultaViewModel
    {
        public int Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public IEnumerable<PessoaViewModel> Pessoas { get; set; }
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public string Gravidade { get; set; }
        public string TipoMulta { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataMulta { get; set; }
        public string ValorMulta { get; set; }
        public Carro Carro { get; set; }
        public int IdCarro { get; set; }
        public IEnumerable<CarroViewModel> Carros { get; set; }
        public string Placa { get; set; }
    }
}