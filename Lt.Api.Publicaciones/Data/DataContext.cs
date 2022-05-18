using Lt.Api.Publicaciones.Models;
using Microsoft.EntityFrameworkCore;

namespace Lt.Api.Publicaciones
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Suscripcion> Suscripcions { get; set; }
        public DbSet<GrupoSuscripcion> GrupoSuscripcions { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<SuscripcionItem> SuscripcionItems { get; set; }
        public DbSet<TipoProducto> TipoProductos { get; set; }
    }
}
