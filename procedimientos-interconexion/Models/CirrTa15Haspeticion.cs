using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa15Haspeticion
    {
        public int? Ta15ESecuencia { get; set; }
        public int? Ta15EPrioridad { get; set; }
        public decimal? Ta15EOperacionacto { get; set; }
        public string Ta15CCadena { get; set; }
        public DateTime? Ta15FEntrada { get; set; }
        public decimal? Ta15EEstatus { get; set; }
        public decimal? Ta15EOid { get; set; }
        public DateTime? Ta05FAtencion { get; set; }
        public int? Ta05ECuantos { get; set; }
        public DateTime? Ta05FSalida { get; set; }
        public decimal? Ta07EEstadodest { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public decimal? Ta07EOiddestino { get; set; }
    }
}
