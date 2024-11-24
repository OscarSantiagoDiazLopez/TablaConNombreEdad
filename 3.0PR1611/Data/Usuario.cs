using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using _3PR1611.Modelo;

namespace _3._0PR1611.Data
{
    public class Usuario
    {
        List<UsuarioModel> lista = new List<UsuarioModel>();

        // Método para guardar un usuario
        public void Guardar(UsuarioModel modelo)
        {
            lista.Add(modelo); // Agregar el modelo a la lista
        }

        // Método para consultar todos los usuarios
        public List<UsuarioModel> Consultar()
        {
            return lista;
        }
    }
}
