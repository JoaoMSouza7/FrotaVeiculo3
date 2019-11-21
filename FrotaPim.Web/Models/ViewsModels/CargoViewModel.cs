using System.ComponentModel.DataAnnotations;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class CargoViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Descricao { get; set; }  
    }
}
//name="NomeCargo" id="NomeCargo"