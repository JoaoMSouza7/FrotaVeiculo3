using System;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Domain.DTOS
{
    public class PessoaDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CPF { get; set; }
        public Cargo _Cargo { get; set; }
        public Endereco _Endereco { get; set; }
        public DateTime Admissao { get; set; }
        public string Telefone { get; set; }
    }
}