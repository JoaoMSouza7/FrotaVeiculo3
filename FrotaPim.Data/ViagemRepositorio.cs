using System.Collections.Generic;
using System.Linq;
using FrotaPim.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FrotaPim.Data
{
    public class ViagemRepositorio : Repositorio<Viagem>
    {
        public ViagemRepositorio(ApplicationDbContext context) : base(context)
        {

        }
        public override Viagem ConsultarPorID(int id)
        {
            var query = _context.Set<Viagem>().Include(m => m.Pessoa).Include(m => m.Carro).Where(m => m.Id == id);
            if(query.Any())
                return query.First();
            return null;
        }
        public override IEnumerable<Viagem> ObterTodos()
        {
            return _context.Set<Viagem>().Include(m => m.Pessoa).Include(m => m.Carro).AsEnumerable();
        }
    }
}