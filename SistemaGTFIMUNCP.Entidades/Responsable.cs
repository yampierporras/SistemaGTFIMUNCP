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
    
    public partial class Responsable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Responsable()
        {
            this.Documento = new HashSet<Documento>();
            this.Documento1 = new HashSet<Documento>();
            this.Procedimiento = new HashSet<Procedimiento>();
        }
    
        public int idResponsable { get; set; }
        public string nomResponsable { get; set; }
        public string apePatResponsable { get; set; }
        public string apeMatResponsable { get; set; }
        public string cargoResponsable { get; set; }
        public string gradoAcaResponsable { get; set; }
        public bool estadoResponsable { get; set; }
        public string celResponsable { get; set; }
        public int idArea { get; set; }
    
        public virtual Area Area { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documento> Documento { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documento> Documento1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Procedimiento> Procedimiento { get; set; }
    }
}