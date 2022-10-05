using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class BitacoraImpresion
    {
        public string Cadena { get; set; }
        public string Usuario { get; set; }
        public DateTime? FechaImpresion { get; set; }
        public string EntidadOrigen { get; set; }
        public string EntidadDestino { get; set; }
        public decimal? Cantidad { get; set; }
        public decimal? OidPeticion { get; set; }
        public decimal? OidRespuesta { get; set; }
    }
}
