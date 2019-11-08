using System;

namespace FrotaPim.Domain.Entidades
{
    public class Carro
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

        public Carro(int placa, string tipo, string marca, string Modelo, TipoCombustivel combustivel, string cor, DateTime ano, Pessoa motorista)
        {
            SetarPropriedades(placa, tipo, marca, Modelo, combustivel, cor, ano, motorista);
            ValidarProps(placa, tipo, marca, Modelo, combustivel, cor, ano, motorista);
        }

        private void SetarPropriedades(int placa, string tipo, string marca, string modelo, TipoCombustivel combustivel, string cor, DateTime ano, Pessoa motorista)
        {
            Placa = placa;
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;
            Cor = cor;
            Ano = ano;
            _Motorista = motorista;
        }

        private static void ValidarProps(int placa, string tipo, string marca, string Modelo, TipoCombustivel combustivel, string cor, DateTime ano, Pessoa motorista)
        {
            DomainException.when(placa < 1, "Informe a placa do veículo");
            DomainException.when(string.IsNullOrEmpty(tipo), "Informe o tipo de veículo");
            DomainException.when(string.IsNullOrEmpty(marca), "Informe a marca do veículo");
            DomainException.when(string.IsNullOrEmpty(Modelo), "Informe o modelo do veículo");
            DomainException.when(combustivel == null, "Especifique o tipo de combustível");
            DomainException.when(string.IsNullOrEmpty(cor), "Informe a cor do veículo");
            DomainException.when(ano == null, "Informe o ano do veículo");
            DomainException.when(motorista == null, "Informe um motorista");
        }
    }
}