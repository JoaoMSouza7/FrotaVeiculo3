using System;

namespace FrotaPim.Domain.DTOS
{
    public class EstoqueDTO
    {
        public DateTime DataEntrada { get; set; }
        public string NomePeca { get; set; }
        public string Descricao { get; set; }
        public string Fornecedor { get; set; }
        public int ValorPeca { get; set; }
        public int Quantidade { get; set; }
    }
}