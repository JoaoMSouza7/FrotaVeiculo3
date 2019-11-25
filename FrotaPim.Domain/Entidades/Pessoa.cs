using System;

namespace FrotaPim.Domain.Entidades
{
    public class Pessoa : Entidade
    {
        public string Nome { get; private set; }
        public int CPF { get; private set; }
        public Cargo Cargo { get; private set; }
        public Endereco Endereco { get; private set; }
        public DateTime Admissao { get; set; }
        public string Telefone { get; private set; }

        public Pessoa(string nome, int cpf, Cargo cargo, Endereco endereco, DateTime admissao, string fone)
        {
            SetarPropriedades(nome, cpf, cargo, endereco, admissao, fone);
            ValidarProps(nome, cpf, cargo, endereco, admissao, fone);
        }
        public Pessoa()
        {}

        private void SetarPropriedades(string nome, int cpf, Cargo cargo, Endereco endereco, DateTime admissao, string fone)
        {
            Nome = nome;            
            CPF = cpf;
            Cargo = cargo;
            Endereco = endereco;
            Admissao = admissao;
            Telefone = fone;
        }

        private static void ValidarProps(string nome, int cpf, Cargo cargo, Endereco endereco, DateTime admissao, string fone)
        {
            DomainException.when(string.IsNullOrEmpty(nome), "Nome é obrigatório");
            DomainException.when(cpf < 1, "CPF é obrigatório");
            DomainException.when(cargo == null, "Informe o cargo da pessoa");
            DomainException.when(endereco == null, "Endereço é obrigatório");
            DomainException.when(admissao == null, "Informe a data de Admissão");
            DomainException.when(string.IsNullOrEmpty(fone), "Telefone é obrigatório");
        }
    }
}