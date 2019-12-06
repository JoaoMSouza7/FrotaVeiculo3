using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class ManutencaoViewModel
    {
        public int Id { get; set; }
        public string DescricaoManutencao { get; set; }
        public decimal Valor { get; set; }
        public int IdCarro { get; set; }
        public string Placa { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime Data { get; set; }
        public IEnumerable<CarroViewModel> Carros { get; set; }
    }
}