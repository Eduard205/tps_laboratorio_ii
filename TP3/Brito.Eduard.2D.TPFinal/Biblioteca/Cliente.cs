using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        int dni;
        string nombreCliente;
        string telefono;
        int edad;
        bool dadoDeBaja;

        public Cliente()
        {
        }
        public Cliente(int dni, string nombreCliente, string telefono, int edad, bool dadoDeBaja):this()
        {
            this.Dni = dni;
            this.NombreCliente = nombreCliente;
            this.Telefono = telefono;
            this.Edad = edad;
            this.dadoDeBaja = dadoDeBaja;   
        }

        public int Dni 
        {
           get { return dni; } 

           set 
            {
                if (value > 0)
                {
                    this.dni = value;
                }
            }
        }
        public string NombreCliente
        {
            get { return nombreCliente; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.nombreCliente = value;
                }
            }
        }
        public string Telefono
        {
            get { return telefono; }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    this.telefono = value;
                }
            }
        }
        public int Edad
        {
            get { return edad; }

            set
            {
                if (value >= 16)
                {
                    this.edad = value;
                }
            }
        }

        /// <summary>
        /// Busca clientes por dni
        /// </summary>
        /// <param name="lista"></param>
        /// <param name="dni"></param>
        /// <returns>Retorno el objeto de tipo Cliente que contine el dni ingresado</returns>
        public static Cliente BuscarCliente(List<Cliente> lista, int dni)
        {
            foreach (Cliente item in lista)
            {
                if (item == dni)
                {
                    return item;
                }
            }
            return null;
        }

        /// <summary>
        /// Sobrecarga del operador == para comparar clientes por dni
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="dni"></param>
        /// <returns>Retorna true si los id de los clientes son iguales</returns>
        public static bool operator ==(Cliente c1, int dni)
        {
            return c1.dni == dni;
        }

        /// <summary>
        /// Sobrecarga del operador !== para comparar clientes por dni
        /// </summary>
        /// <param name="c1"></param>
        /// <param name="dni"></param>
        /// <returns>Retorna false si los id de los clientes son iguales</returns>
        public static bool operator !=(Cliente c1, int dni)
        {
            return !(c1 == dni);
        }

    }
}
