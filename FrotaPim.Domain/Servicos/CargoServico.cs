using FrotaPim.Domain.DTOS;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Domain.Servicos
{
    public class CargoServico
    {
        private readonly IRepositorio<Cargo> _cargoRepositorio;
        private readonly IRepositorio<Pessoa> _pessoaRepositorio;

        public CargoServico(IRepositorio<Cargo> cargoRepositorio, IRepositorio<Pessoa> pessoaRepositorio)
        {
            _cargoRepositorio = cargoRepositorio;
            _pessoaRepositorio = pessoaRepositorio;
        }
        public void InserirCargo(CargoDTO dto)
        {
            var cargo = _cargoRepositorio.ConsultarPorID(dto.C)
        }
    }
}