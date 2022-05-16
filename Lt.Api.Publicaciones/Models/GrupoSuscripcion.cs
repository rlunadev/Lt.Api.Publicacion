using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Lt.Api.Publicaciones.Models
{
    public class GrupoSuscripcion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public bool Status { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime FechaInicial { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime FechaFinal { get; set; }

        [JsonIgnore]
        public ICollection<Suscripcion> Suscripcions { get; set; }
    }
}
