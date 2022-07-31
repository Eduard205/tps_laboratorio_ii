using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class ExtIntDni
    {
        public static bool ValidarDni(this int dni)
        {
            return dni > 10000000 && dni < 99999999;
        }

    }
}
