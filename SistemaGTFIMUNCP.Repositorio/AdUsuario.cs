using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;

namespace SistemaGTFIMUNCP.Repositorio
{
	public class AdUsuario : iOperaciones<Usuario>
	{
		public List<Usuario> listarTodos()
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Usuarios.ToList();
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool registrar(Usuario entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					ctx.Usuarios.Add(entidad);
					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}

		public Usuario consultar(int id)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					return ctx.Usuarios.SingleOrDefault(x => x.idUsuario == id);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}

		public bool actualizar(Usuario entidad)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities ctx = new SistemaGTFIMUNCPEntities())
				{
					Usuario usuario = ctx.Usuarios.SingleOrDefault(x => x.idUsuario == entidad.idUsuario);
					usuario.usuario1 = entidad.usuario1;
					usuario.contraseña = entidad.contraseña;
					usuario.nomUsuario = entidad.nomUsuario;
					usuario.apePatUsuario = entidad.apePatUsuario;
					usuario.apeMatUsuario = entidad.apeMatUsuario;
					usuario.dniUsuario = entidad.dniUsuario;
					usuario.celUsuario = entidad.celUsuario;
					usuario.estadoUsuario = entidad.estadoUsuario;
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
					ctx.Usuarios.Remove(ctx.Usuarios.SingleOrDefault(x => x.idUsuario == id));
					ctx.SaveChanges();
					return true;
				}
			}
			catch (Exception)
			{
				return false;
			}
		}
		//Metodos personales
		public Usuario consultar(string usuario)
		{
			try
			{
				using (SistemaGTFIMUNCPEntities bd = new SistemaGTFIMUNCPEntities())
				{
					return bd.Usuarios.SingleOrDefault(x => x.usuario1 == usuario);
				}
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
