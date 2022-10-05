using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa35Hdipeticion
    {
        public decimal Ta35EOid { get; set; }
        public decimal Ta35ESecuencia { get; set; }
        public decimal Ta35EPrioridad { get; set; }
        public decimal Ta35EOperacionacto { get; set; }
        public string Ta35CCadena { get; set; }
        public DateTime Ta35FEntrada { get; set; }
        public decimal? Ta35EEstatus { get; set; }
        public DateTime? Ta35FSalida { get; set; }
        public DateTime? Ta35FAtencion { get; set; }
        public decimal? Ta07EEstadodest { get; set; }
        public decimal? Ta07EOiddestino { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public decimal? Ta35ECuantos { get; set; }
    }
}
