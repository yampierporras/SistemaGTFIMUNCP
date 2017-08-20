using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;

namespace SistemaGTFIMUNCP.Repositorio
{
	public class AdDocumento : iOperaciones<Documento>
	{
		public List<Documento> listarTodos()
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Documentos.ToList();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool registrar(Documento entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					ctx.Documentos.Add(entidad);
					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public Documento consultar(int id)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Documentos.SingleOrDefault(x => x.idDocumento == id);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool actualizar(Documento entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					Documento documento = ctx.Documentos.SingleOrDefault(x => x.idDocumento == entidad.idDocumento);
					documento.descDocumento = entidad.descDocumento;
					documento.tipoDocumento = entidad.tipoDocumento;
					documento.fechaEmiDocumento = entidad.fechaEmiDocumento;
					documento.emisionDocumento = entidad.emisionDocumento;
					//Datos del Egresado
					documento.nomEgresado = entidad.nomEgresado;
					documento.apePatEgresado = entidad.apePatEgresado;
					documento.apeMatEgresado = entidad.apeMatEgresado;
					documento.dniEgresado = entidad.dniEgresado;
					documento.dniEgresado = entidad.dniEgresado;
					documento.codMatEgresado = entidad.codMatEgresado;
					documento.condicionEgresado = entidad.condicionEgresado;
					documento.fotografiaEgresado = entidad.fotografiaEgresado;
					//Datos del Responsable
					documento.nomResponsable = entidad.nomResponsable;
					documento.apePatResponsable = entidad.apePatResponsable;
					documento.apeMatResponsable = entidad.apeMatResponsable;
					documento.cargoResponsable = entidad.cargoResponsable;
					documento.gradoAcaResponsable = entidad.gradoAcaResponsable;
					//Datos del Responsable2 si hubiese
					documento.nomResponsable2 = entidad.nomResponsable2;
					documento.apePatResponsable2 = entidad.apePatResponsable2;
					documento.apeMatResponsable2 = entidad.apeMatResponsable2;
					documento.cargoResponsable2 = entidad.cargoResponsable2;
					documento.gradoAcaResponsable2 = entidad.gradoAcaResponsable2;
					//Datos de la solicitud
					documento.asuntoSolicitud = entidad.asuntoSolicitud;
					documento.numRegSolicitud = entidad.numRegSolicitud;
					documento.fechaRecSolicitud = entidad.fechaRecSolicitud;
					documento.obsSolicitud = entidad.obsSolicitud;
					documento.reqSolicitud = entidad.reqSolicitud;
					documento.validacionReqSolicitud = entidad.validacionReqSolicitud;
					//Datos del Usuario
					documento.usuario = entidad.usuario;
					documento.nomUsuario = entidad.nomUsuario;
					documento.apePatUsuario = entidad.apePatUsuario;
					documento.apeMatUsuario = entidad.apeMatUsuario;
					documento.dniUsuario = entidad.dniUsuario;
					//Datos del egresado
					documento.idEgresado = entidad.idEgresado;
					documento.idResponsable = entidad.idResponsable;
					documento.idResponsable2 = entidad.idResponsable2;
					documento.idSolicitud = entidad.idSolicitud;
					documento.idUsuario = entidad.idUsuario;

					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}
		
		public bool eliminar(int id)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					ctx.Documentos.Remove(ctx.Documentos.SingleOrDefault(x => x.idDocumento == id));
					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}
	}
}
