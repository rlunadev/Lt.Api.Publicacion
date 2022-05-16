using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Lt.Api.Publicaciones.Models
{
    public class TipoProducto
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        [JsonIgnore]
        public ICollection<Producto> Producto { get; set; }
    }
}
