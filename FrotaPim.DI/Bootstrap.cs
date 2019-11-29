using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using FrotaPim.Data;
using FrotaPim.Domain;
using FrotaPim.Domain.Servicos;
using FrotaPim.Domain.Entidades;

namespace FrotaPim.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            services.AddDbContext<ApplicationDbContext>(options => 
                options.UseSqlServer(connection));

            services.AddScoped(typeof(IRepositorio<>), typeof(Repositorio<>));
            services.AddScoped(typeof(IRepositorio<Manutencao>), typeof(ManutencaoRepositorio));
            services.AddScoped(typeof(IRepositorio<Pessoa>), typeof(PessoaRepositorio));
            services.AddScoped(typeof(CargoServico));
            services.AddScoped(typeof(MultaServico));
            services.AddScoped(typeof(PessoaServico));
            services.AddScoped(typeof(ManutencaoServico));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}
