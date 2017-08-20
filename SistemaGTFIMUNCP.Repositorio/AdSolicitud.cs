using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;

namespace SistemaGTFIMUNCP.Repositorio
{
	public class AdSolicitud : iOperaciones<Solicitud>
	{
		public List<Solicitud> listarTodos()
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Solicitudes.ToList();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool registrar(Solicitud entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					ctx.Solicitudes.Add(entidad);
					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public Solicitud consultar(int id)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Solicitudes.SingleOrDefault(x => x.idSolicitud == id);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool actualizar(Solicitud entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					Solicitud solicitud = ctx.Solicitudes.SingleOrDefault(x => x.idSolicitud == entidad.idSolicitud);
					solicitud.asuntoSolicitud = entidad.asuntoSolicitud;
					solicitud.numRegSolicitud = entidad.numRegSolicitud;
					solicitud.fechaRecSolicitud = entidad.fechaRecSolicitud;
					solicitud.obsSolicitud = entidad.obsSolicitud;
					solicitud.reqSolicitud = entidad.reqSolicitud;
					solicitud.validacionReqSolicitud = entidad.validacionReqSolicitud;
					solicitud.estadoSolicitud = entidad.estadoSolicitud;
					solicitud.atencionSolicitud = entidad.atencionSolicitud;
					solicitud.idReqProc = entidad.idReqProc;
					solicitud.idEgresado = entidad.idEgresado;
					solicitud.idUsuario = entidad.idUsuario;
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
					ctx.Solicitudes.Remove(ctx.Solicitudes.SingleOrDefault(x => x.idSolicitud == id));
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
