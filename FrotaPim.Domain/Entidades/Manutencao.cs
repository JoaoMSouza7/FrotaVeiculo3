using System;

namespace FrotaPim.Domain.Entidades
{
    public class Manutencao : Entidade
    {
        public string DescricaoManutencao { get; private set; }
        public decimal Valor { get; private set; }
        public Carro Carro { get; set; }
        public DateTime Data { get; private set; }

        public Manutencao(int id, Carro carro, string descricaoManutencao, decimal valor, DateTime data)
        {
            SetarPropriedades(id, carro, descricaoManutencao, valor, data);
            ValidarProps(descricaoManutencao, valor, data);
        }
        public Manutencao()
        {}

        private void SetarPropriedades(int id, Carro carro, string descricaoManutencao, decimal valor, DateTime data)
        {
            DescricaoManutencao = descricaoManutencao;
            Valor = valor;
            Carro = carro;
            Data = data;
            this.Id = id;
        }

        private static void ValidarProps(string descricaoManutencao, decimal valor, DateTime data)
        {
            DomainException.when(string.IsNullOrEmpty(descricaoManutencao), "Informe a descrição da manutenção");
            DomainException.when(valor < 1, "Informe um valor válido");
            DomainException.when(data == null, "Informe uma data válida");
        }
    }
}