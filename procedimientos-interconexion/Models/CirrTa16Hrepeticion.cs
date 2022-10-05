using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa16Hrepeticion
    {
        public int? Ta16ESecuencia { get; set; }
        public int? Ta16EPrioridad { get; set; }
        public decimal? Ta16EOperacionacto { get; set; }
        public string Ta16CCadena { get; set; }
        public DateTime? Ta16FEntrada { get; set; }
        public decimal? Ta16EEstatus { get; set; }
        public decimal? Ta16EOid { get; set; }
        public DateTime? Ta06FAtencion { get; set; }
        public int? Ta06ECuantos { get; set; }
        public DateTime? Ta06FSalida { get; set; }
        public decimal? Ta07EEstadodest { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public decimal? Ta07EOiddestino { get; set; }
    }
}
