using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Lt.Api.Publicaciones.Core;

namespace Lt.Api.Publicaciones.Models
{
    public class Suscripcion : EntityBase
    {
        [Column(TypeName = "decimal(18,2)")]
        public double Adelanto { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public double Saldo { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public double Total { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime FechaPedido { get; set; }
        public bool Entregado { get; set; }
        public string Detalle { get; set; }
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }
        public int GrupoSuscripcionId { get; set; }
        public GrupoSuscripcion GrupoSuscripcion { get; set; }

        [JsonIgnore]
        public ICollection<SuscripcionItem> SuscripcionItems { get; set; }
    }
}
