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
    public partial class FrmMenuPrincipal : Form
    {
        List<Cliente> listaClientes;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
            listaClientes = new List<Cliente>();
            
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            listaClientes = ClaseSerializadora<Cliente>.Leer();

            if (listaClientes is not null)
            {
                ActualizarDatos();
            }
            else
            {
                MessageBox.Show("Error en el archivo, no se cargo la lista de clientes");
            }
        }

        private void ActualizarDatos()
        {
            DataGridListaClientes.DataSource = null;
            DataGridListaClientes.DataSource = listaClientes;
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            FrmMenuCliente frmAbmCliente = new FrmMenuCliente(listaClientes);
            DialogResult result = frmAbmCliente.ShowDialog();

            if (result == DialogResult.OK)
            {
                listaClientes.Add(frmAbmCliente.RetornarCliente);

                ActualizarDatos();
            }
            else
            {
                MessageBox.Show("No se actualizo la lista de clientes");
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnGuardarArchivoClientes_Click(object sender, EventArgs e)
        {
            ClaseSerializadora<Cliente>.Escribir(listaClientes);
            MessageBox.Show("Se guardó la lista de clientes");
        }
    }
}
