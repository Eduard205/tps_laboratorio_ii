using System;

namespace Biblioteca
{
    public class Usuario
    {
        int idUsuario;
        string nombre;
        string password;

        public Usuario(int idUsuario, string nombre, string password)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.password = password;
        }

        public int Dni
        {
            get { return idUsuario; }
        }

        public string Nombre
        {
            get { return nombre; }
        }

        /// <summary>
        /// Comprueba el Password 
        /// </summary>
        /// <param name="datoIngresado"></param>
        /// <returns>Retorna true si el Password es correcto</returns>
        public bool ComprobarPassword(string datoIngresado)
        {
            return (!string.IsNullOrEmpty(datoIngresado) && datoIngresado.Trim() == password.Trim());
        }

    }
}
