//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Plataforma_CPFOriginal.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Administrador
    {
        public int idAdmin { get; set; }
        public string nombre { get; set; }
        public string app { get; set; }
        public string apm { get; set; }
        public string sexo { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string claveAdmin { get; set; }
        public int idUsuario { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
    }
}
