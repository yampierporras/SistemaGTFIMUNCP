//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SistemaGTFIMUNCP.Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Requisito_procedimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Requisito_procedimiento()
        {
            this.Solicitud = new HashSet<Solicitud>();
        }
    
        public int idReqProc { get; set; }
        public string requisitosProc { get; set; }
        public int idProcedimiento { get; set; }
    
        public virtual Procedimiento Procedimiento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solicitud> Solicitud { get; set; }
    }
}
