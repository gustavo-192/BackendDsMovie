using dsmovie.Domain;
using dsmovie.Entities;
using dsmovie.Repository;
using dsmovie.Service;
using dsmovie.Service.AvaliacaoService;
using Microsoft.Extensions.DependencyInjection;

namespace dsmovie.Ioc
{
    public static class NativeInjectorBootStrapp
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Services 
            services.AddScoped<IFilmeService, FilmeService>();
            services.AddScoped<IUsuarioService, UsuarioService>();
            services.AddScoped<IAvaliacaoService, AvaliacaoService>();

            // Repositoty 
            services.AddScoped<IFilmeRepository, FilmeRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IAvaliacaoRepository, AvaliacaoRepository>();
            services.AddScoped<IRepository, Repository.Repository>();
        }
    }
}
