using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa03Depeticion
    {
        public decimal Ta03EOid { get; set; }
        public decimal? Ta03EPrioridad { get; set; }
        public decimal Ta03EOperacionacto { get; set; }
        public string Ta03CCadena { get; set; }
        public decimal? Ta03EEstatus { get; set; }
        public DateTime? Ta03FEntrada { get; set; }
        public decimal? Ta07EEstadodest { get; set; }
        public decimal? Ta07EOiddestino { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public decimal? Ta03ESecuencia { get; set; }
        public DateTime? Ta03FAtencion { get; set; }
        public int? Ta03ECuantos { get; set; }
    }
}
