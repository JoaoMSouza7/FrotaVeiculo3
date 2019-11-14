using FrotaPim.Domain.DTOS;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Domain.Servicos
{
    public class CarroServico
    {
        private readonly IRepositorio<Carro> _carroRepositorio;
        private readonly IRepositorio<Pessoa> _pessoaRepositorio;
        public readonly IRepositorio<TipoCombustivel> _combustivel;

        public CarroServico(IRepositorio<Carro> carroRepositorio, IRepositorio<Pessoa> pessoaRepositorio, IRepositorio<TipoCombustivel> combustivel)
        {
            _carroRepositorio = carroRepositorio;
            _pessoaRepositorio = pessoaRepositorio;
            _combustivel = combustivel;
        }
        public void ConsultarVeículo(CarroDTO dto)
        {
            var carro = _carroRepositorio.ConsultarPorID(dto.IDCarro);
            DomainException.when(carro == null, "Carro inválido");
        }
    }
}