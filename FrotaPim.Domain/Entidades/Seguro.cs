using System;

namespace FrotaPim.Domain.Entidades
{
    public class Seguro : Entidade
    {
        public string Apolice { get; private set; }
        public string Seguradora { get; private set; }
        public Carro Carro { get; private set; }
        public DateTime DataContratacao { get; private set; }
        public DateTime DataValidade { get; private set; }

        public Seguro(string apolice, string seguradora, Carro carro, DateTime dataContratacao, DateTime validade)
        {
            SetarPropriedades(apolice, seguradora, carro, dataContratacao, validade);
            ValidarProps(apolice, seguradora, carro, dataContratacao, validade);
        }
        public Seguro(){}
        private void SetarPropriedades(string apolice, string seguradora, Carro carro, DateTime dataContratacao, DateTime validade)
        {
            Apolice = apolice;
            Seguradora = seguradora;
            Carro = carro;
            DataContratacao = dataContratacao;
            DataValidade = validade;
        }

        private static void ValidarProps(string apolice, string seguradora, Carro carro, DateTime dataContratacao, DateTime validade)
        {
            DomainException.when(string.IsNullOrEmpty(apolice), "Informe a Apolice");
            DomainException.when(string.IsNullOrEmpty(seguradora), "Informe a seguradora");
            DomainException.when(carro == null, "Informe o veículo");
            DomainException.when(dataContratacao == null, "Informe a data da contratação");
            DomainException.when(validade == null, "Informe a validade do seguro");

        }
    }
}