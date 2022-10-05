using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class Usuarios
    {
        public decimal IdUsu { get; set; }
        public string Usunombre { get; set; }
        public string Apellidos { get; set; }
        public string Usulogin { get; set; }
        public byte[] Usupaswd { get; set; }
        public decimal? Activo { get; set; }
        public byte[] Salt { get; set; }
        public decimal? Estado { get; set; }
    }
}
