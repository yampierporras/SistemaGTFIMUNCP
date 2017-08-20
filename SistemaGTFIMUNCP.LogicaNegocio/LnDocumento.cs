using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;
using SistemaGTFIMUNCP.Repositorio;

namespace SistemaGTFIMUNCP.LogicaNegocio
{
	public class LnDocumento : iOperaciones<Documento>
	{
		public List<Documento> listarTodos()
		{
			return new AdDocumento().listarTodos();
		}

		public bool registrar(Documento entidad)
		{
			return new AdDocumento().registrar(entidad);
		}

		public Documento consultar(int id)
		{
			return new AdDocumento().consultar(id);
		}

		public bool actualizar(Documento entidad)
		{
			return new AdDocumento().actualizar(entidad);
		}

		public bool eliminar(int id)
		{
			return new AdDocumento().eliminar(id);
		}
	}
}
