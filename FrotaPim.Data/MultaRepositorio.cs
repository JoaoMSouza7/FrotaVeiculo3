using System.Collections.Generic;
using System.Linq;
using FrotaPim.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FrotaPim.Data
{
    public class MultaRepositorio : Repositorio<Multa>
    {
        public MultaRepositorio(ApplicationDbContext context) : base(context)
        {

        }
        public override Multa ConsultarPorID(int id)
        {
            var query = _context.Set<Multa>().Include(m => m.Pessoa).Include(m => m.Carro).Where(m => m.Id == id);
            if(query.Any())
                return query.First();
            return null;
        }
        public override IEnumerable<Multa> ObterTodos()
        {
            return _context.Set<Multa>().Include(m => m.Pessoa).Include(m => m.Carro).AsEnumerable();
        }
    }
}