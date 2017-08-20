using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;
using SistemaGTFIMUNCP.Repositorio;

namespace SistemaGTFIMUNCP.LogicaNegocio
{
	public class LnResponsable : iOperaciones<Responsable>
	{
		public List<Responsable> listarTodos()
		{
			return new AdResponsable().listarTodos();
		}

		public bool registrar(Responsable entidad)
		{
			return new AdResponsable().registrar(entidad);
		}

		public Responsable consultar(int id)
		{
			return new AdResponsable().consultar(id);
		}

		public bool actualizar(Responsable entidad)
		{
			return new AdResponsable().actualizar(entidad);
		}

		public bool eliminar(int id)
		{
			return new AdResponsable().eliminar(id);
		}
		//METODOS PERSONALES
		public List<Responsable> listarResponsablePorProcedimiento(int idReqProc)
		{
			return new AdResponsable().listarResponsablePorProcedimiento(idReqProc);
		}
	}
}
