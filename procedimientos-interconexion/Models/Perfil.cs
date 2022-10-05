using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class Perfil
    {
        public decimal IdPerfil { get; set; }
        public decimal IdUsu { get; set; }
        public decimal IdRol { get; set; }
    }
}
