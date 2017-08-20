using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGTFIMUNCP.Entidades
{
	public interface iOperaciones<T>
	{
		// Listar todos
		List<T> listarTodos();
		/* CRUD => 
		 * Create(Registrar), 
		 * Read(Consultar), 
		 * Update(Actualizar) y 
		 * Delete(Eliminar) */

		// Registrar
		bool registrar(T entidad);
		// Consultar
		T consultar(int id);
		// Actualizar
		bool actualizar(T entidad);
		// Eliminar
		bool eliminar(int id);
	}
}
