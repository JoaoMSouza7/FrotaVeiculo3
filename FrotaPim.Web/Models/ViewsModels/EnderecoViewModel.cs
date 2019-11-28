namespace FrotaPim.Web.Models.ViewsModels
{
    public class EnderecoViewModel
    {
        public int IdEndereco { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}