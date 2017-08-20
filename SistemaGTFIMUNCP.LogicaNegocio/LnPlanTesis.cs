using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;
using SistemaGTFIMUNCP.Repositorio;

namespace SistemaGTFIMUNCP.LogicaNegocio
{
	public class LnPlanTesis : iOperaciones<PlanTesis>
	{
		public List<PlanTesis> listarTodos()
		{
			return new AdPlanTesis().listarTodos();
		}

		public bool registrar(PlanTesis entidad)
		{
			return new AdPlanTesis().registrar(entidad);
		}

		public PlanTesis consultar(int id)
		{
			return new AdPlanTesis().consultar(id);
		}

		public bool actualizar(PlanTesis entidad)
		{
			return new AdPlanTesis().actualizar(entidad);
		}

		public bool eliminar(int id)
		{
			return new AdPlanTesis().eliminar(id);
		}
	}
}
