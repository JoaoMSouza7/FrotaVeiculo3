using Microsoft.AspNetCore.Mvc;
using FrotaPim.Domain.Servicos;
using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;
using FrotaPim.Web.Models.ViewsModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace FrotaPim.Web.Controllers
{
    public class CarroController : Controller
    {
        public readonly IRepositorio<Carro> _context;


        public CarroController(IRepositorio<Carro> carroRepositorio)
        {
            _context = carroRepositorio;
        }
        public IActionResult Index()
        {
            var carros = _context.ObterTodos();
            var viewModels = carros.Select(c => new CarroViewModel { IDCarro = c.Id, Placa = c.Placa, Tipo = c.Tipo, Marca = c.Marca, Modelo = c.Modelo, Combustivel = c.Combustivel, Cor = c.Cor, Ano = c.Ano, _Motorista = c.Motorista });
            return View(viewModels);
        }

        public IActionResult Detalhes(int id)
        {
            var carro = _context.ConsultarPorID(id);
            if (carro == null)
            {
                return NotFound();
            }
            var carroModel = new CarroViewModel { IDCarro = carro.Id, Placa = carro.Placa, Tipo = carro.Tipo, Marca = carro.Marca, Modelo = carro.Modelo, Combustivel = carro.Combustivel, Cor = carro.Cor, Ano = carro.Ano, _Motorista = carro.Motorista };
            return View(carroModel);
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(CarroViewModel carro)
        {
            var carroInsert = new Carro(carro.IDCarro, carro.Placa, carro.Tipo, carro.Marca, carro.Modelo, carro.Combustivel, carro.Cor, carro.Ano);
            _context.Inserir(carroInsert);
            return RedirectToAction("Index");
        }

        public IActionResult Editar(int id)
        {
            var carro = _context.ConsultarPorID(id);
            if (carro == null)
            {
                return NotFound();
            }
            var carroViewModel = new CarroViewModel { IDCarro = carro.Id, Placa = carro.Placa, Tipo = carro.Tipo, Marca = carro.Marca, Modelo = carro.Modelo, Combustivel = carro.Combustivel,Cor = carro.Cor, Ano = carro.Ano, _Motorista = carro.Motorista };
            return View(carroViewModel);
        }

        [HttpPost]
        public IActionResult Editar(int id, CarroViewModel carro)
        {
            var carroEditar = new Carro(id, carro.Placa, carro.Tipo, carro.Marca, carro.Modelo, carro.Combustivel, carro.Cor, carro.Ano);
            if (id != carroEditar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Editar(carroEditar);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (carro == null)
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
            return View(carro);
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var cargoDlt = _context.ConsultarPorID(id);
            _context.Deletar(cargoDlt);
            return RedirectToAction(nameof(Index));
        }
    }
}
