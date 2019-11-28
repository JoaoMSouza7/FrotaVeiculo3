using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using System;

public class ManutencaoServico
{   
    private readonly IRepositorio<Manutencao> _manutencaoRepository;
    private readonly IRepositorio<Carro> _carroRepository;

    public ManutencaoServico(IRepositorio<Manutencao> manutencaoRepository, IRepositorio<Carro> carroRepository)
    {
        _manutencaoRepository = manutencaoRepository;
        _carroRepository = carroRepository;
    }

    public void Criar(int id, string descricao, decimal valor, int carroId, DateTime data)
    {
        var carro = _carroRepository.ConsultarPorID(carroId);
        DomainException.when(carro == null, "Carro inválido");

        var manut = _manutencaoRepository.ConsultarPorID(id);
        if (manut == null)
        {
            manut = new Manutencao(id, carro, descricao, valor, data);
            _manutencaoRepository.Inserir(manut);
        }
    }

    public Manutencao Editar(int id, string descricao, decimal valor, int carroId, DateTime data)
    {
        var carro = _carroRepository.ConsultarPorID(carroId);
        var manutEditar = new Manutencao(id, carro, descricao, valor, data);
        _manutencaoRepository.Editar(manutEditar);
        return manutEditar;
    }
}