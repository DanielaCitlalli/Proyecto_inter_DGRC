using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa25Dipeticion
    {
        public decimal Ta25EOid { get; set; }
        public decimal? Ta25ESecuencia { get; set; }
        public decimal Ta25EPrioridad { get; set; }
        public decimal Ta25EOperacionacto { get; set; }
        public string Ta25CCadena { get; set; }
        public DateTime? Ta25FEntrada { get; set; }
        public decimal? Ta25EEstatus { get; set; }
        public decimal? Ta07EEstadodest { get; set; }
        public decimal? Ta07EOiddestino { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public DateTime? Ta25FAtencion { get; set; }
        public decimal? Ta25ECuantos { get; set; }
    }
}
