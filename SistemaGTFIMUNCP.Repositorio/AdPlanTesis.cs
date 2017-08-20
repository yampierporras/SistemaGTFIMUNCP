using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;

namespace SistemaGTFIMUNCP.Repositorio
{
	public class AdPlanTesis : iOperaciones<PlanTesis>
	{
		public List<PlanTesis> listarTodos()
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.PlanTesis.ToList();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool registrar(PlanTesis entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					ctx.PlanTesis.Add(entidad);
					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public PlanTesis consultar(int id)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.PlanTesis.SingleOrDefault(x => x.idPlanTesis == id);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool actualizar(PlanTesis entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					PlanTesis planTesis = ctx.PlanTesis.SingleOrDefault(x => x.idPlanTesis == entidad.idPlanTesis);
					planTesis.nomAsesor = entidad.nomAsesor;
					planTesis.apePatAsesor = entidad.apePatAsesor;
					planTesis.apeMatAsesor = entidad.apeMatAsesor;
					planTesis.nomAsesor2 = entidad.nomAsesor2;
					planTesis.apePatAsesor2 = entidad.apePatAsesor2;
					planTesis.apeMatAsesor2 = entidad.apeMatAsesor2;
					planTesis.tituloTesis = entidad.tituloTesis;
					planTesis.fechaInscripcion = entidad.fechaInscripcion;
					planTesis.idEgresado = entidad.idEgresado;
					planTesis.idSolicitud = entidad.idSolicitud;
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
					ctx.PlanTesis.Remove(ctx.PlanTesis.SingleOrDefault(x => x.idPlanTesis == id));
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
