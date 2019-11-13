namespace FrotaPim.Domain.DTOS
{
    public class EnderecoDTO
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}