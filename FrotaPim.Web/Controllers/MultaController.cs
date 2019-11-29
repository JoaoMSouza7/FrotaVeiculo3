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
        public readonly IRepositorio<Multas> _context;
        public readonly IRepositorio<Carro> _contextCar;
        public readonly IRepositorio<Pessoa> _contextPessoa;
        public readonly MultaServico _service;


        public MultaController(IRepositorio<Multas> multaRepositorio, IRepositorio<Carro> carroRepositorio, IRepositorio<Pessoa> pessoaRepositorio, MultaServico service)
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
                var viewsModels = multas.Select(p => new MultaViewModel { Id = p.Id, Gravidade = p.Gravidade, TipoMulta = p.TipoMulta, DataMulta = p.DataMulta, ValorMulta = p.ValorMulta }).ToList();

                foreach (MultaViewModel item in viewsModels)
                {
                    var carro = _contextCar.ConsultarPorID(item.Carro.Id);
                    var pessoa = _contextPessoa.ConsultarPorID(item.Motorista.Id);

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
                ? pessoas.Select(p => new PessoaViewModel { Id = p.Id, Nome = p.Nome, CPF = p.CPF, CargoId = p.Cargo.Id, EnderecoId = p.Endereco.Id, Admissao = p.Admissao, Telefone = p.Telefone })
                : new List<PessoaViewModel>();

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Criar(MultaViewModel multa)
        {
            _service.Criar(multa.Id, multa.Motorista, multa.TipoMulta, multa.Gravidade, multa.DataMulta, multa.ValorMulta, multa.Carro);
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

            var viewModel = new MultaViewModel();
            var carros = _contextCar.ObterTodos().ToList();
            carros.Insert(0, new Carro { Placa = carro.Placa });
            viewModel.Carros = carros.Any()
                ? carros.Select(c => new CarroViewModel { IDCarro = c.Id, Placa = c.Placa, Marca = c.Marca, Tipo = c.Tipo, Modelo = c.Modelo, Combustivel = c.Combustivel, Cor = c.Cor, Ano = c.Ano })
                : new List<CarroViewModel>();

            var pessoas = _contextPessoa.ObterTodos().ToList();
            pessoas.Insert(0, new Pessoa { Nome = pessoa.Nome });
            viewModel.Pessoas = pessoas.Any()
                ? pessoas.Select(c => new PessoaViewModel { Id = c.Id, Nome = c.Nome, CPF = c.CPF, Telefone = c.Telefone, Admissao =c.Admissao, CargoId = c.Cargo.Id, EnderecoId = c.Endereco.Id })
                : new List<PessoaViewModel>();

            var multaModel = new MultaViewModel { Id = multa.Id, NomePessoa = pessoa.Nome, Placa = carro.Placa, Gravidade = multa.Gravidade, DataMulta = multa.DataMulta, TipoMulta = multa.TipoMulta, ValorMulta = multa.ValorMulta };

            return View(multaModel);
        }

        [HttpPost]
        public IActionResult Editar(int id, MultaViewModel multa)
        {
            _service.Editar(multa.Id, multa.Motorista, multa.TipoMulta, multa.Gravidade, multa.DataMulta, multa.ValorMulta, multa.Carro);
            return View(multa);
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
