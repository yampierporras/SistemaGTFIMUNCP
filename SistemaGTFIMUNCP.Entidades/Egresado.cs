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
    
    public partial class Egresado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Egresado()
        {
            this.Documento = new HashSet<Documento>();
            this.PlanTesis = new HashSet<PlanTesis>();
            this.Solicitud = new HashSet<Solicitud>();
        }
    
        public int idEgresado { get; set; }
        public string nomEgresado { get; set; }
        public string apePatEgresado { get; set; }
        public string apeMatEgresado { get; set; }
        public string dniEgresado { get; set; }
        public string codMatEgresado { get; set; }
        public string condicionEgresado { get; set; }
        public string domicilioEgresado { get; set; }
        public string celEgresado { get; set; }
        public string emailEgresado { get; set; }
        public byte[] fotografiaEgresado { get; set; }
        public int idFacultad { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documento> Documento { get; set; }
        public virtual Facultad Facultad { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanTesis> PlanTesis { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Solicitud> Solicitud { get; set; }
    }
}