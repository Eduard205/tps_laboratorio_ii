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

            listaClientes = new List<Cliente>()
            {
                new Cliente()
                {
                    Dni = 34456789,
                    NombreCliente= "Juan",
                    Telefono= "1145687852",
                    Edad = 16
                },
                 new Cliente()
                {
                    Dni = 28455781,
                    NombreCliente= "Cecilia",
                    Telefono= "1125787951",
                    Edad = 25
                },
                  new Cliente()
                {
                    Dni = 30452754,
                    NombreCliente= "Leandro",
                    Telefono= "1165327889",
                    Edad = 20
                },
            };
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {
            ActualizarDatos();
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
    }
}
