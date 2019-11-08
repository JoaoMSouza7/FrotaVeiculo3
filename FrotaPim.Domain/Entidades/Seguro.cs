using System;

namespace FrotaPim.Domain.Entidades
{
    public class Seguro
    {
        public string Apolice { get; private set; }
        public string Seguradora { get; private set; }
        public Carro _Carro { get; private set; }
        public DateTime DataContratacao { get; private set; }
        public DateTime DataValidade { get; private set; }
        public StatusSeguro Status { get; private set; }

        public Seguro(string apolice, string seguradora, Carro carro, DateTime dataContratacao, DateTime validade, StatusSeguro status)
        {
            SetarPropriedades(apolice, seguradora, carro, dataContratacao, validade, status);
            ValidarProps(apolice, seguradora, carro, dataContratacao, validade, status);
        }

        private void SetarPropriedades(string apolice, string seguradora, Carro carro, DateTime dataContratacao, DateTime validade, StatusSeguro status)
        {
            Apolice = apolice;
            Seguradora = seguradora;
            _Carro = carro;
            DataContratacao = dataContratacao;
            DataValidade = validade;
            Status = status;
        }

        private static void ValidarProps(string apolice, string seguradora, Carro carro, DateTime dataContratacao, DateTime validade, StatusSeguro status)
        {
            DomainException.when(string.IsNullOrEmpty(apolice), "Informe a Apolice");
            DomainException.when(string.IsNullOrEmpty(seguradora), "Informe a seguradora");
            DomainException.when(carro == null, "Informe o veículo");
            DomainException.when(dataContratacao == null, "Informe a data da contratação");
            DomainException.when(validade == null, "Informe a validade do seguro");
            DomainException.when(status == null, "Deve possuir um status");

        }
    }
}