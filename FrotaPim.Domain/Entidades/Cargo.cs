using FrotaPim.Domain;
using System;

namespace FrotaPim.Domain.Entidades
{
    public class Cargo : Entidade
    {
        public string NomeCargo { get; set; }
        public string Descricao { get; set; }

        public Cargo()
        { }
        public Cargo(int id, string NomeCargo, string Descricao)
        {
            this.NomeCargo = NomeCargo;
            this.Descricao = Descricao;
            this.Id = id;

            DomainException.when(String.IsNullOrWhiteSpace(NomeCargo), "Nome do cargo é obrigatório");
            DomainException.when(String.IsNullOrWhiteSpace(Descricao), "Informe a descrição do cargo");

        }
    }
}