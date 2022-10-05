using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class BitacoraRnp
    {
        public int IdBit { get; set; }
        public string Cadena { get; set; }
        public DateTime? FechaInsert { get; set; }
        public string Estatus { get; set; }
        public int? Movimiento { get; set; }
        public int? Acto { get; set; }
        public string CveOficialia { get; set; }
        public short? Ano { get; set; }
        public string Tramite { get; set; }
        public string Servicio { get; set; }
    }
}
