using FrotaPim.Domain.Entidades;

namespace FrotaPim.Domain.DTOS
{
    public class EstacionamentoDTO
    {
        public Carro _Carro { get; private set; }
        public string Local { get; private set; }
        public decimal Valor { get; private set; }
        public string Descricao { get; private set; }
    }
}