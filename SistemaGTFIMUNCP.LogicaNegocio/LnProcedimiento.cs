using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;
using SistemaGTFIMUNCP.Repositorio;

namespace SistemaGTFIMUNCP.LogicaNegocio
{
	public class LnProcedimiento : iOperaciones<Procedimiento>
	{
		public List<Procedimiento> listarTodos()
		{
			return new AdProcedimiento().listarTodos();
		}

		public bool registrar(Procedimiento entidad)
		{
			return new AdProcedimiento().registrar(entidad);
		}

		public Procedimiento consultar(int id)
		{
			return new AdProcedimiento().consultar(id);
		}

		public bool actualizar(Procedimiento entidad)
		{
			return new AdProcedimiento().actualizar(entidad);
		}

		public bool eliminar(int id)
		{
			return new AdProcedimiento().eliminar(id);
		}
	}
}
