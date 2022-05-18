using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Lt.Api.Publicaciones.Core;

namespace Lt.Api.Publicaciones.Models
{
    public class Producto : EntityBase
    {
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public double Precio { get; set; }
        public int TipoProductoId { get; set; }
        public TipoProducto TipoProducto { get; set; }

        [JsonIgnore]
        public ICollection<SuscripcionItem> SuscripcionItems { get; set; }
    }
}
