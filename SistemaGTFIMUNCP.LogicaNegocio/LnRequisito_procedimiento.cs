using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;
using SistemaGTFIMUNCP.Repositorio;

namespace SistemaGTFIMUNCP.LogicaNegocio
{
	public class LnRequisito_procedimiento : iOperaciones<Requisito_procedimiento>
	{
		public List<Requisito_procedimiento> listarTodos()
		{
			return new AdRequisito_procedimiento().listarTodos();
		}

		public bool registrar(Requisito_procedimiento entidad)
		{
			return new AdRequisito_procedimiento().registrar(entidad);
		}

		public Requisito_procedimiento consultar(int id)
		{
			return new AdRequisito_procedimiento().consultar(id);
		}

		public bool actualizar(Requisito_procedimiento entidad)
		{
			return new AdRequisito_procedimiento().actualizar(entidad);
		}

		public bool eliminar(int id)
		{
			return new AdRequisito_procedimiento().eliminar(id);
		}
	}
}
