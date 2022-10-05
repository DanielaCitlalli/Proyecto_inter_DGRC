using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa01Napeticion
    {
        public decimal Ta01EOid { get; set; }
        public decimal? Ta01ESecuencia { get; set; }
        public decimal? Ta01EPrioridad { get; set; }
        public decimal Ta01EOperacionacto { get; set; }
        public string Ta01CCadena { get; set; }
        public DateTime? Ta01FEntrada { get; set; }
        public decimal? Ta01EEstatus { get; set; }
        public decimal? Ta07EEstadodest { get; set; }
        public decimal? Ta07EOiddestino { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public DateTime? Ta01FAtencion { get; set; }
        public int? Ta01ECuantos { get; set; }
    }
}
