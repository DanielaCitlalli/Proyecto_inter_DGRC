using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa22Adrespuesta
    {
        public decimal Ta22EOid { get; set; }
        public decimal Ta22EOperacionacto { get; set; }
        public decimal? Ta05EOid { get; set; }
        public string Ta22CDescError { get; set; }
        public string Ta22CCadena { get; set; }
        public string Ta22CCurp { get; set; }
        public DateTime? Ta22FEntrada { get; set; }
        public decimal? Ta22EEstatus { get; set; }
        public string Ta22EError { get; set; }
        public string Ta22BSello { get; set; }
    }
}
