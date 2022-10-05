using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa05Aspeticion
    {
        public decimal Ta05EOid { get; set; }
        public int? Ta05ESecuencia { get; set; }
        public int Ta05EPrioridad { get; set; }
        public decimal Ta05EOperacionacto { get; set; }
        public string Ta05CCadena { get; set; }
        public decimal? Ta05EEstatus { get; set; }
        public DateTime? Ta05FEntrada { get; set; }
        public decimal? Ta07EEstadodest { get; set; }
        public decimal? Ta07EOiddestino { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public DateTime? Ta05FAtencion { get; set; }
        public int? Ta05ECuantos { get; set; }
    }
}
