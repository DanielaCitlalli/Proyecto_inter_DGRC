using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa21Narespuesta
    {
        public decimal Ta21EOid { get; set; }
        public decimal Ta21EOperacionacto { get; set; }
        public decimal? Ta01EOid { get; set; }
        public string Ta21CDescError { get; set; }
        public string Ta21CCadena { get; set; }
        public string Ta21CCurp { get; set; }
        public DateTime? Ta21FEntrada { get; set; }
        public decimal? Ta21EEstatus { get; set; }
        public string Ta21EError { get; set; }
        public string Ta21BSello { get; set; }
    }
}
