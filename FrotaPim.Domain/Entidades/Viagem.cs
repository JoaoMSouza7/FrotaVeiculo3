using System;

namespace FrotaPim.Domain.Entidades
{
    public class Viagem : Entidade
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public decimal KM { get; set; }
        public DateTime DataViagem { get; set; }
        public string Valor { get; set; }
        public Carro Carro { get; set; }
        public Pessoa Pessoa { get; set; }

        public Viagem(int id, string origem, string destino, decimal km, DateTime dataViagem, string valor, Carro carro, Pessoa pessoa)
        {
            SetarProps(id, origem, destino, km, dataViagem, valor, carro, pessoa);
            ValidarProps(id, origem, destino, km, valor, carro, pessoa);
        }
        public Viagem()
        {

        }

        private void SetarProps(int id, string origem, string destino, decimal km, DateTime dataViagem, string valor, Carro carro, Pessoa pessoa)
        {
            this.Id = id;
            Origem = origem;
            Destino = destino;
            KM = km;
            Valor = valor;
            Carro = carro;
            Pessoa = pessoa;
            DataViagem = dataViagem;
        }

        private void ValidarProps(int id, string origem, string destino, decimal km, string valor, Carro carro, Pessoa pessoa)
        {
            DomainException.when(string.IsNullOrEmpty(origem), "Informe a Origem");
            DomainException.when(string.IsNullOrEmpty(destino), "Informe o Destino");
            DomainException.when(km < 1, "Informe a quilometragem");
            DomainException.when(string.IsNullOrEmpty(valor), "Informe o valor da Vigem");
            DomainException.when(carro == null, "Informe o veículo");
            DomainException.when(pessoa == null, "Informe o motorista");
        }
    }
}