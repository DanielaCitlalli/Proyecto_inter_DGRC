using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa24Derespuesta
    {
        public decimal Ta24EOid { get; set; }
        public decimal Ta24EOperacionacto { get; set; }
        public decimal? Ta03EOid { get; set; }
        public string Ta24CDescError { get; set; }
        public string Ta24CCadena { get; set; }
        public string Ta24CCurp { get; set; }
        public DateTime? Ta24FEntrada { get; set; }
        public decimal? Ta24EEstatus { get; set; }
        public string Ta24EError { get; set; }
        public string Ta24BSello { get; set; }
    }
}
