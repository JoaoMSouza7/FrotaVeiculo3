using System;

namespace FrotaPim.Domain.Entidades
{
    public class ContasAPagar : Entidade
    {
        public string CentroDeCusto { get; set; }
        public string TipoDespesa { get; set; }
        public string Descricao { get; set; }
        public DateTime Vencimento { get; set; }
        public string Valor { get; set; }

        public ContasAPagar(int id, string centroDeCusto, string tipoDespesa, string descricao, DateTime vencimento, string valor)
        {
            SetarPropriedades(id, centroDeCusto, tipoDespesa, descricao, vencimento, valor);
            ValidarProps(centroDeCusto, tipoDespesa, descricao, vencimento, valor);
        }
        public ContasAPagar()
        {}

        private void SetarPropriedades(int id, string centroDeCusto, string tipoDespesa, string descricao, DateTime vencimento, string valor)
        {
            CentroDeCusto = centroDeCusto;
            TipoDespesa = tipoDespesa;
            Descricao = descricao;
            Vencimento = vencimento;
            Valor = valor;
            this.Id = id;
        }

        private static void ValidarProps(string centroDeCusto, string tipoDespesa, string descricao, DateTime vencimento, string valor)
        {
            DomainException.when(string.IsNullOrEmpty(centroDeCusto), "Informe o centro de custo");
            DomainException.when(string.IsNullOrEmpty(tipoDespesa), "Informe o tipo de despesa");
            DomainException.when(string.IsNullOrEmpty(descricao), "Informe a descrição da conta a ser paga");
            DomainException.when(vencimento == null, "Informe a data de vencimento da conta a ser paga");
            DomainException.when(string.IsNullOrEmpty(valor), "Informe um valor válido");
        }
    }
}