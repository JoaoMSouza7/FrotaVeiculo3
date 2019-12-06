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
    public class EstoqueController : Controller
    {
        public readonly IRepositorio<Estoque> _context;


        public EstoqueController(IRepositorio<Estoque> estoqueRepositorio)
        {
            _context = estoqueRepositorio;
        }
        public IActionResult Index()
        {
            var estoque = _context.ObterTodos();
            var viewModels = estoque.Select(e => new EstoqueViewModel { IdEstoque = e.Id, NomePeca = e.NomePeca, Descricao = e.Descricao, Fornecedor = e.Fornecedor, ValorPeca = e.ValorPeca, Quantidade = e.Quantidade });
            return View(viewModels);
        }

        public IActionResult Detalhes(int id)
        {
            var estoque = _context.ConsultarPorID(id);
            if (estoque == null)
            {
                return NotFound();
            }
            var estoqueModel = new EstoqueViewModel { IdEstoque = estoque.Id, NomePeca = estoque.NomePeca, Descricao = estoque.Descricao, Fornecedor = estoque.Fornecedor, ValorPeca = estoque.ValorPeca, Quantidade = estoque.Quantidade };
            return View(estoqueModel);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(EstoqueViewModel estoque)
        {
            var estoqueInsert = new Estoque(estoque.IdEstoque, estoque.NomePeca, estoque.Descricao, estoque.Fornecedor, estoque.ValorPeca, estoque.Quantidade);
            _context.Inserir(estoqueInsert);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var estoque = _context.ConsultarPorID(id);
            if (estoque == null)
            {
                return NotFound();
            }
            var estoqueModel = new EstoqueViewModel { IdEstoque = estoque.Id, NomePeca = estoque.NomePeca, Descricao = estoque.Descricao, Fornecedor = estoque.Fornecedor, ValorPeca = estoque.ValorPeca, Quantidade = estoque.Quantidade };
            return View(estoqueModel);
        }

        [HttpPost]
        public IActionResult Editar(int id, EstoqueViewModel estoque)
        {
            var estoqueEditar = new Estoque(id, estoque.NomePeca, estoque.Descricao, estoque.Fornecedor, estoque.ValorPeca, estoque.Quantidade);
            if (id != estoqueEditar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Editar(estoqueEditar);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (estoque == null)
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
            return View(estoque);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var estoqueDlt = _context.ConsultarPorID(id);
            _context.Deletar(estoqueDlt);
            return RedirectToAction(nameof(Index));
        }
    }
}
