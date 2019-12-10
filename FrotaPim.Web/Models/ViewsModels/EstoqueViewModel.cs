using System;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class EstoqueViewModel
    {
        public int IdEstoque { get; set; }
        public string NomePeca { get; set; }
        public string Descricao { get; set; }
        public string Fornecedor { get; set; }
        public string ValorPeca { get; set; }
        public int Quantidade { get; set; }
    }
}