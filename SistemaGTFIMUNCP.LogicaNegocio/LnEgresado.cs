using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;
using SistemaGTFIMUNCP.Repositorio;

namespace SistemaGTFIMUNCP.LogicaNegocio
{
	public class LnEgresado : iOperaciones<Egresado>
	{
		public List<Egresado> listarTodos()
		{
			return new AdEgresado().listarTodos();
		}

		public bool registrar(Egresado entidad)
		{
			return new AdEgresado().registrar(entidad);
		}

		public Egresado consultar(int id)
		{
			return new AdEgresado().consultar(id);
		}

		public bool actualizar(Egresado entidad)
		{
			return new AdEgresado().actualizar(entidad);
		}

		public bool eliminar(int id)
		{
			return new AdEgresado().eliminar(id);
		}
	}
}
