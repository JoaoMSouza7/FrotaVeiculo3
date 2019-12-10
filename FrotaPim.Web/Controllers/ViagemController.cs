using Microsoft.AspNetCore.Mvc;
using FrotaPim.Domain.Servicos;
using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using FrotaPim.Web.Models.ViewsModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;

namespace FrotaPim.Web.Controllers
{
    [Authorize]
    public class ViagemController : Controller
    {   
        public readonly IRepositorio<Viagem> _context;
        public readonly IRepositorio<Carro> _contextCar;
        public readonly IRepositorio<Pessoa> _contextPessoa;
        public readonly ViagemServico _service;


        public ViagemController(IRepositorio<Viagem> viagemRepositorio, IRepositorio<Carro> carroRepositorio, IRepositorio<Pessoa> pessoaRepositorio, ViagemServico service)
        {
            _context = viagemRepositorio;
            _contextCar = carroRepositorio;
            _contextPessoa = pessoaRepositorio;
            _service = service;
        }
        public IActionResult Index()
        {
            var viagens = _context.ObterTodos();
            if (viagens.Any())
            {
                List<ViagemViewModel> viewsModels = viagens.Select(p => new ViagemViewModel { Id = p.Id, Origem = p.Origem, Destino = p.Destino, KM = p.KM, DataViagem = p.DataViagem, Valor = p.Valor, IdCarro = p.Carro.Id, IdPessoa = p.Pessoa.Id }).ToList();

                foreach(ViagemViewModel item in viewsModels)
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
                var viewsModel = viagens.Select(p => new ViagemViewModel { Id = p.Id, Origem = p.Origem, Destino = p.Destino, KM = p.KM, DataViagem = p.DataViagem, Valor = p.Valor, IdCarro = p.Carro.Id, IdPessoa = p.Pessoa.Id });
                return View(viewsModel);
            }
        }

        public IActionResult Detalhes(int id)
        {
            var viagem = _context.ConsultarPorID(id);
            if (viagem == null)
            {
                return NotFound();
            }
            var carro = _contextCar.ConsultarPorID(viagem.Carro.Id);
            var pessoa = _contextPessoa.ConsultarPorID(viagem.Pessoa.Id);
            var viagemModel = new ViagemViewModel { Id = viagem.Id, Origem = viagem.Origem, Destino = viagem.Destino, KM = viagem.KM, DataViagem = viagem.DataViagem, Valor = viagem.Valor, Placa = carro.Placa, NomePessoa = pessoa.Nome};
            return View(viagemModel);
        }

        public IActionResult Criar()
        {
            var viewModel = new ViagemViewModel();

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
        public IActionResult Criar(ViagemViewModel viagem)
        {
            _service.Criar(viagem.Id, viagem.Origem, viagem.Destino, viagem.KM, viagem.DataViagem, viagem.Valor, viagem.IdCarro, viagem.IdPessoa );
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var viagem = _context.ConsultarPorID(id);
            if (viagem == null)
            {
                return NotFound();
            }
            var carro = _contextCar.ConsultarPorID(viagem.Carro.Id);
            var pessoa = _contextPessoa.ConsultarPorID(viagem.Pessoa.Id);

            var model = new ViagemViewModel();

            var carros = _contextCar.ObterTodos().ToList();
            carros.Insert(0, new Carro { Id = carro.Id, Placa = carro.Placa });
            model.Carros = carros.Any()
                ? carros.Select(c => new CarroViewModel { IDCarro = c.Id, Placa = c.Placa, Marca = c.Marca, Tipo = c.Tipo, Modelo = c.Modelo, Combustivel = c.Combustivel, Cor = c.Cor, Ano = c.Ano })
                : new List<CarroViewModel>();

            var pessoas = _contextPessoa.ObterTodos().ToList();
            pessoas.Insert(0, new Pessoa { Id = pessoa.Id, Nome = pessoa.Nome });
            model.Pessoas = pessoas.Any()
                ? pessoas.Select(p => new PessoaViewModel { IDPessoa = p.Id, Nome = p.Nome, CPF = p.CPF, CargoId = p.Cargo.Id, NomeCargo = p.Cargo.NomeCargo, EnderecoId = p.Endereco.Id, Admissao = p.Admissao, Telefone = p.Telefone })
                : new List<PessoaViewModel>();

            var viagemModel = new ViagemViewModel { Id = viagem.Id, Origem = viagem.Origem, Destino = viagem.Destino, KM = viagem.KM, DataViagem = viagem.DataViagem ,Valor = viagem.Valor, Carros = model.Carros, Pessoas = model.Pessoas, IdCarro = carro.Id, IdPessoa = pessoa.Id};

            return View(viagemModel);
        }

        [HttpPost]
        public IActionResult Editar(ViagemViewModel viagem)
        {
            _service.Editar(viagem.Id, viagem.Origem, viagem.Destino, viagem.KM, viagem.DataViagem, viagem.Valor, viagem.IdCarro, viagem.IdPessoa);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var viagemDelete = _context.ConsultarPorID(id);
            _context.Deletar(viagemDelete);
            return RedirectToAction(nameof(Index));
        }
    }
}