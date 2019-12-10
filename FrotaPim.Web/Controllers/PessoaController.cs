 
using Microsoft.AspNetCore.Mvc;
using FrotaPim.Domain.Servicos;
using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using FrotaPim.Web.Models.ViewsModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Data.SqlClient;
using Microsoft.IdentityModel.Protocols;
using Microsoft.AspNetCore.Authorization;

namespace FrotaPim.Web.Controllers
{
    [Authorize]
    public class PessoaController : Controller
    {
        private readonly IRepositorio<Pessoa> _context;
        private readonly IRepositorio<Cargo> _contextCargo;
        private readonly IRepositorio<Endereco> _contextEndereco;
        private readonly PessoaServico _service;


        public PessoaController(IRepositorio<Pessoa> pessoaRepositorio, IRepositorio<Cargo> contextCargo, PessoaServico service, IRepositorio<Endereco> contextEndereco)
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

        public IActionResult Detalhes(int id)
        {
            var pessoa = _context.ConsultarPorID(id);
            if (pessoa == null)
            {
                return NotFound();
            }
            var cargo = _contextCargo.ConsultarPorID(pessoa.Cargo.Id);

            var model = _contextEndereco.ConsultarPorID(pessoa.Endereco.Id);
            var enderecoModel = new EnderecoViewModel { Rua = model.Rua, Numero = model.Numero, Bairro = model.Bairro, CEP = model.CEP, Cidade = model.Cidade, Estado = model.Estado };


            var pessoaModel = new PessoaViewModel { IDPessoa = pessoa.Id, Nome = pessoa.Nome, NomeCargo = cargo.NomeCargo, CargoId = pessoa.Cargo.Id, CPF = pessoa.CPF, Admissao = pessoa.Admissao, Telefone = pessoa.Telefone, Endereco = enderecoModel };
            return View(pessoaModel);
        }

        public IActionResult Criar()
        {
            var viewModel = new PessoaViewModel();
            viewModel.Endereco = new EnderecoViewModel();

            var cargos = _contextCargo.ObterTodos().ToList();
            cargos.Insert(0, new Cargo { NomeCargo = "Selecione..." });
            viewModel.Cargos = cargos.Any()
                ? cargos.Select(c => new CargoViewModel { CargoId = c.Id, Nome = c.NomeCargo, Descricao = c.Descricao }).ToList()
                : new List<CargoViewModel>();


            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Criar(PessoaViewModel viewModel)
        {
            var endereco = viewModel.Endereco;
            Endereco enderecoInsert = new Endereco(endereco.IdEndereco, endereco.Rua, endereco.Numero, endereco.Bairro, endereco.CEP, endereco.Cidade, endereco.Estado);
            endereco.IdEndereco = _contextEndereco.Inserir(enderecoInsert);

            _service.Criar(viewModel.IDPessoa, viewModel.Nome, viewModel.CPF, viewModel.CargoId, endereco.IdEndereco, viewModel.Admissao, viewModel.Telefone);
            
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var pessoa = _context.ConsultarPorID(id);
            if (pessoa == null)
            {
                return NotFound();
            }
            var cargo = _contextCargo.ConsultarPorID(pessoa.Cargo.Id);

            var viewModel = new PessoaViewModel();
            var cargos = _contextCargo.ObterTodos().ToList();
            cargos.Insert(0, new Cargo { Id = cargo.Id, NomeCargo = cargo.NomeCargo });
            viewModel.Cargos = cargos.Any()
                ? cargos.Select(c => new CargoViewModel { CargoId = c.Id, Nome = c.NomeCargo, Descricao = c.Descricao }).ToList()
                : new List<CargoViewModel>();


            var model = _contextEndereco.ConsultarPorID(pessoa.Endereco.Id);

            var pessoaModel = new PessoaViewModel { IDPessoa = pessoa.Id, Nome = pessoa.Nome, NomeCargo = cargo.NomeCargo, Admissao = pessoa.Admissao, CPF = pessoa.CPF, Telefone = pessoa.Telefone, Cargos = viewModel.Cargos, CargoId = cargo.Id, EnderecoId = model.Id };
            pessoaModel.Endereco = new EnderecoViewModel {IdEndereco = model.Id, Rua = model.Rua, Numero = model.Numero, Bairro = model.Bairro, CEP = model.CEP, Cidade = model.Cidade, Estado = model.Estado };

            return View(pessoaModel);
        }

        [HttpPost]
        public IActionResult Editar(int id, PessoaViewModel pessoa)
        {
            var pessoaEditar = new PessoaViewModel {IDPessoa = id, Nome = pessoa.Nome, CPF = pessoa.CPF, CargoId = pessoa.CargoId, NomeCargo = pessoa.NomeCargo, Admissao = pessoa.Admissao, Telefone = pessoa.Telefone};           
            pessoaEditar.Endereco = new EnderecoViewModel{Rua = pessoa.Endereco.Rua, Numero = pessoa.Endereco.Numero, Bairro = pessoa.Endereco.Bairro, CEP = pessoa.Endereco.CEP, Cidade = pessoa.Endereco.Cidade, Estado = pessoa.Endereco.Estado};

            _service.Editar(id, pessoaEditar.Nome, pessoaEditar.CPF, pessoaEditar.CargoId, pessoaEditar.EnderecoId, pessoaEditar.Admissao, pessoaEditar.Telefone, pessoaEditar.Endereco.Rua, pessoaEditar.Endereco.Numero, pessoaEditar.Endereco.Bairro, pessoaEditar.Endereco.CEP, pessoaEditar.Endereco.Cidade, pessoaEditar.Endereco.Estado);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var pessoaDlt = _context.ConsultarPorID(id);
            _context.Deletar(pessoaDlt);
            return RedirectToAction(nameof(Index));
        }
    }
}

