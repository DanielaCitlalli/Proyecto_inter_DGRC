using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa20HorReImpfor
    {
        public decimal Ta20EOid { get; set; }
        public decimal? Ta20EEstadodest { get; set; }
        public decimal? Ta20EEstadoorig { get; set; }
        public decimal? Ta20EOidorigen { get; set; }
        public byte[] Ta20BImagen { get; set; }
        public DateTime? Ta20FEntrada { get; set; }
        public string Ta20CCadena { get; set; }
        public decimal? Ta20EEstatus { get; set; }
    }
}
