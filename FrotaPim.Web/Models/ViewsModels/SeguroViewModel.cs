using System;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class SeguroViewModel
    {
        public string Apolice { get; set; }
        public string Seguradora { get; set; }
        public Carro _Carro { get; set; }
        public DateTime DataContratacao { get; set; }
        public DateTime DataValidade { get; set; }
        public StatusSeguro Status { get; set; }
    }
}