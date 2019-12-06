
using System;

namespace FrotaPim.Domain.Entidades
{
    public class Carro : Entidade
    {
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Combustivel { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }

        public Carro(int id, string placa, string tipo, string marca, string Modelo, string combustivel, string cor, int ano)
        {
            SetarPropriedades(id, placa, tipo, marca, Modelo, combustivel, cor, ano);
            ValidarProps(placa, tipo, marca, Modelo, combustivel, cor, ano);
        }
        public Carro()
        {}

        private void SetarPropriedades(int id, string placa, string tipo, string marca, string modelo, string combustivel, string cor, int ano)
        {
            this.Id = id;
            Placa = placa;
            Tipo = tipo;
            Marca = marca;
            Modelo = modelo;
            Combustivel = combustivel;
            Cor = cor;
            Ano = ano;
        }

        private static void ValidarProps(string placa, string tipo, string marca, string Modelo, string combustivel, string cor, int ano)
        {
            DomainException.when(string.IsNullOrEmpty(placa), "Informe a placa do veículo");
            DomainException.when(string.IsNullOrEmpty(tipo), "Informe o tipo de veículo");
            DomainException.when(string.IsNullOrEmpty(marca), "Informe a marca do veículo");
            DomainException.when(string.IsNullOrEmpty(Modelo), "Informe o modelo do veículo");
            DomainException.when(combustivel == null, "Especifique o tipo de combustível");
            DomainException.when(string.IsNullOrEmpty(cor), "Informe a cor do veículo");
            DomainException.when(ano < 1 || ano > 2020, "Informe o ano do veículo");
        }
    }
}