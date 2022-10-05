using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class Usuariorear
    {
        public decimal? Usuid { get; set; }
        public string Usulogin { get; set; }
        public string Usupaswd { get; set; }
        public string Usunombre { get; set; }
        public string Usutel { get; set; }
        public string Usuemail { get; set; }
        public string Usuactivo { get; set; }
        public string Grupousuclave { get; set; }
        public string Entidad { get; set; }
        public string Municipio { get; set; }
        public string Oficialia { get; set; }
    }
}
