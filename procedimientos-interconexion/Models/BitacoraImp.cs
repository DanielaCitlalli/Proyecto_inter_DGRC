using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class BitacoraImp
    {
        public decimal IdBitacora { get; set; }
        public string Usuario { get; set; }
        public string Rol { get; set; }
        public decimal? NumImp { get; set; }
        public string Acto { get; set; }
        public string TipoImp { get; set; }
        public DateTime FechaHora { get; set; }
    }
}
