using System;

namespace FrotaPim.Domain.DTOS
{
    public class ContasAPagarDTO
    {
        public string CentroDeCusto { get; set; }
        public string TipoDespesa { get; set; }
        public string Descricao { get; set; }
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
    }
}