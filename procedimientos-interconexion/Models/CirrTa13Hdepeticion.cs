using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa13Hdepeticion
    {
        public int? Ta13ESecuencia { get; set; }
        public int? Ta13EPrioridad { get; set; }
        public decimal? Ta13EOperacionacto { get; set; }
        public string Ta13CCadena { get; set; }
        public DateTime? Ta13FEntrada { get; set; }
        public decimal? Ta13EEstatus { get; set; }
        public decimal? Ta13EOid { get; set; }
        public DateTime? Ta03FAtencion { get; set; }
        public int? Ta03ECuantos { get; set; }
        public DateTime? Ta03FSalida { get; set; }
        public decimal? Ta07EEstadodest { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public decimal? Ta07EOiddestino { get; set; }
    }
}
