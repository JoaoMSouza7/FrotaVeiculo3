using System;

namespace FrotaPim.Domain.Entidades
{
    public class ContasAPagar
    {
        public string CentroDeCusto { get; set; }
        public string TipoDespesa { get; set; }
        public string Descricao { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }

        public ContasAPagar(string centroDeCusto, string tipoDespesa, string descricao, DateTime vencimento, decimal valor)
        {
            SetarPropriedades(centroDeCusto, tipoDespesa, descricao, vencimento, valor);
            ValidarProps(centroDeCusto, tipoDespesa, descricao, vencimento, valor);
        }

        private void SetarPropriedades(string centroDeCusto, string tipoDespesa, string descricao, DateTime vencimento, decimal valor)
        {
            CentroDeCusto = centroDeCusto;
            TipoDespesa = tipoDespesa;
            Descricao = descricao;
            Vencimento = vencimento;
            Valor = valor;
        }

        private static void ValidarProps(string centroDeCusto, string tipoDespesa, string descricao, DateTime vencimento, decimal valor)
        {
            DomainException.when(string.IsNullOrEmpty(centroDeCusto), "Informe o centro de custo");
            DomainException.when(string.IsNullOrEmpty(tipoDespesa), "Informe o tipo de despesa");
            DomainException.when(string.IsNullOrEmpty(descricao), "Informe a descrição da conta a ser paga");
            DomainException.when(vencimento == null, "Informe a data de vencimento da conta a ser paga");
            DomainException.when(valor < 1, "Informe um valor válido");
        }
    }
}