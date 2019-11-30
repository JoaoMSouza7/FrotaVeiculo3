using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using System;

public class SeguroServico
{
    private readonly IRepositorio<Seguro> _seguroRepository;
    private readonly IRepositorio<Carro> _carroRepository;

    public SeguroServico(IRepositorio<Seguro> seguroRepository, IRepositorio<Carro> carroRepository)
    {
        _seguroRepository = seguroRepository;
        _carroRepository = carroRepository;
    }

    public void Criar(int id, string apolice, string seguradora, int idCarro, DateTime dataContratacao, DateTime validade, decimal valorSeguro)
    {
        var carro = _carroRepository.ConsultarPorID(idCarro);
        DomainException.when(carro == null, "Carro inválido");

        var segur = _seguroRepository.ConsultarPorID(id);
        if (segur == null)
        {
            segur = new Seguro(id, apolice, seguradora, carro, valorSeguro, dataContratacao, validade);
            _seguroRepository.Inserir(segur);
        }
    }

    public Seguro Editar(int id, string apolice, string seguradora, int idCarro, DateTime dataContratacao, DateTime validade, decimal valorSeguro)
    {
        var carro = _carroRepository.ConsultarPorID(idCarro);
        var seguroEditar = new Seguro(id, apolice, seguradora, carro, valorSeguro, dataContratacao, validade);
        _seguroRepository.Editar(seguroEditar);
        return seguroEditar;
    }
}