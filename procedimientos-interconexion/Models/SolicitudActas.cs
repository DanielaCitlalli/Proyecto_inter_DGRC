using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class SolicitudActas
    {
        public int IdSolicitud { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Curp { get; set; }
        public int IdSolicitudActa { get; set; }
        public string EstatusSolicitud { get; set; }
        public string Obrservaciones { get; set; }
        public string Correoe { get; set; }
        public string Telefono { get; set; }
        public int IdActaSiceg { get; set; }
        public string Acta { get; set; }
        public int Idacto { get; set; }
        public string LineaCaptura { get; set; }
    }
}
