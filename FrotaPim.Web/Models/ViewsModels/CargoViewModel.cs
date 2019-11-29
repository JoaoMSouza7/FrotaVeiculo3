using System.ComponentModel.DataAnnotations;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class CargoViewModel
    {
        public int CargoId { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Descricao { get; set; }  
    }
}
//name="NomeCargo" id="NomeCargo"
