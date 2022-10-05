using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa10OrReImpfor
    {
        public decimal Ta10EOid { get; set; }
        public decimal? Ta10EEstadodest { get; set; }
        public decimal? Ta10EEstadoorig { get; set; }
        public decimal Ta10EOidorigen { get; set; }
        public byte[] Ta10BImagen { get; set; }
        public DateTime? Ta10FEntrada { get; set; }
        public string Ta10CCadena { get; set; }
        public decimal? Ta10EEstatus { get; set; }
        public decimal? Ta07EOidimpresion { get; set; }
        public DateTime? Ta10FAtencion { get; set; }
        public decimal? Ta10ECuantos { get; set; }
        public string T10ETipo { get; set; }
    }
}
