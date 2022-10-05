using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa17HorPeImpfor
    {
        public string Ta17ECurp { get; set; }
        public decimal? Ta17EEstadodest { get; set; }
        public decimal? Ta17EEstadoorig { get; set; }
        public string Ta17ETipo { get; set; }
        public string Ta17CPaterno { get; set; }
        public string Ta17CMaterno { get; set; }
        public string Ta17CNombres { get; set; }
        public DateTime? Ta17FNacimiento { get; set; }
        public string Ta17CSexo { get; set; }
        public DateTime? Ta17FEntrada { get; set; }
        public decimal Ta17EOid { get; set; }
        public decimal? Ta17ESolicitarimagen { get; set; }
        public DateTime? Ta07FAtencion { get; set; }
        public int? Ta07ECuantos { get; set; }
        public DateTime? Ta07FSalida { get; set; }
        public decimal? Ta17EEstatus { get; set; }
        public string Ta07CCadena { get; set; }
        public int? Ta07EBusqueda { get; set; }
    }
}
