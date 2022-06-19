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
    public partial class FrmInventario : Form
    {
        List<VideoJuego> listaJuegos;

        public FrmInventario()
        {
            InitializeComponent();
            
            listaJuegos = new List<VideoJuego>();
        }


        private void DataGridListaJuegos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
            listaJuegos = VideoJuegoAccesoDatos.Leer();
            ActualizarDatosInventario();
        }

        private void ActualizarDatosInventario()
        {
            DataGridListaJuegos.DataSource = null;
            DataGridListaJuegos.DataSource = listaJuegos;
        }

        private void LabNombreCliente_Click(object sender, EventArgs e)
        {

        }
    }
}
