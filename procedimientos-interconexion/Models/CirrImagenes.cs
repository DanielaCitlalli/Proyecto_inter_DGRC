using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrImagenes
    {
        public decimal Idconsec { get; set; }
        public decimal? Idproc { get; set; }
        public string Cadena { get; set; }
        public string Ubicacion { get; set; }
        public string Res { get; set; }
        public DateTime? Fechaproc { get; set; }
    }
}
