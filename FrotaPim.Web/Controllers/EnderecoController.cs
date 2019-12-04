using Microsoft.AspNetCore.Mvc;
using FrotaPim.Domain.Servicos;
using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using FrotaPim.Web.Models.ViewsModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FrotaPim.Web.Controllers
{
    public class EnderecoController : Controller
    {
        public readonly IRepositorio<Endereco> _context;
        public readonly IRepositorio<Pessoa> _contextPessoa;


        public EnderecoController(IRepositorio<Endereco> enderecoRepositorio, IRepositorio<Pessoa> contextPessoa)
        {
            _context = enderecoRepositorio;
            _contextPessoa = contextPessoa;
        }
        public IActionResult Index()
        {
            var endereco = _context.ObterTodos();
            var viewModels = endereco.Select(e => new EnderecoViewModel { IdEndereco = e.Id, Rua = e.Rua, Numero = e.Numero, Bairro = e.Bairro, CEP = e.CEP, Cidade = e.Cidade, Estado = e.Estado });
            return View(viewModels);
        }

        public IActionResult Detalhes(int id)
        {
            var endereco = _context.ConsultarPorID(id);
            if (endereco == null)
            {
                return NotFound();
            }
            var enderecoModel = new EnderecoViewModel { IdEndereco = endereco.Id, Rua = endereco.Rua, Numero = endereco.Numero, Bairro = endereco.Bairro, CEP = endereco.CEP, Cidade = endereco.Cidade, Estado = endereco.Estado };
            return View(enderecoModel);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(EnderecoViewModel endereco)
        {
            var enderecoInsert = new Endereco(endereco.IdEndereco, endereco.Rua, endereco.Numero, endereco.Bairro, endereco.CEP, endereco.Cidade, endereco.Estado);
            _context.Inserir(enderecoInsert);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var endereco = _context.ConsultarPorID(id);
            if (endereco == null)
            {
                return NotFound();
            }
            var enderecoModel = new EnderecoViewModel { IdEndereco = endereco.Id, Rua = endereco.Rua, Numero = endereco.Numero, Bairro = endereco.Bairro, CEP = endereco.CEP, Cidade = endereco.Cidade, Estado = endereco.Estado };
            return View(enderecoModel);
        }

        [HttpPost]
        public IActionResult Editar(int id, EnderecoViewModel endereco)
        {
            var enderecoEditar = new Endereco(id, endereco.Rua, endereco.Numero, endereco.Bairro, endereco.CEP, endereco.Cidade, endereco.Estado);
            if (id != enderecoEditar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Editar(enderecoEditar);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (endereco == null)
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
            return View(endereco);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            
            var enderecoDlt = _context.ConsultarPorID(id);
            
            _context.Deletar(enderecoDlt);
            return RedirectToAction(nameof(Index));
        }
    }
}
