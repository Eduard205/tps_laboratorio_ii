using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VideoJuego: IReponerStock, IVenderStock
    {
        string nombreVideoJuego;
        ENombreVideoConsola nombreVideoConsola;
        float precio;
        int stock;

        public VideoJuego(string nombreVideoJuego, ENombreVideoConsola nombreVideoConsola, float precio, int stock)
        {
            this.NombreVideoJuego = nombreVideoJuego;
            this.NombreVideoConsola = nombreVideoConsola;
            this.Precio = precio;
            this.Stock = stock;
        }
        public string NombreVideoJuego
        {
            get { return nombreVideoJuego; }
            set 
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    nombreVideoJuego = value;
                }
            }
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
            if (cantidad > 0 && Stock < 50)
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
            if (cantidad > 0 && Stock > cantidad)
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

