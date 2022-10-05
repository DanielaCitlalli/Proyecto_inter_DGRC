using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa18HdePeImpfor
    {
        public string Ta18ECurp { get; set; }
        public decimal? Ta18EEstadodest { get; set; }
        public decimal? Ta18EEstadoorig { get; set; }
        public string Ta18ETipo { get; set; }
        public string Ta18CPaterno { get; set; }
        public string Ta18CMaterno { get; set; }
        public string Ta18CNombres { get; set; }
        public DateTime? Ta18FNacimiento { get; set; }
        public string Ta18CSexo { get; set; }
        public DateTime? Ta18FEntrada { get; set; }
        public decimal? Ta18EOidestado { get; set; }
        public decimal Ta18EOid { get; set; }
        public string Ta08CCadena { get; set; }
        public int? Ta08EBusqueda { get; set; }
        public decimal? Ta07ESolicitarimagen { get; set; }
        public decimal? Ta18EEstatus { get; set; }
    }
}
