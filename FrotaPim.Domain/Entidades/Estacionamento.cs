namespace FrotaPim.Domain.Entidades
{
    public class Estacionamento
    {
        public Carro Carro { get; private set; }
        public string Local { get; private set; }
        public decimal Valor { get; private set; }
        public string Descricao { get; private set; }

        public Estacionamento(Carro carro, string local, decimal valor, string descricao)
        {
            SetarPropriedades(carro, local, valor, descricao);
            ValidarProps(carro, local, valor, descricao);
        }

        private void SetarPropriedades(Carro carro, string local, decimal valor, string descricao)
        {
            Carro = carro;
            Local = local;
            Valor = valor;
            Descricao = descricao;
        }

        private static void ValidarProps(Carro carro, string local, decimal valor, string descricao)
        {
            DomainException.when(carro == null, "Informe o Carro");
            DomainException.when(string.IsNullOrEmpty(local), "Informe o local");
            DomainException.when(valor < 1, "Informe o valor");
            DomainException.when(string.IsNullOrEmpty(descricao), "Informe a descrição/motivo");
        }
    }
}