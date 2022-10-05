using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa19Hmapeticion
    {
        public decimal Ta19EOid { get; set; }
        public decimal? Ta19ESecuencia { get; set; }
        public decimal? Ta19EPrioridad { get; set; }
        public decimal Ta19EOperacionacto { get; set; }
        public string Ta19CCadena { get; set; }
        public DateTime Ta19FEntrada { get; set; }
        public decimal? Ta19EEstatus { get; set; }
        public DateTime? Ta19FSalida { get; set; }
        public DateTime? Ta19FAtencion { get; set; }
        public decimal? Ta07EEstadodest { get; set; }
        public decimal? Ta07EOiddestino { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public decimal? Ta19ECuantos { get; set; }
    }
}
