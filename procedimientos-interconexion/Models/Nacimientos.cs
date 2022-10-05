using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class Nacimientos
    {
        public string Cadena { get; set; }
        public string OtCrip { get; set; }
        public string PeCurp { get; set; }
        public DateTime? CoFechaRegistro { get; set; }
        public DateTime? PeFechanacimiento { get; set; }
        public string PePrimerapellido { get; set; }
        public string PeSegundoapellido { get; set; }
        public string PeNombres { get; set; }
        public string PeSexo { get; set; }
        public string PeLocalidadnacimiento { get; set; }
        public string OtNotasmarginales { get; set; }
        public string OtErrororigen { get; set; }
    }
}
