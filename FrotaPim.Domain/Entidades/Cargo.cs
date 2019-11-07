namespace FrotaPim.Domain.Entidades
{
    public class Cargo
    {
        public Motorista _Motorista { get; set; }
        public Funcionario _Funcionario { get; set; }
        public Administrador _Administrador { get; set; }

        public Cargo(Motorista motorista, Funcionario funcionario, Administrador administrador)
        {
            SetarPropriedades(id, nome, cpf, endereco, admissao, fone);
        }

        private void SetarPropriedades(Motorista motorista, Funcionario funcionario, Administrador administrador)
        {
            _Motorista = motorista;
            _Funcionario = funcionario;
            _Administrador = administrador;
        }
    }
}