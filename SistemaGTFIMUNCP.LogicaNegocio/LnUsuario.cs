using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaGTFIMUNCP.Entidades;
using SistemaGTFIMUNCP.Repositorio;

namespace SistemaGTFIMUNCP.LogicaNegocio
{
	public class LnUsuario : iOperaciones<Usuario>
	{
		public List<Usuario> listarTodos()
		{
			return new AdUsuario().listarTodos();
		}

		public bool registrar(Usuario entidad)
		{
			return new AdUsuario().registrar(entidad);
		}

		public Usuario consultar(int id)
		{
			return new AdUsuario().consultar(id);
		}

		public bool actualizar(Usuario entidad)
		{
			return new AdUsuario().actualizar(entidad);
		}

		public bool eliminar(int id)
		{
			return new AdUsuario().eliminar(id);
		}
		//Metodos personales
		public Usuario consultar(string usuario)
		{
			return new AdUsuario().consultar(usuario);
		}
	}
}
