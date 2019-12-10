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
        public string ValorSeguro { get; set; }
        public int IDCarro { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataContratacao { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataValidade { get; set; }
        public bool Status { get; set; }
        public IEnumerable<CarroViewModel> Carros { get; set; }
    }
}