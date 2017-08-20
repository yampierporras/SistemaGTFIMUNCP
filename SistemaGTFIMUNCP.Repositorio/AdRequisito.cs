using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;

namespace SistemaGTFIMUNCP.Repositorio
{
	public class AdRequisito : iOperaciones<Requisito>
	{
		public List<Requisito> listarTodos()
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Requisitos.ToList();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool registrar(Requisito entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					ctx.Requisitos.Add(entidad);
					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public Requisito consultar(int id)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Requisitos.SingleOrDefault(x => x.idRequisito == id);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool actualizar(Requisito entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					Requisito requisito = ctx.Requisitos.SingleOrDefault(x => x.idRequisito == entidad.idRequisito);
					requisito.carRequisito = entidad.carRequisito;
					requisito.descRequisito = entidad.descRequisito;
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
					ctx.Requisitos.Remove(ctx.Requisitos.SingleOrDefault(x => x.idRequisito == id));
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
