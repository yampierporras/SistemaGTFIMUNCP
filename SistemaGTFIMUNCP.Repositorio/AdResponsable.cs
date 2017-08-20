using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;

namespace SistemaGTFIMUNCP.Repositorio
{
	public class AdResponsable : iOperaciones<Responsable>
	{
		public List<Responsable> listarTodos()
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Responsables.ToList();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool registrar(Responsable entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					if (entidad.cargoResponsable == "Decano")
					{
						for (int i = 1; i < 5; i++)
						{
							var procedimiento = new Procedimiento { idProcedimiento = i };
							ctx.Procedimientos.Attach(procedimiento);
							entidad.Procedimiento.Add(procedimiento);
						}
					}

					ctx.Responsables.Add(entidad);
					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public Responsable consultar(int id)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Responsables.SingleOrDefault(x => x.idResponsable == id);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool actualizar(Responsable entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					Responsable responsable = ctx.Responsables.SingleOrDefault(x => x.idResponsable == entidad.idResponsable);
					if (responsable.cargoResponsable == "Inactivo" && entidad.cargoResponsable == "Decano")
					{
						for (int i = 1; i < 5; i++)
						{
							var procedimiento = new Procedimiento { idProcedimiento = i };
							ctx.Procedimientos.Attach(procedimiento);
							responsable.Procedimiento.Add(procedimiento);
						}
					}
					if (responsable.cargoResponsable == "Decano" && entidad.cargoResponsable == "Inactivo")
					{
						responsable.Procedimiento.Clear();
					}
					responsable.nomResponsable = entidad.nomResponsable;
					responsable.apePatResponsable = entidad.apePatResponsable;
					responsable.apeMatResponsable = entidad.apeMatResponsable;
					responsable.cargoResponsable = entidad.cargoResponsable;
					responsable.gradoAcaResponsable = entidad.gradoAcaResponsable;
					responsable.estadoResponsable = entidad.estadoResponsable;
					responsable.celResponsable = entidad.celResponsable;
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
					ctx.Responsables.Remove(ctx.Responsables.SingleOrDefault(x => x.idArea == id));
					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}
		//METODOS PERSONALES
		public List<Responsable> listarResponsablePorProcedimiento(int idReqProc)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities bd = new SistemaGTFIMUNCPEntities())
				{
					return (from responsable in bd.Responsables
							from procedimiento in responsable.Procedimiento
							from requisito_procedimiento in procedimiento.Requisito_procedimiento
								//from _solicitud in requisito_procedimiento.Solicitud
							where requisito_procedimiento.idReqProc == idReqProc
							select responsable).ToList();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
