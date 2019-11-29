using System;

namespace FrotaPim.Domain.Entidades
{
    public class Multas : Entidade
    {
        public Pessoa Pessoa { get; private set; }
        public string Gravidade { get; private set; }
        public string TipoMulta { get; set; }
        public DateTime DataMulta { get; private set; }
        public decimal ValorMulta { get; private set; }
        public Carro Carro { get; private set; }

        public Multas(int id, Pessoa pessoa, string tipoMulta, string gravidade, DateTime dataMulta, decimal valorMulta, Carro carro)
        {
            SetarPropriedades(id, pessoa, tipoMulta, dataMulta, valorMulta, carro);
            ValidarProps(pessoa, tipoMulta, dataMulta, valorMulta, carro);
        }
        public Multas()
        {}

        private void SetarPropriedades(int id, Pessoa pessoa, string tipoMulta, DateTime dataMulta, decimal valorMulta, Carro carro)
        {
            Pessoa = pessoa;
            Gravidade = Gravidade;
            DataMulta = dataMulta;
            ValorMulta = valorMulta;
            Carro = carro;
            TipoMulta = tipoMulta;
            this.Id = id;
        }

        private static void ValidarProps(Pessoa pessoa, string tipoMulta, DateTime dataMulta, decimal valorMulta, Carro carro)
        {
            DomainException.when(pessoa == null, "Informe o motorista");
            DomainException.when(dataMulta == null, "Informe a data em que a multa foi realizada");
            DomainException.when(valorMulta < 1, "Informe o valor da multa");
            DomainException.when(carro == null, "Informe o carro que recebeu a multa");
            DomainException.when(string.IsNullOrWhiteSpace(tipoMulta), "Informe o tipo de multa");
        }
    }
}