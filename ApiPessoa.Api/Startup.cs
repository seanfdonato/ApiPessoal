﻿using ApiPessoa.Domain.Handlers;
using ApiPessoa.Domain.Repositorios;
using ApiPessoa.Infra.DataContexto;
using ApiPessoa.Infra.Repositorios;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace ApiPessoa.Api
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<Contexto, Contexto>();
            services.AddScoped<ContextoSQL, ContextoSQL>();
            services.AddTransient<ICargoRepositorio, CargoRepositorio>();
            services.AddTransient<CargoHandler, CargoHandler>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
