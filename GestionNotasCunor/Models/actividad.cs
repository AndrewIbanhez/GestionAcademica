//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionNotasCunor.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class actividad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public actividad()
        {
            this.calificacion = new HashSet<calificacion>();
        }
    
        public int id_actividad { get; set; }
        public string nom_actividad { get; set; }
        public decimal valor { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public int id_carrera { get; set; }
        public int id_curso { get; set; }
        public string seccion { get; set; }
    
        public virtual asign_curso asign_curso { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<calificacion> calificacion { get; set; }
    }
}
