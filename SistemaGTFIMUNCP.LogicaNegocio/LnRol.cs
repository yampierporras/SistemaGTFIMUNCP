using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;
using SistemaGTFIMUNCP.Repositorio;

namespace SistemaGTFIMUNCP.LogicaNegocio
{
	public class LnRol : iOperaciones<Rol>
	{
		public List<Rol> listarTodos()
		{
			return new AdRol().listarTodos();
		}

		public bool registrar(Rol entidad)
		{
			return new AdRol().registrar(entidad);
		}

		public Rol consultar(int id)
		{
			return new AdRol().consultar(id);
		}

		public bool actualizar(Rol entidad)
		{
			return new AdRol().actualizar(entidad);
		}

		public bool eliminar(int id)
		{
			return new AdRol().eliminar(id);
		}
	}
}
