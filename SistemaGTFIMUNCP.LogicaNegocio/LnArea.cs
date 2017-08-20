using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;
using SistemaGTFIMUNCP.Repositorio;

namespace SistemaGTFIMUNCP.LogicaNegocio
{
	public class LnArea : iOperaciones<Area>
	{
		public List<Area> listarTodos()
		{
			return new AdArea().listarTodos();
		}

		public bool registrar(Area entidad)
		{
			return new AdArea().registrar(entidad);
		}

		public Area consultar(int id)
		{
			return new AdArea().consultar(id);
		}

		public bool actualizar(Area entidad)
		{
			return new AdArea().actualizar(entidad);
		}

		public bool eliminar(int id)
		{
			return new AdArea().eliminar(id);
		}
	}
}
