using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Formularios
{
    public delegate void DelegadoMostrar();
    public partial class FrmMenuCliente : Form
    {
        int dni;
        string nombreCliente;
        string telefono;
        int edad;
        Cliente cliente;
        List<Cliente> listaClientes;

        public FrmMenuCliente()
        {
            InitializeComponent();
        }

        public FrmMenuCliente(List<Cliente> listaClientes) : this()
        {
            this.listaClientes = listaClientes;
        }

        public Cliente RetornarCliente
        {
            get { return cliente; }
        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            int auxInt;
            string patron = "[!\"·$%&/()=¿¡?'_:;,|@#€*+-.123456789]";

            try
            {
                if ((!string.IsNullOrEmpty(TxtNombreCliente.Text.Trim()) &&
                    (!string.IsNullOrEmpty(TxtTelefono.Text.Trim()))) &&
                    (!string.IsNullOrEmpty(TxtEdad.Text.Trim())) &&
                    (!string.IsNullOrEmpty(TxtDni.Text.Trim())))
                {
                    if (int.TryParse(TxtDni.Text, out dni) && int.TryParse(TxtEdad.Text, out edad) &&
                        int.TryParse(TxtTelefono.Text, out auxInt) &&
                        (!Regex.IsMatch(TxtNombreCliente.Text, @"^[0-9]+$")) &&
                        (!Regex.IsMatch(TxtNombreCliente.Text, patron)) &&
                        (dni > 0 && edad >= 16) && (int.Parse(TxtTelefono.Text) > 0))
                    {
                        dni = int.Parse(TxtDni.Text);
                        nombreCliente = TxtNombreCliente.Text;
                        telefono = TxtTelefono.Text;
                        edad = int.Parse(TxtEdad.Text);

                        DataGridAgregarCliente.Rows.Add(dni, nombreCliente, telefono, edad);
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
            catch (Exception ex)
            {
                throw new Exception("Fallo al agregar al cliente", ex);
            }
        }

        private void BtnLimpiarCampos_Click(object sender, EventArgs e)
        {
            TxtDni.Clear();
            TxtNombreCliente.Clear();
            TxtTelefono.Clear();
            TxtEdad.Clear();
            DataGridAgregarCliente.Rows.Clear();

            dni = 0;
            nombreCliente = null;
            telefono = null;
            edad = 0;
        }

        private void BtnVolverMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BtnAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaClientes is not null && nombreCliente is not null && telefono is not null)
                {
                    listaClientes.Add(new Cliente(dni, nombreCliente, telefono, edad, false));
                    ActualizarMensaje(nombreCliente, () => MessageBox.Show($"Alta efectuada correctamente"));
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    throw new ErrorCargaDeDatosException("No ha cargado los datos del cliente");
                }
            }
            catch (ErrorCargaDeDatosException ex)
            {
                MessageBox.Show($"Fallo el alta del cliente\n {ex}");
            }
        }

        private void BtnBajaCliente_Click(object sender, EventArgs e)
        {
            this.TxtDniBajaCliente.Visible = true;
            this.BtnConfirmarBaja.Visible = true;
        }

        private void BtnConfirmarBaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtDniBajaCliente.Text.Trim()))
                {
                    if (int.TryParse(TxtDniBajaCliente.Text, out dni) && int.Parse(TxtDniBajaCliente.Text) > 0)
                    {
                        Cliente clienteAux = new Cliente();
                        clienteAux = Cliente.BuscarCliente(listaClientes, int.Parse(TxtDniBajaCliente.Text));

                        if (clienteAux != null && listaClientes.Remove(clienteAux) == true)
                        {
                            MessageBox.Show($"Se dio de baja al cliente con el DNI: {TxtDniBajaCliente.Text}");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("No existe el DNI ingresado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingreso datos invalidos");
                    }
                }
                else
                {
                    MessageBox.Show("Debe ingresar el DNI a dar de baja");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Fallo la baja del cliente", ex);
            }
        }

        public void ActualizarMensaje(string nombre, DelegadoMostrar delegadoMostrar)
        {
            delegadoMostrar();
            MessageBox.Show($"Se dio de alta al cliente: {nombre}");
        } 

    }
}
