using FrotaPim.Domain.Entidades;

namespace FrotaPim.Domain.DTOS
{
    public class CargoDTO
    {
        public Pessoa _Motorista { get; set; }
        public Pessoa _Funcionario { get; set; }
        public Pessoa _Administrador { get; set; }
    }
}