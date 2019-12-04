namespace FrotaPim.Domain.Entidades
{
    public class Endereco : Entidade
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public int CEP { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco(int id, string rua, int numero, string bairro, int cep, string cidade, string estado)
        {
            SetarPropriedades(id, rua, numero, bairro, cep, cidade, estado);
            ValidarProps(rua, numero, bairro, cep, cidade, estado);
        }
        public Endereco()
        {}

        private void SetarPropriedades(int id, string rua, int numero, string bairro, int cep, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
            this.Id = id;
        }

        private static void ValidarProps(string rua, int numero, string bairro, int cep, string cidade, string estado)
        {
            DomainException.when(string.IsNullOrEmpty(rua), "Informe a rua");
            DomainException.when(numero < 1, "Informe um número válido");
            DomainException.when(string.IsNullOrEmpty(bairro), "Informe o bairro");
            DomainException.when(cep < 1, "CEP é obrigatório");
            DomainException.when(string.IsNullOrEmpty(cidade), "Informe a cidade");
            DomainException.when(string.IsNullOrEmpty(estado), "Informe o estado");
        }
    }
}