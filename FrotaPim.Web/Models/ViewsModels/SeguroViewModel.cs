using System;
using System.Collections.Generic;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class SeguroViewModel
    {
        public int Id  { get; set; }
        public string Apolice { get; set; }
        public string Seguradora { get; set; }
        public string Placa { get; set; }
        public decimal ValorSeguro { get; set; }
        public int IDCarro { get; set; }
        public DateTime DataContratacao { get; set; }
        public DateTime DataValidade { get; set; }
        public bool Status { get; set; }
        public IEnumerable<CarroViewModel> Carros { get; set; }
    }
}