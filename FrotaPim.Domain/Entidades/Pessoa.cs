using System;

namespace FrotaPim.Domain.Entidades
{
    public class Pessoa : Entidade
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public Cargo Cargo { get; set; }
        public Endereco Endereco { get; set; }
        public DateTime Admissao { get; set; }
        public string Telefone { get; set; }

        public Pessoa(int id, string nome, int cpf, Cargo cargo, Endereco endereco, DateTime admissao, string telefone)
        {
            SetarPropriedades(id, nome, cpf, cargo, endereco, admissao, telefone);
            ValidarProps(nome, cpf, cargo, endereco, admissao, telefone);
        }
        public Pessoa()
        {}

        private void SetarPropriedades(int id, string nome, int cpf, Cargo cargo, Endereco endereco, DateTime admissao, string telefone)
        {
            this.Id = id;
            Nome = nome;            
            CPF = cpf;
            Cargo = cargo;
            Endereco = endereco;
            Admissao = admissao;
            Telefone = telefone;
        }

        private static void ValidarProps(string nome, int cpf, Cargo cargo, Endereco endereco, DateTime admissao, string telefone)
        {
            DomainException.when(string.IsNullOrEmpty(nome), "Nome é obrigatório");
            DomainException.when(cpf < 1, "CPF é obrigatório");
            DomainException.when(cargo == null, "Informe o cargo da pessoa");
            //DomainException.when(endereco == null, "Endereço é obrigatório");
            DomainException.when(admissao == null, "Informe a data de Admissão");
            DomainException.when(string.IsNullOrEmpty(telefone), "Telefone é obrigatório");
        }
    }
}