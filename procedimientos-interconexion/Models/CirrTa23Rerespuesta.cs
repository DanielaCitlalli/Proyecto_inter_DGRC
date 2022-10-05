using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa23Rerespuesta
    {
        public decimal Ta23EOid { get; set; }
        public decimal Ta23EOperacionacto { get; set; }
        public decimal? Ta06EOid { get; set; }
        public string Ta23CDescError { get; set; }
        public string Ta23CCadena { get; set; }
        public string Ta23CCurp { get; set; }
        public DateTime? Ta23FEntrada { get; set; }
        public decimal? Ta23EEstatus { get; set; }
        public string Ta23EError { get; set; }
        public string Ta23BSello { get; set; }
    }
}
