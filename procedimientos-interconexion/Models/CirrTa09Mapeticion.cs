using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa09Mapeticion
    {
        public decimal Ta09EOid { get; set; }
        public decimal? Ta09ESecuencia { get; set; }
        public decimal Ta09EPrioridad { get; set; }
        public decimal Ta09EOperacionacto { get; set; }
        public string Ta09CCadena { get; set; }
        public DateTime? Ta09FEntrada { get; set; }
        public decimal? Ta09EEstatus { get; set; }
        public decimal? Ta07EEstadodest { get; set; }
        public decimal? Ta07EOiddestino { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public DateTime? Ta09FAtencion { get; set; }
        public decimal? Ta09ECuantos { get; set; }
    }
}
