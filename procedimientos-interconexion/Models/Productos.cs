using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class Productos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? ProveedorId { get; set; }
        public decimal? Costo { get; set; }
        public decimal? Precio { get; set; }
        public int? CategoriaId { get; set; }
    }
}
