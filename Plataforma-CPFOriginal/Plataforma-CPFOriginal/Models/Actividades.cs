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
    
    public partial class Actividades
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Actividades()
        {
            this.EntregaActividades = new HashSet<EntregaActividades>();
        }
    
        public int idActividad { get; set; }
        public string nombre { get; set; }
        public string tema { get; set; }
        public System.DateTime fecha_inicio { get; set; }
        public System.DateTime fecha_final { get; set; }
        public string descripcion { get; set; }
        public System.TimeSpan tiempo { get; set; }
        public string valor_asignado { get; set; }
        public string status { get; set; }
        public int idMateria { get; set; }
        public int idMaestro { get; set; }
    
        public virtual Maestros Maestros { get; set; }
        public virtual Materias Materias { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EntregaActividades> EntregaActividades { get; set; }
    }
}
