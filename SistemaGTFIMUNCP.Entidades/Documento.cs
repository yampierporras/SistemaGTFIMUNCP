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
    
    public partial class Documento
    {
        public int idDocumento { get; set; }
        public string descDocumento { get; set; }
        public string tipoDocumento { get; set; }
        public Nullable<System.DateTime> fechaEmiDocumento { get; set; }
        public bool emisionDocumento { get; set; }
        public string nomEgresado { get; set; }
        public string apePatEgresado { get; set; }
        public string apeMatEgresado { get; set; }
        public string dniEgresado { get; set; }
        public string codMatEgresado { get; set; }
        public string condicionEgresado { get; set; }
        public byte[] fotografiaEgresado { get; set; }
        public string nomResponsable { get; set; }
        public string apePatResponsable { get; set; }
        public string apeMatResponsable { get; set; }
        public string cargoResponsable { get; set; }
        public string gradoAcaResponsable { get; set; }
        public string nomResponsable2 { get; set; }
        public string apePatResponsable2 { get; set; }
        public string apeMatResponsable2 { get; set; }
        public string cargoResponsable2 { get; set; }
        public string gradoAcaResponsable2 { get; set; }
        public string asuntoSolicitud { get; set; }
        public string numRegSolicitud { get; set; }
        public System.DateTime fechaRecSolicitud { get; set; }
        public string obsSolicitud { get; set; }
        public string reqSolicitud { get; set; }
        public bool validacionReqSolicitud { get; set; }
        public string usuario { get; set; }
        public string nomUsuario { get; set; }
        public string apePatUsuario { get; set; }
        public string apeMatUsuario { get; set; }
        public string dniUsuario { get; set; }
        public int idEgresado { get; set; }
        public int idResponsable { get; set; }
        public Nullable<int> idResponsable2 { get; set; }
        public int idSolicitud { get; set; }
        public int idUsuario { get; set; }
    
        public virtual Egresado Egresado { get; set; }
        public virtual Responsable Responsable { get; set; }
        public virtual Responsable Responsable1 { get; set; }
        public virtual Solicitud Solicitud { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}
