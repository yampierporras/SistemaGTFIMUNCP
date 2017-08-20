using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;

namespace SistemaGTFIMUNCP.Repositorio
{
	public class AdProcedimiento : iOperaciones<Procedimiento>
	{
		public List<Procedimiento> listarTodos()
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Procedimientos.ToList();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool registrar(Procedimiento entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					ctx.Procedimientos.Add(entidad);
					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public Procedimiento consultar(int id)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Procedimientos.SingleOrDefault(x => x.idProcedimiento == id);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool actualizar(Procedimiento entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					Procedimiento procedimiento = ctx.Procedimientos.SingleOrDefault(x => x.idProcedimiento == entidad.idProcedimiento);
					procedimiento.descProcedimiento = entidad.descProcedimiento;
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
					ctx.Procedimientos.Remove(ctx.Procedimientos.SingleOrDefault(x => x.idProcedimiento == id));
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
