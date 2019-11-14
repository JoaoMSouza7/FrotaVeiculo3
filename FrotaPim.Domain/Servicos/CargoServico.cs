using FrotaPim.Domain.DTOS;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Domain.Servicos
{
    public class CargoServico
    {
        private readonly IRepositorio<Cargo> _cargoRepositorio;

        public CargoServico(IRepositorio<Cargo> cargoRepositorio)
        {
            _cargoRepositorio = cargoRepositorio;
        }
        public void InserirCargo(Cargo cargo)
        {
            if(cargo == null)
                throw new DomainException($"O parâmetro {nameof(cargo)} não pode ser nulo");
            
            //var consulta = _cargoRepositorio.ConsultarPorID(cargo.Id);
            //if(consulta.NomeCargo == cargo.NomeCargo)
                //throw new DomainException("Já existe um cargo com este Id");

            _cargoRepositorio.Inserir(cargo);               
        }
    }
}