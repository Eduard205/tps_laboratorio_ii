using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum ENombreVideoConsola
    {
        PS4,
        PS5,
        NintendoSwitch,
        Xbox
    }

    public class VideoConsola: IReponerStock, IVenderStock
    {
        ENombreVideoConsola nombreVideoConsola;
        int stock;
        float precio;

        public VideoConsola(ENombreVideoConsola nombreVideoConsola, int stock, float precio)
        {
            this.NombreVideoConsola = nombreVideoConsola;
            this.Stock = stock;
            this.Precio = precio;
        }

        public ENombreVideoConsola NombreVideoConsola 
        { 
            get { return nombreVideoConsola; }
            set { nombreVideoConsola = value; } 
        }
        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }
        public float Precio
        {
            get { return precio; }
            set 
            {
                if (value > 0)
                {
                    precio = value;
                }
            }
        }

        public bool ReponerStock(int cantidad)
        {
            if (cantidad > 0 && Stock < 10)
            {
                IncrementarStock = cantidad;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool VenderStock(int cantidad)
        {
            if (cantidad > 0 && Stock >= cantidad)
            {
                DisminuirStock = cantidad;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int IncrementarStock
        {
            set
            {
                Stock += value;
            }
        }

        public int DisminuirStock
        {
            set
            {
                Stock -= value;
            }
        }
    }

    
}
