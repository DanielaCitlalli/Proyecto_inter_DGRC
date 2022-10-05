using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrTa26Marespuesta
    {
        public decimal Ta26EOid { get; set; }
        public decimal Ta26EOperacionacto { get; set; }
        public decimal? Ta09EOid { get; set; }
        public string Ta26CDescError { get; set; }
        public string Ta26CCadena { get; set; }
        public string Ta26CCurp { get; set; }
        public DateTime? Ta26FEntrada { get; set; }
        public decimal? Ta26EEstatus { get; set; }
        public string Ta26EError { get; set; }
        public string Ta26BSello { get; set; }
    }
}
