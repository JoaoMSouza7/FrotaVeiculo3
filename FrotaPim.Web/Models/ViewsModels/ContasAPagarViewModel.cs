using System;
using System.ComponentModel.DataAnnotations;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class ContasAPagarViewModel
    {
        public int IdConta { get; set; }
        public string CentroDeCusto { get; set; }
        public string TipoDespesa { get; set; }
        public string Descricao { get; set; }
        [DisplayFormat(DataFormatString = "{0:MMM dd, yyyy}")]
        public DateTime Vencimento { get; set; }
        public decimal Valor { get; set; }
    }
}