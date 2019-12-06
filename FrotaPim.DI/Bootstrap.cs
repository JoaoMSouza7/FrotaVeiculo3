
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using FrotaPim.Data;
using FrotaPim.Domain;
using FrotaPim.Domain.Servicos;
using FrotaPim.Domain.Entidades;
using Microsoft.AspNetCore.Identity;
using FrotaPim.Data.Identity;
using FrotaPim.Domain.Account;

namespace FrotaPim.DI
{
    public class Bootstrap
    {
        public static void Configure(IServiceCollection services, string connection)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));

            services.AddIdentity<ApplicationUser, IdentityRole>(config => {
                config.Password.RequireDigit = false;
                config.Password.RequiredLength = 3;
                config.Password.RequireLowercase = false;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;

            })   
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options => options.AccessDeniedPath = "/Account/Login");

            services.AddScoped(typeof(IRepositorio<>), typeof(Repositorio<>));
            services.AddScoped(typeof(IAuthentication), typeof(Authentication));
            services.AddScoped(typeof(IManager), typeof(Manager));
            services.AddScoped(typeof(IRepositorio<Manutencao>), typeof(ManutencaoRepositorio));
            services.AddScoped(typeof(IRepositorio<Seguro>), typeof(SeguroRepositorio));
            services.AddScoped(typeof(IRepositorio<Pessoa>), typeof(PessoaRepositorio));
            services.AddScoped(typeof(IRepositorio<Multa>), typeof(MultaRepositorio));
            services.AddScoped(typeof(CargoServico));
            services.AddScoped(typeof(SeguroServico));
            services.AddScoped(typeof(MultaServico));
            services.AddScoped(typeof(PessoaServico));
            services.AddScoped(typeof(ManutencaoServico));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
        }
    }
}
