using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Repositorios
{
    public class EcommerceContext : DbContext
    {
        // Agregamos los DbSet de nuestras entidades de negocio a nuestra clase de contexto
        // para usar DbSet tenemos que utilizar using Microsoft.EntityFrameworkCore;
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Foto> Fotos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public EcommerceContext(DbContextOptions <EcommerceContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
