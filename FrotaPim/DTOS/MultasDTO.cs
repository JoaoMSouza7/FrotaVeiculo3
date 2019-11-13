using System;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Domain.DTOS
{
    public class MultasDTO
    {
        public Pessoa _Motorista { get; set; }
        public string Gravidade { get; set; }
        public DateTime DataMulta { get; set; }
        public decimal ValorMulta { get; set; }
        public Carro _Carro { get; set; }
        public bool Status { get; set; }
    }
}