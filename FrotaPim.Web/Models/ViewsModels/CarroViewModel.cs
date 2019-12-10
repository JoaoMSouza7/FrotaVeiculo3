using System;
using System.ComponentModel.DataAnnotations;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class CarroViewModel
    {
        public int IDCarro { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public string Combustivel { get; set; }
        public int Ano { get; set; }

    }
}