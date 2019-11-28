using System;

namespace FrotaPim.Domain.Entidades
{
    public class Estoque : Entidade
    {
        public string NomePeca { get; set; }
        public string Descricao { get; set; }
        public string Fornecedor { get; set; }
        public decimal ValorPeca { get; set; }
        public int Quantidade { get; set; }

        public Estoque(int id, string nomePeca, string descricao, string Fornecedor, decimal valorPeca, int quantidade)
        {
            SetarPropriedades(id, nomePeca, descricao, Fornecedor, valorPeca, quantidade);
            ValidarProps(nomePeca, descricao, Fornecedor, valorPeca, quantidade);
        }
        public Estoque()
        {}

        private void SetarPropriedades(int id, string nomePeca, string descricao, string fornecedor, decimal valorPeca, int quantidade)
        {
            NomePeca = nomePeca;
            Descricao = descricao;
            Fornecedor = fornecedor;
            ValorPeca = valorPeca;
            Quantidade = quantidade;
            this.Id = id;
        }

        private static void ValidarProps(string nomePeca, string descricao, string Fornecedor, decimal valorPeca, int quantidade)
        {
            DomainException.when(string.IsNullOrEmpty(nomePeca), "Informe o nome da peça");
            DomainException.when(string.IsNullOrEmpty(descricao), "Informe a descrição da peça");
            DomainException.when(string.IsNullOrEmpty(Fornecedor), "Informe o fornecedor");
            DomainException.when(valorPeca < 1, "Informe um valor válido");
            DomainException.when(quantidade < 1, "Informe uma quantidade válida");
        }
    }
}