using System;

namespace FrotaPim.Domain.Entidades
{
    public class Pessoa
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public int CPF { get; private set; }
        public Cargo _Cargo { get; private set; }
        public Endereco _Endereco { get; private set; }
        public DateTime Admissao { get; set; }
        public string Telefone { get; private set; }

        public Pessoa(int id, string nome, int cpf, Cargo cargo, Endereco endereco, DateTime admissao, string fone)
        {
            SetarPropriedades(id, nome, cpf, cargo, endereco, admissao, fone);
            ValidarProps(id, nome, cpf, cargo, endereco, admissao, fone);
        }

        private void SetarPropriedades(int id, string nome, int cpf, Cargo cargo, Endereco endereco, DateTime admissao, string fone)
        {
            Id = id;
            Nome = nome;            
            CPF = cpf;
            _Cargo = cargo;
            _Endereco = endereco;
            Admissao = admissao;
            Telefone = fone;
        }

        private static void ValidarProps(int id, string nome, int cpf, Cargo cargo, Endereco endereco, DateTime admissao, string fone)
        {
            DomainException.when(id < 1, "Informe um ID válido");
            DomainException.when(string.IsNullOrEmpty(nome), "Nome é obrigatório");
            DomainException.when(cpf < 1, "CPF é obrigatório");
            DomainException.when(cargo == null, "Informe o cargo da pessoa");
            DomainException.when(endereco == null, "Endereço é obrigatório");
            DomainException.when(admissao == null, "Informe a data de Admissão");
            DomainException.when(string.IsNullOrEmpty(fone), "Telefone é obrigatório");
        }
    }
}