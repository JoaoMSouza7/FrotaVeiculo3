using System;

namespace FrotaPim.Domain.Entidades
{
    public class Manutencao
    {
        public string DescricaoManutencao { get; private set; }
        public decimal Valor { get; set; }
        public Carro _Carro { get; private set; }
        public DateTime Data { get; private set; }

        public Manutencao(string descricaoManutencao, decimal valor, Carro carro, DateTime data)
        {
            SetarPropriedades(descricaoManutencao, valor, carro, data);
            ValidarProps(descricaoManutencao, valor, carro, data);
        }

        private void SetarPropriedades(string descricaoManutencao, decimal valor, Carro carro, DateTime data)
        {
            DescricaoManutencao = descricaoManutencao;
            Valor = valor;
            _Carro = carro;
            Data = data;
        }

        private static void ValidarProps(string descricaoManutencao, decimal valor, Carro carro, DateTime data)
        {
            DomainException.when(string.IsNullOrEmpty(descricaoManutencao), "Informe a descrição da manutenção");
            DomainException.when(valor < 1, "Informe um valor válido");
            DomainException.when(carro == null, "Informe o veículo");
            DomainException.when(data == null, "Informe uma data válida");
        }
    }
}