using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FrotaPim.Web.Models;
using FrotaPim.Domain.DTOS;
using FrotaPim.Domain.Servicos;

namespace FrotaPim.Web.Controllers
{
    public class CargoController : Controller
    {
        private readonly CargoServico _cargoServico;

        public CargoController(CargoServico cargoServico)
        {
            _cargoServico = cargoServico;
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
            return View();
        }
    }
}