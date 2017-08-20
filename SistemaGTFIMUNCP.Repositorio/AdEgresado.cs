using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;

namespace SistemaGTFIMUNCP.Repositorio
{
	public class AdEgresado : iOperaciones<Egresado>
	{
		public List<Egresado> listarTodos()
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Egresados.ToList();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool registrar(Egresado entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					ctx.Egresados.Add(entidad);
					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public Egresado consultar(int id)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Egresados.SingleOrDefault(x => x.idEgresado == id);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool actualizar(Egresado entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					Egresado egresado = ctx.Egresados.SingleOrDefault(x => x.idEgresado == entidad.idEgresado);
					egresado.nomEgresado = entidad.nomEgresado;
					egresado.apePatEgresado = entidad.apePatEgresado;
					egresado.apeMatEgresado = entidad.apeMatEgresado;
					egresado.dniEgresado = entidad.dniEgresado;
					egresado.codMatEgresado = entidad.codMatEgresado;
					egresado.condicionEgresado = entidad.condicionEgresado;
					egresado.domicilioEgresado = entidad.domicilioEgresado;
					egresado.celEgresado = entidad.celEgresado;
					egresado.emailEgresado = entidad.emailEgresado;
					egresado.fotografiaEgresado = entidad.fotografiaEgresado;
					egresado.idFacultad = entidad.idFacultad;
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
					ctx.Egresados.Remove(ctx.Egresados.SingleOrDefault(x => x.idEgresado == id));
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
