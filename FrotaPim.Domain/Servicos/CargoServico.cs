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
        public void InserirCargo(int id, string nome, string descricao)
        {
            var cargo = _cargoRepositorio.ConsultarPorID(id);
            if(cargo == null)
            {
                cargo = new Cargo { NomeCargo = nome, Descricao = descricao};
                _cargoRepositorio.Inserir(cargo);
            }
            else
            {
                cargo.NomeCargo = nome;
                cargo.Descricao = descricao;
                _cargoRepositorio.Editar(cargo);
            }         
        }
        public void ApagarCargo(int id)
        {
            var cargoDlt = _cargoRepositorio.ConsultarPorID(id);
            if(cargoDlt != null)
            {
                _cargoRepositorio.Deletar(cargoDlt);
            }
        }
    }
}