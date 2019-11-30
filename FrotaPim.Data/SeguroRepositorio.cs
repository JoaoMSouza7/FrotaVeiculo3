
using System.Collections.Generic;
using System.Linq;
using FrotaPim.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FrotaPim.Data
{
    public class SeguroRepositorio : Repositorio<Seguro>
    {
        public SeguroRepositorio(ApplicationDbContext context) : base(context)
        {

        }
        public override Seguro ConsultarPorID(int id)
        {
            var query = _context.Set<Seguro>().Include(m => m.Carro).Where(m => m.Id == id);
            if (query.Any())
                return query.First();
            return null;
        }
        public override IEnumerable<Seguro> ObterTodos()
        {
            return _context.Set<Seguro>().Include(m => m.Carro).AsEnumerable();
        }
    }
}