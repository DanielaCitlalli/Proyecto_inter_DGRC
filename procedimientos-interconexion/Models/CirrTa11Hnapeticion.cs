using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa11Hnapeticion
    {
        public decimal? Ta11ESecuencia { get; set; }
        public decimal? Ta11EPrioridad { get; set; }
        public decimal? Ta11EOperacionacto { get; set; }
        public string Ta11CCadena { get; set; }
        public DateTime? Ta11FEntrada { get; set; }
        public decimal? Ta11EEstatus { get; set; }
        public decimal? Ta11EOid { get; set; }
        public DateTime? Ta11FFsalida01 { get; set; }
        public DateTime? Ta01FAtencion { get; set; }
        public int? Ta01ECuantos { get; set; }
        public DateTime? Ta01FSalida { get; set; }
        public decimal? Ta07EEstadodest { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public decimal? Ta07EOiddestino { get; set; }
    }
}
