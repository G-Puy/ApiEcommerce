using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Repositorios;
using Microsoft.EntityFrameworkCore;
using Manejadores.IManejadores;
using Manejadores.Manejadores;
using Dominio.Interfaces;

namespace ApiEcommerce
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            //PARA EVITAR LOOPS INFINITOS DE JSON
            services.AddControllers().AddNewtonsoftJson(
                options => options.SerializerSettings.ReferenceLoopHandling
                = Newtonsoft.Json.ReferenceLoopHandling.Ignore);


            //OBTENER LA CADENA DE CONEXION SETEADA EN APPSETTING.JSON
            string strConexion = Configuration.GetConnectionString("MiConexion");
            services.AddDbContext<EcommerceContext>(options => options.UseSqlServer(strConexion));


            //INYECCIONES

            //PRODUCTO
            services.AddScoped<IManejadorProducto, ManejadorProducto>();
            services.AddScoped<IRepositorioProducto, RepositorioProductoEF>();

            //CATEGORIA
            services.AddScoped<IManejadorCategoria, ManejadorCategoria>();
            services.AddScoped<IRepositorioCategoria,RepositorioCategoriaEF>();

            //FOTO
            services.AddScoped<IManejadorFoto, ManejadorFoto>();
            services.AddScoped<IRepositorioFoto, RepositorioFotoEF>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
