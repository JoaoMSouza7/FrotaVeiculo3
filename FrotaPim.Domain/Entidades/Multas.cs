namespace FrotaPim.Domain.Entidades
{
    public class Multas
    {
        public Motorista _Motorista { get; set; }
        public string Gravidade { get; set; }
        public DateTime DataMulta { get; set; }
        public decimal ValorMulta { get; set; }
        public Carro _Carro { get; set; }
        public StatusMulta Status { get; set; }

        public Multas(Motorista motorista, string gravidade, DateTime dataMulta, decimal valorMulta, Carro carro, StatusMulta status)
        {
            SetarPropriedades(motorista, dataMulta, valorMulta, carro, status);
            ValidarProps(motorista, dataMulta, valorMulta, carro, status);
        }

        private void SetarPropriedades(Motorista motorista, DateTime dataMulta, decimal valorMulta, Carro carro, StatusMulta status)
        {
            _Motorista = motorista;
            Gravidade = Gravidade;
            DataMulta = dataMulta;
            ValorMulta = valorMulta;
            _Carro = carro;
            Status = status;
        }

        private static void ValidarProps(Motorista motorista, DateTime dataMulta, decimal valorMulta, Carro carro, StatusMulta status)
        {
            DomainException.when(motorista == null, "Informe o motorista");
            DomainException.when(dataMulta == null, "Informe a data em que a multa foi realizada");
            DomainException.when(valorMulta < 1, "Informe o valor da multa");
            DomainException.when(carro == null, "Informe o carro que recebeu a multa");
            DomainException.when(status == null, "Informe o status da multa");
        }
    }
}