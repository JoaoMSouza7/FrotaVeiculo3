using System;

namespace FrotaPim.Domain.Entidades
{
    public class Seguro : Entidade
    {
        public string Apolice { get; private set; }
        public string Seguradora { get; private set; }
        public Carro Carro { get; private set; }
        public decimal ValorSeguro { get; set; }
        public DateTime DataContratacao { get; private set; }
        public DateTime DataValidade { get; private set; }

        public Seguro(int id, string apolice, string seguradora, Carro carro, decimal valorSeguro, DateTime dataContratacao, DateTime validade)
        {
            SetarPropriedades(id, apolice, seguradora, carro, valorSeguro, dataContratacao, validade);
            ValidarProps(apolice, seguradora, carro, valorSeguro, dataContratacao, validade);
        }
        public Seguro(){}
        private void SetarPropriedades(int id, string apolice, string seguradora, Carro carro, decimal valorSeguro, DateTime dataContratacao, DateTime validade)
        {
            Apolice = apolice;
            Seguradora = seguradora;
            Carro = carro;
            ValorSeguro = valorSeguro;
            DataContratacao = dataContratacao;
            DataValidade = validade;
            this.Id = id;
        }

        private static void ValidarProps(string apolice, string seguradora, Carro carro, decimal valorSeguro, DateTime dataContratacao, DateTime validade)
        {
            DomainException.when(string.IsNullOrEmpty(apolice), "Informe a Apolice");
            DomainException.when(string.IsNullOrEmpty(seguradora), "Informe a seguradora");
            DomainException.when(carro == null, "Informe o veículo");
            DomainException.when(valorSeguro < 1, "Informe o valor do Seguro");
            DomainException.when(dataContratacao == null, "Informe a data da contratação");
            DomainException.when(validade == null, "Informe a validade do seguro");

        }
    }
}