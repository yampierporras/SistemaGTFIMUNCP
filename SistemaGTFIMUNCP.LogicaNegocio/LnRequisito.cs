using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;
using SistemaGTFIMUNCP.Repositorio;

namespace SistemaGTFIMUNCP.LogicaNegocio
{
	public class LnRequisito : iOperaciones<Requisito>
	{
		public List<Requisito> listarTodos()
		{
			return new AdRequisito().listarTodos();
		}

		public bool registrar(Requisito entidad)
		{
			return new AdRequisito().registrar(entidad);
		}

		public Requisito consultar(int id)
		{
			return new AdRequisito().consultar(id);
		}

		public bool actualizar(Requisito entidad)
		{
			return new AdRequisito().actualizar(entidad);
		}

		public bool eliminar(int id)
		{
			return new AdRequisito().eliminar(id);
		}
	}
}
