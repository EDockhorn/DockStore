using DockStore.Catalogo.Application.Services;
using DockStore.Catalogo.Data;
using DockStore.Catalogo.Data.Repository;
using DockStore.Catalogo.Domain;
using DockStore.Core.Bus;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace DockStore.WebApp.MVC.Setup
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            // Domain Bus (Mediator)
            services.AddScoped<IMediatrHandler, MediatrHandler>();

            // Catalogo
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoAppService, ProdutoAppService>();
            services.AddScoped<IEstoqueService, EstoqueService>();
            services.AddScoped<CatalogoContext>();

            //services.AddScoped<INotificationHandler<ProdutoAbaixoEstoqueEvent>, ProdutoEventHandler>();
        }
    }
}