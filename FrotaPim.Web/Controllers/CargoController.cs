using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrotaPim.Web.Models;
using FrotaPim.Domain.DTOS;
using FrotaPim.Domain.Servicos;
using FrotaPim.Web.Helper;
using FrotaPim.Domain;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Controllers
{
    public class CargoController : Controller
    {
        private readonly CargoServico _cargoServico;

        public readonly IRepositorio<Cargo> _repositorio;

        public CargoController(CargoServico cargoServico, IRepositorio<Cargo> cargoRepositorio)
        {
            _cargoServico = cargoServico;
            _repositorio = cargoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CriarOuEditar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CriarOuEditar(CargoDTO dto)
        {
            _cargoServico.InserirCargo(CargoHelper.converterDtoParaEntidade(dto));
            return View();
        }
    }
}