using Microsoft.AspNetCore.Mvc;
using FrotaPim.Domain.Servicos;
using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using FrotaPim.Web.Models.ViewsModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FrotaPim.Web.Controllers
{
    public class MultaController : Controller
    {
        public readonly IRepositorio<Multa> _context;
        public readonly IRepositorio<Carro> _contextCar;
        public readonly IRepositorio<Pessoa> _contextPessoa;
        public readonly MultaServico _service;


        public MultaController(IRepositorio<Multa> multaRepositorio, IRepositorio<Carro> carroRepositorio, IRepositorio<Pessoa> pessoaRepositorio, MultaServico service)
        {
            _context = multaRepositorio;
            _contextCar = carroRepositorio;
            _contextPessoa = pessoaRepositorio;
            _service = service;
        }
        public IActionResult Index()
        {
            var multas = _context.ObterTodos();
            if (multas.Any())
            {
                List<MultaViewModel> viewsModels = multas.Select(p => new MultaViewModel { Id = p.Id, Gravidade = p.Gravidade, IdCarro = p.Carro.Id, IdPessoa = p.Pessoa.Id, TipoMulta = p.TipoMulta, DataMulta = p.DataMulta, ValorMulta = p.ValorMulta }).ToList();

                foreach (MultaViewModel item in viewsModels)
                {
                    Carro carro = _contextCar.ConsultarPorID(item.IdCarro);
                    Pessoa pessoa = _contextPessoa.ConsultarPorID(item.IdPessoa);

                    if (carro != null && pessoa != null)
                    {
                        item.Placa = carro.Placa;
                        item.NomePessoa = pessoa.Nome;
                    }
                }
                return View(viewsModels);
            }
            else
            {
                var viewsModel = multas.Select(p => new MultaViewModel { Id = p.Id, Gravidade = p.Gravidade, TipoMulta = p.TipoMulta, DataMulta = p.DataMulta, ValorMulta = p.ValorMulta });
                return View(viewsModel);
            }
        }

        public IActionResult Detalhes(int id)
        {
            var multa = _context.ConsultarPorID(id);
            if (multa == null)
            {
                return NotFound();
            }
            var carro = _contextCar.ConsultarPorID(multa.Carro.Id);
            var pessoa = _contextPessoa.ConsultarPorID(multa.Pessoa.Id);
            var multaModel = new MultaViewModel { Id = multa.Id, NomePessoa = pessoa.Nome, Placa = carro.Placa, DataMulta = multa.DataMulta, Gravidade = multa.Gravidade, TipoMulta = multa.TipoMulta, ValorMulta = multa.ValorMulta};
            return View(multaModel);
        }

        public IActionResult Criar()
        {
            var viewModel = new MultaViewModel();

            var carros = _contextCar.ObterTodos().ToList();
            carros.Insert(0, new Carro { Placa = "Selecione..." });
            viewModel.Carros = carros.Any()
                ? carros.Select(c => new CarroViewModel { IDCarro = c.Id, Placa = c.Placa, Marca = c.Marca, Tipo = c.Tipo, Modelo = c.Modelo, Combustivel = c.Combustivel, Cor = c.Cor, Ano = c.Ano })
                : new List<CarroViewModel>();

            var pessoas = _contextPessoa.ObterTodos().ToList();
            pessoas.Insert(0, new Pessoa { Nome = "Selecione..." });
            viewModel.Pessoas = pessoas.Any()
                ? pessoas.Select(p => new PessoaViewModel { IDPessoa = p.Id, Nome = p.Nome, CPF = p.CPF, CargoId = p.Cargo.Id, EnderecoId = p.Endereco.Id, Admissao = p.Admissao, Telefone = p.Telefone })
                : new List<PessoaViewModel>();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Criar(MultaViewModel multa)
        {
            _service.Criar(multa.Id, multa.IdPessoa, multa.TipoMulta, multa.Gravidade, multa.DataMulta, multa.ValorMulta, multa.IdCarro);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var multa = _context.ConsultarPorID(id);
            if (multa == null)
            {
                return NotFound();
            }
            var carro = _contextCar.ConsultarPorID(multa.Carro.Id);
            var pessoa = _contextPessoa.ConsultarPorID(multa.Pessoa.Id);

            var model = new MultaViewModel();

            var carros = _contextCar.ObterTodos().ToList();
            carros.Insert(0, new Carro { Placa = carro.Placa });
            model.Carros = carros.Any()
                ? carros.Select(c => new CarroViewModel { IDCarro = c.Id, Placa = c.Placa, Marca = c.Marca, Tipo = c.Tipo, Modelo = c.Modelo, Combustivel = c.Combustivel, Cor = c.Cor, Ano = c.Ano })
                : new List<CarroViewModel>();

            var pessoas = _contextPessoa.ObterTodos().ToList();
            pessoas.Insert(0, new Pessoa { Nome = pessoa.Nome });
            model.Pessoas = pessoas.Any()
                ? pessoas.Select(p => new PessoaViewModel { IDPessoa = p.Id, Nome = p.Nome, CPF = p.CPF, CargoId = p.Cargo.Id, NomeCargo = p.Cargo.NomeCargo, EnderecoId = p.Endereco.Id, Admissao = p.Admissao, Telefone = p.Telefone })
                : new List<PessoaViewModel>();

            var multaModel = new MultaViewModel { Id = multa.Id, NomePessoa = pessoa.Nome, IdCarro = carro.Id, IdPessoa = pessoa.Id, Placa = carro.Placa, Gravidade = multa.Gravidade, DataMulta = multa.DataMulta, TipoMulta = multa.TipoMulta, ValorMulta = multa.ValorMulta, Carros = model.Carros, Pessoas = model.Pessoas };

            return View(multaModel);
        }

        [HttpPost]
        public IActionResult Editar(int id, MultaViewModel multa)
        {
            _service.Editar(multa.Id, multa.IdPessoa, multa.TipoMulta, multa.Gravidade, multa.DataMulta, multa.ValorMulta, multa.IdCarro);
            return RedirectToAction(nameof(Index));
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