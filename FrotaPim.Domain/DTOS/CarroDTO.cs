using System;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Domain.DTOS
{
    public class CarroDTO
    {
        public int IDCarro { get; set; }
        public int Placa { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public TipoCombustivel Combustivel { get; set; }
        public string Cor { get; set; }
        public DateTime Ano { get; set; }
        public Pessoa _Motorista { get; set; }
    }
}