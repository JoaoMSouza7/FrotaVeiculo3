

using System.Collections.Generic;
using System.Linq;
using FrotaPim.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FrotaPim.Data
{
    public class ManutencaoRepositorio : Repositorio<Manutencao>
    {
        public ManutencaoRepositorio(ApplicationDbContext context) : base(context)
        {

        }
        public override Manutencao ConsultarPorID(int id)
        {
            var query = _context.Set<Manutencao>().Include(m => m.Carro).Where(m => m.Id == id);
            if(query.Any())
                return query.First();
            return null;
        }
        public override IEnumerable<Manutencao> ObterTodos()
        {
            return _context.Set<Manutencao>().Include(m => m.Carro).AsEnumerable();
        }
    }
}