namespace FrotaPim.Domain.Entidades
{
    public class StatusPessoa
    {
        public bool Ativo { get; private set; }
        public bool Inativo { get; private set; }
        public bool DeFerias { get; private set; }
        public bool Licenca { get; private set; }
    }
}