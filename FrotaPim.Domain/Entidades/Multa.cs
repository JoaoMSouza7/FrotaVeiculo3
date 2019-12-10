using System;

namespace FrotaPim.Domain.Entidades
{
    public class Multa : Entidade
    {
        public Pessoa Pessoa { get; private set; }
        public string TipoMulta { get; set; }
        public string Gravidade { get; private set; }
        public DateTime DataMulta { get; private set; }
        public string ValorMulta { get; private set; }
        public Carro Carro { get; private set; }

        public Multa(int id, Pessoa pessoa, string tipoMulta, string gravidade, DateTime dataMulta, string valorMulta,  Carro carro)
        {
            SetarPropriedades(id, pessoa, tipoMulta, gravidade, dataMulta, valorMulta, carro);
            ValidarProps(pessoa, tipoMulta, dataMulta, valorMulta, carro);
        }
        public Multa()
        {
            Carro = new Carro();
            Pessoa = new Pessoa();
        }

        private void SetarPropriedades(int id, Pessoa pessoa, string tipoMulta, string gravidade, DateTime dataMulta, string valorMulta, Carro carro)
        {
            Pessoa = pessoa;          
            DataMulta = dataMulta;
            ValorMulta = valorMulta;
            Carro = carro;
            TipoMulta = tipoMulta;
            Gravidade = gravidade;
            this.Id = id;
        }

        private static void ValidarProps(Pessoa pessoa, string tipoMulta, DateTime dataMulta, string valorMulta, Carro carro)
        {
            DomainException.when(pessoa == null, "Informe o motorista");
            DomainException.when(dataMulta == null, "Informe a data em que a multa foi realizada");
            DomainException.when(string.IsNullOrWhiteSpace(valorMulta), "Informe o valor da multa");
            DomainException.when(carro == null, "Informe o carro que recebeu a multa");
            DomainException.when(string.IsNullOrWhiteSpace(tipoMulta), "Informe o tipo de multa");
        }
    }
}