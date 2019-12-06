using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class SeguroViewModel
    {
        public int Id  { get; set; }
        public string Apolice { get; set; }
        public string Seguradora { get; set; }
        public string Placa { get; set; }
        [Display(Name = "Valor do Seguro")]
        public decimal ValorSeguro { get; set; }
        public int IDCarro { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime DataContratacao { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime DataValidade { get; set; }
        public bool Status { get; set; }
        public IEnumerable<CarroViewModel> Carros { get; set; }
    }
}