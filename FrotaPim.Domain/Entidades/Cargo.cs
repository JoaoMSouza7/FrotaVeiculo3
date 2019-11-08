namespace FrotaPim.Domain.Entidades
{
    public class Cargo
    {
        public Pessoa _Motorista { get; set; }
        public Pessoa _Funcionario { get; set; }
        public Pessoa _Administrador { get; set; }

        public Cargo(Pessoa motorista, Pessoa funcionario, Pessoa administrador)
        {
            SetarPropriedades(motorista, funcionario, administrador);
        }

        private void SetarPropriedades(Pessoa motorista, Pessoa funcionario, Pessoa administrador)
        {
            _Motorista = motorista;
            _Funcionario = funcionario;
            _Administrador = administrador;
        }
    }
}