using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ErrorCargaDeDatosException : Exception
    {
        public ErrorCargaDeDatosException():base("Error en la carga de datos")
        {
        }

        public ErrorCargaDeDatosException(string message) : base(message)
        {
        }

        public ErrorCargaDeDatosException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
