using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;

namespace SistemaGTFIMUNCP.Repositorio
{
	public class AdRequisito_procedimiento : iOperaciones<Requisito_procedimiento>
	{
		public List<Requisito_procedimiento> listarTodos()
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Requisitos_procedimiento.ToList();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool registrar(Requisito_procedimiento entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					ctx.Requisitos_procedimiento.Add(entidad);
					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public Requisito_procedimiento consultar(int id)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Requisitos_procedimiento.SingleOrDefault(x => x.idReqProc == id);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool actualizar(Requisito_procedimiento entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					Requisito_procedimiento requisito_procedimiento = ctx.Requisitos_procedimiento.SingleOrDefault(x => x.idReqProc == entidad.idReqProc);
					requisito_procedimiento.requisitosProc = entidad.requisitosProc;
					requisito_procedimiento.idProcedimiento = entidad.idProcedimiento;
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
					ctx.Requisitos_procedimiento.Remove(ctx.Requisitos_procedimiento.SingleOrDefault(x => x.idReqProc == id));
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
