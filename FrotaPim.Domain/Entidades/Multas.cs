using System;

namespace FrotaPim.Domain.Entidades
{
    public class Multas : Entidade
    {
        public Pessoa Pessoa { get; private set; }
        public string Gravidade { get; private set; }
        public DateTime DataMulta { get; private set; }
        public decimal ValorMulta { get; private set; }
        public Carro Carro { get; private set; }
        public bool Status { get; private set; }

        public Multas(Pessoa pessoa, string gravidade, DateTime dataMulta, decimal valorMulta, Carro carro, bool status)
        {
            SetarPropriedades(pessoa, dataMulta, valorMulta, carro, status);
            ValidarProps(pessoa, dataMulta, valorMulta, carro);
        }
        public Multas()
        {}

        private void SetarPropriedades(Pessoa pessoa, DateTime dataMulta, decimal valorMulta, Carro carro, bool status)
        {
            Pessoa = pessoa;
            Gravidade = Gravidade;
            DataMulta = dataMulta;
            ValorMulta = valorMulta;
            Carro = carro;
            Status = status;
        }

        private static void ValidarProps(Pessoa pessoa, DateTime dataMulta, decimal valorMulta, Carro carro)
        {
            DomainException.when(pessoa == null, "Informe o motorista");
            DomainException.when(dataMulta == null, "Informe a data em que a multa foi realizada");
            DomainException.when(valorMulta < 1, "Informe o valor da multa");
            DomainException.when(carro == null, "Informe o carro que recebeu a multa");
        }
    }
}