using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.Web.Models.ViewsModels
{
    public class PessoaViewModel
    {
        public int IDPessoa { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public int CargoId { get; set; }
        public List<CargoViewModel> Cargos { get; set; }
        public string NomeCargo { get; set; }
        public int EnderecoId { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Admissao { get; set; }
        public string Telefone { get; set; } 
        public EnderecoViewModel Endereco { get; set; } 

        public PessoaViewModel(){
            this.Endereco = new EnderecoViewModel();
            this.Cargos = new List<CargoViewModel>();
        }
    }
}