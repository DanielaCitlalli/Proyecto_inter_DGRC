using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa06Repeticion
    {
        public decimal Ta06EOid { get; set; }
        public int? Ta06ESecuencia { get; set; }
        public int Ta06EPrioridad { get; set; }
        public decimal Ta06EOperacionacto { get; set; }
        public string Ta06CCadena { get; set; }
        public decimal? Ta06EEstatus { get; set; }
        public DateTime? Ta06FEntrada { get; set; }
        public decimal? Ta07EEstadodest { get; set; }
        public decimal? Ta07EOiddestino { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public DateTime? Ta06FAtencion { get; set; }
        public int? Ta06ECuantos { get; set; }
    }
}
