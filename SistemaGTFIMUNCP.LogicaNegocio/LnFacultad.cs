using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;
using SistemaGTFIMUNCP.Repositorio;

namespace SistemaGTFIMUNCP.LogicaNegocio
{
	public class LnFacultad : iOperaciones<Facultad>
	{
		public List<Facultad> listarTodos()
		{
			return new AdFacultad().listarTodos();
		}

		public bool registrar(Facultad entidad)
		{
			return new AdFacultad().registrar(entidad);
		}

		public Facultad consultar(int id)
		{
			return new AdFacultad().consultar(id);
		}

		public bool actualizar(Facultad entidad)
		{
			return new AdFacultad().actualizar(entidad);
		}

		public bool eliminar(int id)
		{
			return new AdFacultad().eliminar(id);
		}
	}
}
