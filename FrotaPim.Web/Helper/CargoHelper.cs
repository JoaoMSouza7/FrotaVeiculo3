using System.Collections.Generic;
using FrotaPim.Domain.DTOS;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Helper
{
    public class CargoHelper
    {
        internal static Cargo converterDtoParaEntidade(CargoDTO dto)
        {
            Cargo cargo = new Cargo();
            
            cargo.NomeCargo = dto.NomeCargo;
            cargo.Descricao = dto.Descricao;
            return cargo;
        }
        internal static CargoDTO converterEntidadeParaDto(Cargo cargo)
        {
            CargoDTO dto = new CargoDTO();

            dto.NomeCargo = cargo.NomeCargo;
            dto.Descricao = cargo.Descricao;
            return dto;
        }
        internal static List<Cargo> converterListaDtoParaEntidade(List<CargoDTO> dto)
        {
            var cargo = new List<Cargo>();

            foreach(var item in dto)
                cargo.Add(converterDtoParaEntidade(item));
            return cargo;
        }
        internal static List<CargoDTO> converterListaEntidadeParaDto(List<Cargo> cargo)
        {
            var dto = new List<CargoDTO>();

            foreach(var item in cargo)
                dto.Add(converterEntidadeParaDto(item));
            return dto;
        }
    }
}