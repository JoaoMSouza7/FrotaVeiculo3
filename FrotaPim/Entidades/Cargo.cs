using FrotaPim.Domain;
namespace FrotaPim.Domain.Entidades
{
    public class Cargo : Entidade
    {
        public string NomeCargo { get; set; }
        public string Descricao { get; set; }

        public Cargo(int Id, string NomeCargo, string Descricao)
        {
            SetarPropriedades(Id, NomeCargo, Descricao);
        }
        public Cargo()
        {}

        private void SetarPropriedades(int Id, string NomeCargo, string Descricao)
        {
            this.Id = Id;
            this.NomeCargo = NomeCargo;
            this.Descricao = Descricao;
        }
        private void ValidarPropriedades(int Id, string NomeCargo, string Descricao)
        {
            DomainException.when(Id < 1, "Id inválido");
            DomainException.when(string.IsNullOrWhiteSpace(NomeCargo), "Nome do cargo é obrigatório");
            DomainException.when(string.IsNullOrWhiteSpace(Descricao), "Informe a descrição do cargo");
        }
    }
}