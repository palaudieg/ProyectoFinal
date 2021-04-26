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
    
    public partial class Alumnos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alumnos()
        {
            this.EntregaActividades = new HashSet<EntregaActividades>();
            this.EntregasTareas = new HashSet<EntregasTareas>();
            this.RespuestasAlumno = new HashSet<RespuestasAlumno>();
        }
    
        public int idAlumno { get; set; }
        public string nombre { get; set; }
        public string app { get; set; }
        public string apm { get; set; }
        public string sexo { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public int idUsuario { get; set; }
        public string seccion { get; set; }
        public string grado { get; set; }
        public string grupo { get; set; }
    
        public virtual Usuarios Usuarios { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntregaActividades> EntregaActividades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntregasTareas> EntregasTareas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RespuestasAlumno> RespuestasAlumno { get; set; }
    }
}
