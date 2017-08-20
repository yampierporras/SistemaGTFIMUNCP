using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;

namespace SistemaGTFIMUNCP.Repositorio
{
	public class AdFacultad : iOperaciones<Facultad>
	{
		public List<Facultad> listarTodos()
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Facultades.ToList();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool registrar(Facultad entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					ctx.Facultades.Add(entidad);
					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public Facultad consultar(int id)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Facultades.SingleOrDefault(x => x.idFacultad == id);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool actualizar(Facultad entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					Facultad facultad = ctx.Facultades.SingleOrDefault(x => x.idFacultad == entidad.idFacultad);
					facultad.nomFacultad = entidad.nomFacultad;
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
					ctx.Facultades.Remove(ctx.Facultades.SingleOrDefault(x => x.idFacultad == id));
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
