using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa29Sepeticion
    {
        public decimal Ta29EOid { get; set; }
        public decimal? Ta29ESecuencia { get; set; }
        public decimal Ta29EPrioridad { get; set; }
        public decimal Ta29EOperacionacto { get; set; }
        public string Ta29CCadena { get; set; }
        public DateTime? Ta29FEntrada { get; set; }
        public decimal? Ta29EEstatus { get; set; }
        public decimal? Ta07EEstadodest { get; set; }
        public decimal? Ta07EOiddestino { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public DateTime? Ta29FAtencion { get; set; }
        public decimal? Ta29ECuantos { get; set; }
    }
}
