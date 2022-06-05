using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Inventario<T> where T : class
    {
        static int ultimoId;

        int idProducto;
        List<T> listaProductos;

        static Inventario()
        {
            ultimoId = 1;
        }
      
        public string Mostrar()
        {
            return listaProductos.ToString();
        }

        //public bool ReponerStock(int cantidad)
        //{
        //    if (cantidad > 0)
        //    {
        //        ComprarStock = cantidad;
        //        return true;
        //    }
        //    return false;
        //}
        //public int ComprarStock
        //{
        //    set => (Stock += value;
        //}

    }
}
