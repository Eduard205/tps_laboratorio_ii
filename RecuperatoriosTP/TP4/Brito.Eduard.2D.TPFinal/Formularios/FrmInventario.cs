using Biblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios
{
    public delegate void DelegadoSinParametros();
    public partial class FrmInventario : Form
    { 
        List<VideoJuego> listaJuegos;

        public FrmInventario() 
        {
            InitializeComponent();
            listaJuegos = new List<VideoJuego>();
        }

        public void ActualizarDatosInventario()
        {
            DataGridListaJuegos.DataSource = null;
            DataGridListaJuegos.DataSource = listaJuegos;
        }

        private void BtnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnImportarBdVideoJuegos_Click(object sender, EventArgs e)
        {
            listaJuegos = VideoJuegoAccesoDatos.Leer();

            DelegadoSinParametros delegadoActualizarYContarStock = ActualizarDatosInventario;
            delegadoActualizarYContarStock += ContarStock;

            if (delegadoActualizarYContarStock != null)
            {
                delegadoActualizarYContarStock();
            }
            else
            {
                throw new Exception("La referencia del delegado es null");
            }
        }
        public void ContarStock()
        {
            int contadorStock=0;
            VideoJuego videoJuegoAux = new VideoJuego();

            if (listaJuegos != null)
            {
                foreach (var item in listaJuegos)
                {
                    contadorStock += item.Stock;
                }
            }
            else
            {
                throw new Exception("La lista es null");
            }
            MessageBox.Show($"El Stock total de VideoJuegos es: {contadorStock}");

            if(contadorStock < 100)
            {
                if (videoJuegoAux.ValidarQueElEventoNoEsteAsignado()) 
                {
                    videoJuegoAux.InformarStockMinimo += ReponerStock;
                }  
            }

            videoJuegoAux.ActualizarStock();
        }

        public void ReponerStock()
        {
            listaJuegos.Add (new VideoJuego("Pokemon Sword", ENombreVideoConsola.NintendoSwitch,12000,10));
            listaJuegos.Add (new VideoJuego("Pokemon Arceus", ENombreVideoConsola.NintendoSwitch, 14000, 10));
            listaJuegos.Add (new VideoJuego("Dragonball Fighter Z", ENombreVideoConsola.PS4, 9000, 10));
            listaJuegos.Add (new VideoJuego("FIFA 22", ENombreVideoConsola.PS5, 16000, 10));
            listaJuegos.Add (new VideoJuego("Minecraft", ENombreVideoConsola.PS4, 8000, 10));

            MessageBox.Show("Se repuso inventario de mayor rotación");
        }
    }
}
