using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;
using SistemaGTFIMUNCP.Repositorio;

namespace SistemaGTFIMUNCP.LogicaNegocio
{
	public class LnSolicitud : iOperaciones<Solicitud>
	{
		public List<Solicitud> listarTodos()
		{
			return new AdSolicitud().listarTodos();
		}

		public bool registrar(Solicitud entidad)
		{
			return new AdSolicitud().registrar(entidad);
		}

		public Solicitud consultar(int id)
		{
			return new AdSolicitud().consultar(id);
		}

		public bool actualizar(Solicitud entidad)
		{
			return new AdSolicitud().actualizar(entidad);
		}

		public bool eliminar(int id)
		{
			return new AdSolicitud().eliminar(id);
		}
	}
}
