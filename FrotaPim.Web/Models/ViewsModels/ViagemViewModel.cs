using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class ViagemViewModel
    {
        public int Id { get; set; }
        public string Origem { get; set; }
        public string Destino { get; set; }
        public decimal KM { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataViagem { get; set; }
        public string Valor { get; set; }
        public IEnumerable<CarroViewModel> Carros { get; set; }
        public IEnumerable<PessoaViewModel> Pessoas { get; set; }
        public int IdCarro { get; set; }
        public int IdPessoa { get; set; }
        public string NomePessoa { get; set; }
        public string Placa { get; set; }
    }
}