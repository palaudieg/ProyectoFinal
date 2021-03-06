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
    
    public partial class Materias
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Materias()
        {
            this.Actividades = new HashSet<Actividades>();
            this.Examenes = new HashSet<Examenes>();
            this.Tareas = new HashSet<Tareas>();
        }
    
        public int idMateria { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
        public System.DateTime fecha_i { get; set; }
        public System.DateTime fecha_f { get; set; }
        public System.TimeSpan horasxs { get; set; }
        public string descripcion { get; set; }
        public string grado { get; set; }
        public string grupo { get; set; }
        public string seccion { get; set; }
        public string status { get; set; }
        public int idMaestro { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Actividades> Actividades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Examenes> Examenes { get; set; }
        public virtual Maestros Maestros { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tareas> Tareas { get; set; }
    }
}
