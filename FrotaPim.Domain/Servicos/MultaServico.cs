using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using System;

public class MultaServico
{
    private readonly IRepositorio<Multa> _multaRepository;
    private readonly IRepositorio<Carro> _carroRepository;
    private readonly IRepositorio<Pessoa> _pessoaRepository;

    public MultaServico(IRepositorio<Multa> multaRepository, IRepositorio<Carro> carroRepository, IRepositorio<Pessoa> pessoaRepository)
    {
        _multaRepository = multaRepository;
        _carroRepository = carroRepository;
        _pessoaRepository = pessoaRepository;
    }

    public void Criar(int id, int idPessoa, string tipoMulta, string gravidade, DateTime dataMulta, string valorMulta, int idCarro)
    {
        var car = _carroRepository.ConsultarPorID(idCarro);
        DomainException.when(car == null, "Carro inválido");

        var people = _pessoaRepository.ConsultarPorID(idPessoa);
        DomainException.when(car == null, "Pessoa inválida");

        var mult = _multaRepository.ConsultarPorID(id);
        if (mult == null)
        {
            mult = new Multa(id, people, tipoMulta, gravidade, dataMulta, valorMulta, car);
            _multaRepository.Inserir(mult);
        }
    }

    public Multa Editar(int id, int pessoaId, string tipoMulta, string gravidade, DateTime dataMulta, string valorMulta, int carroId)
    {
        var car = _carroRepository.ConsultarPorID(carroId);
        var people = _pessoaRepository.ConsultarPorID(pessoaId);

        var multaEditar = new Multa(id, people, tipoMulta, gravidade, dataMulta, valorMulta, car);
        _multaRepository.Editar(multaEditar);
        return multaEditar;
    }
}