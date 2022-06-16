using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class DatosNegocio
    {
        static List<Usuario> listaUsuarios;

        static DatosNegocio()
        {
            InstanciarUsuarios();
        }

        /// <summary>
        /// Instancia los usuarios Precargados
        /// </summary>
        private static void InstanciarUsuarios()
        {
            listaUsuarios = new List<Usuario>()
            {
                new Usuario(95123456,"Jesus Gonzalez","MundoPlay123"),
                new Usuario(35333999,"Florencia Perez","Caja123"),
            };
        }

        /// <summary>
        /// Loguea al usuario
        /// </summary>
        /// <param name="idUsuario"></param>
        /// <param name="password"></param>
        /// <returns>Retorna el usuario logueado</returns>
        public static Usuario LoguearUsuario(int idUsuario, string password)
        {
            foreach (Usuario item in listaUsuarios)
            {
                if (item.Dni == idUsuario && item.ComprobarPassword(password))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
