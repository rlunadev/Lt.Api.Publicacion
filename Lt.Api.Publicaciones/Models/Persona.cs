using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Lt.Api.Publicaciones.Models
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        
        [JsonIgnore]
        public ICollection<Suscripcion> Suscripcions { get; set; }
    }
}
