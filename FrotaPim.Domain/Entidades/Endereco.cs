namespace FrotaPim.Domain.Entidades
{
    public class Endereco : Entidade
    {
        public string Rua { get; private set; }
        public int Numero { get; private set; }
        public string Bairro { get; private set; }
        public int CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        public Endereco(string rua, int numero, string bairro, int cep, string cidade, string estado)
        {
            SetarPropriedades(rua, numero, bairro, cep, cidade, estado);
            ValidarProps(rua, numero, bairro, cep, cidade, estado);
        }
        public Endereco()
        {}

        private void SetarPropriedades(string rua, int numero, string bairro, int cep, string cidade, string estado)
        {
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            CEP = cep;
            Cidade = cidade;
            Estado = estado;
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