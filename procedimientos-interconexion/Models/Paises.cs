using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class Paises
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string NombreLocal { get; set; }
        public string Iso { get; set; }
        public string Iso3 { get; set; }
        public string Continente { get; set; }
        public string Region { get; set; }
    }
}
