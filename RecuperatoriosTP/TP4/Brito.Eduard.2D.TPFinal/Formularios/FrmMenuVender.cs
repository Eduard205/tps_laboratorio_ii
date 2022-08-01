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
    public partial class FrmMenuVender : Form
    {
        List<Cliente> listaClientes;
        List<VideoJuego> listaJuegos;
        int cantidad;
        string nombreCliente;
        string nombreDelJuego;
        float precio;
        float TotalACobrar;
        float totalAFacturar=0;

        public FrmMenuVender()
        {
            InitializeComponent();     
        }

        public FrmMenuVender(List<Cliente> listaClientes) : this()
        {
            this.listaClientes = listaClientes;
        }

        private void FrmMenuVender_Load(object sender, EventArgs e)
        {
            try
            {
                listaJuegos = new List<VideoJuego>();
                listaJuegos = VideoJuegoAccesoDatos.Leer();
                List<string> listaClientesAux;
                listaClientesAux = new List<string>();
                List<string> listaVideoJuegosAux;
                listaVideoJuegosAux = new List<string>();

                if (listaClientes != null && listaJuegos != null)
                {
                    foreach (var cliente in listaClientes)
                    {

                        listaClientesAux.Add(cliente?.NombreCliente);

                    }

                    foreach (var videoJuego in listaJuegos)
                    {
                        if (videoJuego.NombreVideoJuego != null)
                        {
                            listaVideoJuegosAux.Add(videoJuego.NombreVideoJuego);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Fallo al cargar la lista de clientes o de videoJuegos");
                }

                comboBoxCliente.DataSource = listaClientesAux;
                comboBoxVideoJuego.DataSource = listaVideoJuegosAux;
                comboBoxCliente.SelectedIndex = -1;
                comboBoxVideoJuego.SelectedIndex = -1;
            }
            catch(Exception)
            {
                throw new Exception("Fallo al cargar la lista de clientes o de videoJuegos");
            }
        }
   
        private void BtnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnCargarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                if ((!string.IsNullOrEmpty(comboBoxCantidad.Text.Trim())) && 
                    (!string.IsNullOrEmpty(comboBoxCliente.Text.Trim())) &&
                    (!string.IsNullOrEmpty(comboBoxVideoJuego.Text.Trim())))
                {
                    if (int.TryParse(comboBoxCantidad.Text, out cantidad) && (cantidad > 0))
                    {
                        foreach (var videoJuego in listaJuegos)
                        {
                            if (videoJuego.NombreVideoJuego == comboBoxVideoJuego.Text) 
                            {
                                if (videoJuego.Stock >= cantidad)
                                {
                                    cantidad = int.Parse(comboBoxCantidad.Text);
                                    nombreCliente = comboBoxCliente.Text;
                                    nombreDelJuego = comboBoxVideoJuego.Text;
                                    precio = videoJuego.Precio;
                                    TotalACobrar = precio * cantidad;

                                    DataGridCargarVenta.Rows.Add(nombreCliente, nombreDelJuego, cantidad, precio, TotalACobrar);

                                    totalAFacturar += TotalACobrar;
                                    txtTotalAFacturar.Text = totalAFacturar.ToString();
                                }
                                else
                                {
                                    MessageBox.Show($"No hay Stock suficiente del videojuego: {videoJuego.NombreVideoJuego}" +
                                        $"\nStock disponible: {videoJuego.Stock}");
                                    break;
                                } 
                            }  
                        }     
                    }
                    else
                    {
                        MessageBox.Show("Ingreso datos invalidos");
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar TODOS los campos");
                }
            }
            catch (Exception)
            {
                throw new Exception("Fallo al cargar venta");
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            cantidad = 0;
            nombreCliente = null;
            nombreDelJuego = null;
            totalAFacturar = 0;
            txtTotalAFacturar.Text = null;
            DataGridCargarVenta.Rows.Clear();
            comboBoxCliente.SelectedIndex = -1;
            comboBoxVideoJuego.SelectedIndex = -1;
            comboBoxCantidad.Text = null;
        }

        private void btnFacturarVenta_Click_1(object sender, EventArgs e)
        {
            foreach (var videoJuego in listaJuegos)
            {
                if (nombreDelJuego != null)
                {
                    if (videoJuego.NombreVideoJuego == nombreDelJuego)
                    {
                        if (videoJuego.VenderStock(cantidad))
                        {
                            MessageBox.Show("Se ha facturado la venta");
                        }
                        else
                        {
                            MessageBox.Show("No hay Stock del VideoJuego seleccionado");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error, no ha cargado una venta");
                    break;
                }
            }
        }
    }
}
