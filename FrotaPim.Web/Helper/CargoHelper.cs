using System.Collections.Generic;
using FrotaPim.Domain.DTOS;
using FrotaPim.Domain.Entidades;
using FrotaPim.Web.Models.ViewsModels;

namespace FrotaPim.Web.Helper
{
    public class CargoHelper
    {
        internal static Cargo converterDtoParaEntidade(CargoViewModel dto)
        {
            Cargo cargo = new Cargo();
            
            cargo.NomeCargo = dto.NomeCargo;
            cargo.Descricao = dto.Descricao;
            return cargo;
        }
        internal static CargoViewModel converterEntidadeParaDto(Cargo cargo)
        {
            CargoViewModel dto = new CargoViewModel();

            dto.NomeCargo = cargo.NomeCargo;
            dto.Descricao = cargo.Descricao;
            return dto;
        }
        internal static List<Cargo> converterListaDtoParaEntidade(List<CargoViewModel> dto)
        {
            var cargo = new List<Cargo>();

            foreach(var item in dto)
                cargo.Add(converterDtoParaEntidade(item));
            return cargo;
        }
        internal static List<CargoViewModel> converterListaEntidadeParaDto(List<Cargo> cargo)
        {
            var dto = new List<CargoViewModel>();

            foreach(var item in cargo)
                dto.Add(converterEntidadeParaDto(item));
            return dto;
        }
    }
}