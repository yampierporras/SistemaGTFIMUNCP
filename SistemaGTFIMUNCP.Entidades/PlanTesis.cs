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
    
    public partial class PlanTesis
    {
        public int idPlanTesis { get; set; }
        public string nomAsesor { get; set; }
        public string apePatAsesor { get; set; }
        public string apeMatAsesor { get; set; }
        public string nomAsesor2 { get; set; }
        public string apePatAsesor2 { get; set; }
        public string apeMatAsesor2 { get; set; }
        public string tituloTesis { get; set; }
        public System.DateTime fechaInscripcion { get; set; }
        public int idEgresado { get; set; }
        public int idSolicitud { get; set; }
    
        public virtual Egresado Egresado { get; set; }
        public virtual Solicitud Solicitud { get; set; }
    }
}