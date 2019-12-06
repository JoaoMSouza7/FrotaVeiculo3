using Microsoft.AspNetCore.Mvc;
using FrotaPim.Domain.Servicos;
using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using FrotaPim.Web.Models.ViewsModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace FrotaPim.Web.Controllers
{
    [Authorize]
    public class ContasAPagarController : Controller
    {
        public readonly IRepositorio<ContasAPagar> _context;


        public ContasAPagarController(IRepositorio<ContasAPagar> contasRepositorio)
        {
            _context = contasRepositorio;
        }
        public IActionResult Index()
        {
            var contas = _context.ObterTodos();
            var viewModels = contas.Select(c => new ContasAPagarViewModel { IdConta = c.Id, CentroDeCusto = c.CentroDeCusto, TipoDespesa = c.TipoDespesa, Descricao = c.Descricao, Vencimento = c.Vencimento, Valor = c.Valor });
            return View(viewModels);
        }

        public IActionResult Detalhes(int id)
        {
            var conta = _context.ConsultarPorID(id);
            if (conta == null)
            {
                return NotFound();
            }
            var contaModel = new ContasAPagarViewModel { IdConta = conta.Id, CentroDeCusto = conta.CentroDeCusto, TipoDespesa = conta.TipoDespesa, Descricao = conta.Descricao, Vencimento = conta.Vencimento, Valor = conta.Valor };
            return View(contaModel);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ContasAPagarViewModel conta)
        {
            var ContaInsert = new ContasAPagar(conta.IdConta ,conta.CentroDeCusto, conta.TipoDespesa, conta.Descricao, conta.Vencimento, conta.Valor);
            _context.Inserir(ContaInsert);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var conta = _context.ConsultarPorID(id);
            if (conta == null)
            {
                return NotFound();
            }
            var contaViewModel = new ContasAPagarViewModel { CentroDeCusto = conta.CentroDeCusto, TipoDespesa = conta.TipoDespesa, Descricao = conta.Descricao, Vencimento = conta.Vencimento, Valor = conta.Valor };
            return View(contaViewModel);
        }

        [HttpPost]
        public IActionResult Editar(int id, ContasAPagarViewModel conta)
        {
            var contaEditar = new ContasAPagar(id, conta.CentroDeCusto, conta.TipoDespesa, conta.Descricao, conta.Vencimento, conta.Valor);
            if (id != contaEditar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Editar(contaEditar);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (conta == null)
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(conta);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var ContaDlt = _context.ConsultarPorID(id);
            _context.Deletar(ContaDlt);
            return RedirectToAction(nameof(Index));
        }
    }
}
