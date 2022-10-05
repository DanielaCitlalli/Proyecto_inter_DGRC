using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa30Serespuesta
    {
        public decimal Ta30EOid { get; set; }
        public decimal Ta30EOperacionacto { get; set; }
        public decimal? Ta29EOid { get; set; }
        public string Ta30CDescError { get; set; }
        public string Ta30CCadena { get; set; }
        public string Ta30CCurp { get; set; }
        public DateTime? Ta30FEntrada { get; set; }
        public decimal? Ta30EEstatus { get; set; }
        public string Ta30EError { get; set; }
        public string Ta30BSello { get; set; }
    }
}
