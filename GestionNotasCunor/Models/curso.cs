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
    
    public partial class curso
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public curso()
        {
            this.asign_curso = new HashSet<asign_curso>();
        }
    
        public int id_curso { get; set; }
        public string cod_curso { get; set; }
        public string nom_curso { get; set; }
        public Nullable<int> creditos { get; set; }
        public int no_ciclo { get; set; }
        public Nullable<int> cod_prerrequisito { get; set; }
        public Nullable<int> creditos_necesarios { get; set; }
        public int id_caracteristica { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<asign_curso> asign_curso { get; set; }
        public virtual caracteristica caracteristica { get; set; }
    }
}
