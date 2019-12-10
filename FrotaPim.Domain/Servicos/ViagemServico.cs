using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using System;

public class ViagemServico
{
    private readonly IRepositorio<Viagem> _viagemRepository;
    private readonly IRepositorio<Carro> _carroRepository;
    private readonly IRepositorio<Pessoa> _pessoaRepository;

    public ViagemServico(IRepositorio<Pessoa> pessoaRepository, IRepositorio<Carro> carroRepository, IRepositorio<Viagem> viagemRepository)
    {
        _pessoaRepository = pessoaRepository;
        _carroRepository = carroRepository;
        _viagemRepository = viagemRepository;
    }

    public void Criar(int id, string origem, string destino, decimal kms, DateTime dataViagem, string valor, int idCarro, int idPessoa)
    {
        var carro = _carroRepository.ConsultarPorID(idCarro);
        DomainException.when(carro == null, "Carro inválido");

        var pessoa = _pessoaRepository.ConsultarPorID(idPessoa);
        DomainException.when(pessoa == null, "Pessoa inválida");

        var viagem = _viagemRepository.ConsultarPorID(id);
        if (viagem == null)
        {
            viagem = new Viagem(id, origem, destino, kms, dataViagem, valor, carro, pessoa);
            _viagemRepository.Inserir(viagem);
        }
    }

    public Viagem Editar(int id, string origem, string destino, decimal kms, DateTime dataViagem, string valor, int idCarro, int idPessoa)
    {
        var carro = _carroRepository.ConsultarPorID(idCarro);
        var pessoa = _pessoaRepository.ConsultarPorID(idPessoa);
        var viagemEdit = new Viagem(id, origem, destino, kms, dataViagem, valor, carro, pessoa);
        _viagemRepository.Editar(viagemEdit);
        return viagemEdit;
    }
}