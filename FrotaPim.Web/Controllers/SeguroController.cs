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
    public class SeguroController : Controller
    {
        private readonly IRepositorio<Seguro> _context;
        private readonly IRepositorio<Carro> _contextCar;
        private readonly SeguroServico _service;


        public SeguroController(IRepositorio<Seguro> seguroRepositorio, IRepositorio<Carro> contextCar, SeguroServico service)
        {
            _context = seguroRepositorio;
            _contextCar = contextCar;
            _service = service;
        }
        public IActionResult Index()
        {
            var seguros = _context.ObterTodos().ToList();
            if (seguros.Any())
            {
                var viewsModels = seguros.Select(s => new SeguroViewModel { Id = s.Id, Apolice = s.Apolice, Seguradora = s.Seguradora, IdCarro = s.Carro.Id, DataContratacao = s.DataContratacao, DataValidade = s.DataValidade, ValorSeguro = s.ValorSeguro }).ToList();

                foreach (SeguroViewModel item in viewsModels)
                {
                    var carro = _contextCar.ConsultarPorID(item.IdCarro);

                    if (carro != null)
                    {
                        item.Placa = carro.Placa;
                    }
                }
                return View(viewsModels);
            }
            else
            {
                var viewsModel = seguros.Select(s => new SeguroViewModel { Id = s.Id, Apolice = s.Apolice, Seguradora = s.Seguradora, IdCarro = s.Carro.Id, DataContratacao = s.DataContratacao, DataValidade = s.DataValidade, ValorSeguro = s.ValorSeguro }).ToList();
                return View(viewsModel);
            }
        }

        public IActionResult Detalhes(int id)
        {
            var seguro = _context.ConsultarPorID(id);
            if (seguro == null)
            {
                return NotFound();
            }
            var carro = _contextCar.ConsultarPorID(seguro.Carro.Id);
            var seguroModel = new SeguroViewModel { Id = seguro.Id, Apolice = seguro.Apolice, Seguradora = seguro.Seguradora, Placa = carro.Placa, IdCarro = seguro.Carro.Id, DataContratacao = seguro.DataContratacao, DataValidade = seguro.DataValidade, ValorSeguro = seguro.ValorSeguro };
            return View(seguroModel);
        }

        public IActionResult Criar()
        {
            var viewModel = new SeguroViewModel();

            var carros = _contextCar.ObterTodos().ToList();
            carros.Insert(0, new Carro { Placa = "Selecione..." });
            viewModel.Carros = carros.Any()
                ? carros.Select(c => new CarroViewModel { IDCarro = c.Id, Placa = c.Placa, Marca = c.Marca, Tipo = c.Tipo, Modelo = c.Modelo, Combustivel = c.Combustivel, Cor = c.Cor, Ano = c.Ano })
                : new List<CarroViewModel>();



            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Criar(SeguroViewModel viewModel)
        {
            _service.Criar(viewModel.Id, viewModel.Apolice, viewModel.Seguradora, viewModel.IdCarro, viewModel.DataContratacao, viewModel.DataValidade, viewModel.ValorSeguro);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var seguro = _context.ConsultarPorID(id);
            if (seguro == null)
            {
                return NotFound();
            }
            var carro = _contextCar.ConsultarPorID(seguro.Carro.Id);

            var viewModel = new SeguroViewModel();
            var carros = _contextCar.ObterTodos().ToList();
            carros.Insert(0, new Carro {  Placa = carro.Placa });
            viewModel.Carros = carros.Any()
                ? carros.Select(c => new CarroViewModel { IDCarro = c.Id, Placa = c.Placa, Marca = c.Marca, Tipo = c.Tipo, Modelo = c.Modelo, Combustivel = c.Combustivel, Cor = c.Cor, Ano = c.Ano })
                : new List<CarroViewModel>();

            var seguroModel = new SeguroViewModel { Id = seguro.Id, Apolice = seguro.Apolice, Seguradora = seguro.Seguradora, IdCarro = carro.Id, DataContratacao = seguro.DataContratacao, DataValidade = seguro.DataValidade, ValorSeguro = seguro.ValorSeguro, Carros = viewModel.Carros };

            return View(seguroModel);
        }

        [HttpPost]
        public IActionResult Editar(int id, SeguroViewModel seguro)
        {
            _service.Editar(seguro.Id, seguro.Apolice, seguro.Seguradora, seguro.IdCarro, seguro.DataContratacao, seguro.DataValidade, seguro.ValorSeguro);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var seguroDlt = _context.ConsultarPorID(id);
            _context.Deletar(seguroDlt);
            return RedirectToAction(nameof(Index));
        }
    }
}
