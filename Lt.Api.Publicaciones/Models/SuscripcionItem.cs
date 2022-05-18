using Lt.Api.Publicaciones.Core;

namespace Lt.Api.Publicaciones.Models
{
    public class SuscripcionItem : EntityBase
    {
        public int Cantidad { get; set; }
        public int SuscripcionId { get; set; }
        public Suscripcion Suscripcion { get; set; }
        public int ProductoID { get; set; }
        public Producto Producto { get; set; }
    }
}
