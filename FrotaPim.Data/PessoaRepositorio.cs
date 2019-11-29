

using System.Collections.Generic;
using System.Linq;
using FrotaPim.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace FrotaPim.Data
{
    public class PessoaRepositorio : Repositorio<Pessoa>
    {
        public PessoaRepositorio(ApplicationDbContext context) : base(context)
        {

        }
        public override Pessoa ConsultarPorID(int id)
        {
            var query = _context.Set<Pessoa>().Include(m => m.Cargo).Include(m => m.Endereco).Where(m => m.Id == id);
            if(query.Any())
                return query.First();
            return null;
        }
        public override IEnumerable<Pessoa> ObterTodos()
        {
            return _context.Set<Pessoa>().Include(m => m.Cargo).Include(m => m.Endereco).AsEnumerable();
        }
    }
}