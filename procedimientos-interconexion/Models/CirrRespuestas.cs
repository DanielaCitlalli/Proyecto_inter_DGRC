using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class CirrRespuestas
    {
        public long Id { get; set; }
        public int? Acto { get; set; }
        public int? Oid { get; set; }
        public int? Prioridad { get; set; }
        public DateTime? Fecha { get; set; }
    }
}
