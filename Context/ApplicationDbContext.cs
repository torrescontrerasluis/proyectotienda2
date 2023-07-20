using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.X509;
using proyecto_tienda.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_tienda.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost; database=Testeo; user=root; password=;");

        }

        //Definir tablas

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Vendedor> Vendedores { get; set; }

        public DbSet<Producto> Productos { get; set; }

        public DbSet <Venta> Ventas { get; set; }

    }
}
