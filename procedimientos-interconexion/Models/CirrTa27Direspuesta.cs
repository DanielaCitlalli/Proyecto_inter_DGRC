using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa27Direspuesta
    {
        public decimal Ta27EOid { get; set; }
        public decimal Ta27EOperacionacto { get; set; }
        public decimal? Ta25EOid { get; set; }
        public string Ta27CDescError { get; set; }
        public string Ta27CCadena { get; set; }
        public string Ta27CCurp { get; set; }
        public DateTime? Ta27FEntrada { get; set; }
        public decimal? Ta27EEstatus { get; set; }
        public string Ta27EError { get; set; }
        public string Ta27BSello { get; set; }
    }
}
