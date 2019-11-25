using Microsoft.AspNetCore.Mvc;
using FrotaPim.Domain.Servicos;
using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using FrotaPim.Web.Models.ViewsModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FrotaPim.Web.Controllers
{
    public class CargoController : Controller
    {
        private readonly CargoServico _cargoServico;

        public readonly IRepositorio<Cargo> _context;

        public CargoController(CargoServico cargoServico, IRepositorio<Cargo> cargoRepositorio)
        {
            _cargoServico = cargoServico;
            _context = cargoRepositorio;
        }
        public IActionResult Index()
        {
            var cargos = _context.ObterTodos();
            var viewModels = cargos.Select(c => new CargoViewModel { Id = c.Id, Nome = c.NomeCargo, Descricao = c.Descricao });
            return View(viewModels);
        }

        public IActionResult Detalhes(int id)
        {
            var cargo = _context.ConsultarPorID(id);
            if (cargo == null)
            {
                return NotFound();
            }
            var cargoModel = new CargoViewModel { Id = cargo.Id, Nome = cargo.NomeCargo, Descricao = cargo.Descricao };
            return View(cargoModel);
        }

        public IActionResult Criar()
        {
                return View();
        }

        [HttpPost]
        public IActionResult Criar(CargoViewModel cargo)
        {
            var cargoInsert = new Cargo { NomeCargo = cargo.Nome, Descricao = cargo.Descricao };
            _cargoServico.InserirCargo(cargoInsert.Id, cargoInsert.NomeCargo, cargoInsert.Descricao);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {   
            var cargo = _context.ConsultarPorID(id);
            if (cargo == null)
            {
                return NotFound();
            }
            var cargoViewModel = new CargoViewModel { Nome = cargo.NomeCargo, Descricao = cargo.Descricao };
            return View(cargoViewModel);
        }

        [HttpPost]
        public IActionResult Editar(int id, CargoViewModel cargo)
        {
            var cargoEdit = new Cargo(id, cargo.Nome, cargo.Descricao);
            if (id != cargo.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Editar(cargoEdit);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (cargo == null)
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
            return RedirectToAction("Index");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _cargoServico.ApagarCargo(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
