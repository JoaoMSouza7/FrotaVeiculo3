using System;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class ManutencaoViewModel
    {
        public string DescricaoManutencao { get; set; }
        public decimal Valor { get; set; }
        public Carro _Carro { get; set; }
        public DateTime Data { get; set; }
    }
}