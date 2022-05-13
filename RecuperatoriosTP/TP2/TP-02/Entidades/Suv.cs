using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Suv : Vehiculo
    {
     

        public Suv(EMarca marca, string chasis, ConsoleColor color)
            : base(marca, chasis, color)
        {
        }

        /// <summary>
        /// SUV son 'Grande'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Grande;;
            }
        }

        /// <summary>
        /// Retorna todos los datos del vehiculo tipo SUV
        /// </summary>
        /// <returns>Retorna un string con los datos del vehiculo</returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SUV");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
