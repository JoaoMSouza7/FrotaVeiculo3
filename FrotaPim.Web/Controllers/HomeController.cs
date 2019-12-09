
using System.Linq;
using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using FrotaPim.Web.Models.ViewsModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FrotaPim.Web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        
        private readonly IRepositorio<Pessoa> _context;
        private readonly IRepositorio<Cargo> _contextCargo;
        private readonly IRepositorio<Endereco> _contextEndereco;
        private readonly PessoaServico _service;


        public HomeController(IRepositorio<Pessoa> pessoaRepositorio, IRepositorio<Cargo> contextCargo, PessoaServico service, IRepositorio<Endereco> contextEndereco)
        {
            _context = pessoaRepositorio;
            _contextCargo = contextCargo;
            _service = service;
            _contextEndereco = contextEndereco;
        }
        public IActionResult Index()
        {
            var pessoas = _context.ObterTodos().ToList();
            if (pessoas.Any())
            {
                var viewsModels = pessoas.Select(p => new PessoaViewModel { IDPessoa = p.Id, Nome = p.Nome, CPF = p.CPF, Admissao = p.Admissao, Telefone = p.Telefone, CargoId = p.Cargo.Id, EnderecoId = p.Endereco.Id }).ToList();

                foreach (PessoaViewModel item in viewsModels)
                {
                    var cargo = _contextCargo.ConsultarPorID(item.CargoId);

                    if (cargo != null)
                    {
                        item.NomeCargo = cargo.NomeCargo;
                    }
                }
                return View(viewsModels);
            }
            else
            {
                var viewsModel = pessoas.Select(p => new PessoaViewModel { IDPessoa = p.Id, Nome = p.Nome, CargoId = p.Cargo.Id, CPF = p.CPF, Admissao = p.Admissao, Telefone = p.Telefone, EnderecoId = p.Endereco.Id });
                return View(viewsModel);
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}