using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using System;

public class PessoaServico
{
    private readonly IRepositorio<Pessoa> _pessoaRepository;
    private readonly IRepositorio<Cargo> _cargoRepository;
    private readonly IRepositorio<Endereco> _enderecoRepository;

    public PessoaServico(IRepositorio<Pessoa> pessoaRepository, IRepositorio<Cargo> cargoRepository, IRepositorio<Endereco> enderecoRepository)
    {
        _pessoaRepository = pessoaRepository;
        _cargoRepository = cargoRepository;
        _enderecoRepository = enderecoRepository;
    }

    public void Criar(int id, string nome, int cpf, int idCargo, int enderecoId, DateTime admissao, string telefone)
    {
        var carg = _cargoRepository.ConsultarPorID(idCargo);
        DomainException.when(carg == null, "Cargo inválido");

        var enderec = _enderecoRepository.ConsultarPorID(enderecoId);

        var pessoa = _pessoaRepository.ConsultarPorID(id);
        if (pessoa == null)
        {
            pessoa = new Pessoa(id, nome, cpf, carg, enderec, admissao, telefone);
            _pessoaRepository.Inserir(pessoa);
        }
    }

    public Pessoa Editar(int id, string nome, int cpf, int IdCargo, int enderecoId, DateTime admissao, string telefone, string rua, int numero, string bairro, int cep, string cidade, string estado)
    {
        var cargo = _cargoRepository.ConsultarPorID(IdCargo);
        Endereco endereco = new Endereco(enderecoId, rua, numero, bairro, cep, cidade, estado);

        Pessoa pessoaEditar = new Pessoa(id, nome, cpf, cargo, endereco, admissao, telefone);

        _pessoaRepository.Editar(pessoaEditar);
        return pessoaEditar;
    }
}