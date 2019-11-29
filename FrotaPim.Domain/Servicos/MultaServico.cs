using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using System;

public class MultaServico
{
    private readonly IRepositorio<Multas> _multaRepository;
    private readonly IRepositorio<Carro> _carroRepository;
    private readonly IRepositorio<Pessoa> _pessoaRepository;

    public MultaServico(IRepositorio<Multas> multaRepository, IRepositorio<Carro> carroRepository, IRepositorio<Pessoa> pessoaRepository)
    {
        _multaRepository = multaRepository;
        _carroRepository = carroRepository;
        _pessoaRepository = pessoaRepository;
    }

    public void Criar(int id, Pessoa pessoa, string tipoMulta, string gravidade, DateTime dataMulta, decimal valorMulta, Carro carro)
    {
        var car = _carroRepository.ConsultarPorID(carro.Id);
        DomainException.when(car == null, "Carro inválido");

        var people = _pessoaRepository.ConsultarPorID(pessoa.Id);
        DomainException.when(car == null, "Pessoa inválida");

        var mult = _multaRepository.ConsultarPorID(id);
        if (mult == null)
        {
            mult = new Multas(id, people, tipoMulta, gravidade, dataMulta, valorMulta, car);
            _multaRepository.Inserir(mult);
        }
    }

    public Multas Editar(int id, Pessoa pessoa, string tipoMulta, string gravidade, DateTime dataMulta, decimal valorMulta, Carro carro)
    {
        var car = _carroRepository.ConsultarPorID(carro.Id);
        var people = _pessoaRepository.ConsultarPorID(pessoa.Id);

        var multaEditar = new Multas(id, people, tipoMulta, gravidade, dataMulta, valorMulta, car);
        _multaRepository.Editar(multaEditar);
        return multaEditar;
    }
}