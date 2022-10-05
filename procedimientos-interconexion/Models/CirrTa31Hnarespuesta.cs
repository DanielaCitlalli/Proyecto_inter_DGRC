using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa31Hnarespuesta
    {
        public decimal? Ta31EOid { get; set; }
        public decimal? Ta31EOperacionacto { get; set; }
        public decimal? Ta01EOid { get; set; }
        public string Ta01CDescError { get; set; }
        public string Ta31CCadena { get; set; }
        public string Ta31CCurp { get; set; }
        public DateTime? Ta31FEntrada { get; set; }
        public decimal? Ta31EEstatus { get; set; }
        public string Ta01EError { get; set; }
        public string Ta31BSello { get; set; }
    }
}
