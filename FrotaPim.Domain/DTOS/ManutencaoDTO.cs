using System;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Domain.DTOS
{
    public class ManutencaoDTO
    {
        public string DescricaoManutencao { get; set; }
        public decimal Valor { get; set; }
        public Carro _Carro { get; set; }
        public DateTime Data { get; set; }
    }
}