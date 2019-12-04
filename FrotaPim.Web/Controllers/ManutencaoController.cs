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
    public class ManutencaoController : Controller
    {
        private readonly IRepositorio<Manutencao> _context;
        private readonly IRepositorio<Carro> _contextCar;
        private readonly ManutencaoServico _service;


        public ManutencaoController(IRepositorio<Manutencao> manutRepositorio, IRepositorio<Carro> contextCar, ManutencaoServico service)
        {
            _context = manutRepositorio;
            _contextCar = contextCar;
            _service = service;
        }
        public IActionResult Index()
        {
            var manuts = _context.ObterTodos().ToList();
            if (manuts.Any())
            {
                var viewsModels = manuts.Select(p => new ManutencaoViewModel { Id = p.Id, DescricaoManutencao = p.DescricaoManutencao, Data = p.Data, Valor = p.Valor, IdCarro = p.Carro.Id }).ToList();

                foreach (ManutencaoViewModel item in viewsModels)
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
                var viewsModel = manuts.Select(p => new ManutencaoViewModel { Id = p.Id, DescricaoManutencao = p.DescricaoManutencao, Data = p.Data, Valor = p.Valor });
                return View(viewsModel);
            }
        }

        public IActionResult Detalhes(int id)
        {
            var manutencao = _context.ConsultarPorID(id);
            if (manutencao == null)
            {
                return NotFound();
            }
            var carro = _contextCar.ConsultarPorID(manutencao.Carro.Id);
            var manutencaoModel = new ManutencaoViewModel { Id = manutencao.Id, DescricaoManutencao = manutencao.DescricaoManutencao, Data = manutencao.Data, Valor = manutencao.Valor, Placa = carro.Placa };
            return View(manutencaoModel);
        }

        public IActionResult Criar()
        {
            var viewModel = new ManutencaoViewModel();



            var carros = _contextCar.ObterTodos().ToList();
            carros.Insert(0, new Carro { Placa = "Selecione..." });
            viewModel.Carros = carros.Any()
                ? carros.Select(c => new CarroViewModel { IDCarro = c.Id, Placa = c.Placa, Marca = c.Marca, Tipo = c.Tipo, Modelo = c.Modelo, Combustivel = c.Combustivel, Cor = c.Cor, Ano = c.Ano })
                : new List<CarroViewModel>();



            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Criar(ManutencaoViewModel viewModel)
        {
            _service.Criar(viewModel.Id, viewModel.DescricaoManutencao, viewModel.Valor, viewModel.IdCarro, viewModel.Data);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var manut = _context.ConsultarPorID(id);
            if (manut == null)
            {
                return NotFound();
            }
            var carro = _contextCar.ConsultarPorID(manut.Carro.Id);

            var viewModel = new ManutencaoViewModel();
            var carros = _contextCar.ObterTodos().ToList();
            carros.Insert(0, new Carro { Placa = carro.Placa });
            viewModel.Carros = carros.Any()
                ? carros.Select(c => new CarroViewModel { IDCarro = c.Id, Placa = c.Placa, Marca = c.Marca, Tipo = c.Tipo, Modelo = c.Modelo, Combustivel = c.Combustivel, Cor = c.Cor, Ano = c.Ano })
                : new List<CarroViewModel>();

            var manutModel = new ManutencaoViewModel { Id = manut.Id, DescricaoManutencao = manut.DescricaoManutencao, Placa = carro.Placa, Data = manut.Data, Valor = manut.Valor, Carros = viewModel.Carros };
            
            return View(manutModel);
        }

        [HttpPost]
        public IActionResult Editar(int id, ManutencaoViewModel manutencao)
        {
            _service.Editar(manutencao.Id, manutencao.DescricaoManutencao, manutencao.Valor, manutencao.IdCarro, manutencao.Data);
            return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var manutDlt = _context.ConsultarPorID(id);
            _context.Deletar(manutDlt);
            return RedirectToAction(nameof(Index));
        }
    }
}
