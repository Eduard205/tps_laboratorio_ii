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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUsuario.Text) || string.IsNullOrEmpty(TxtContrasenia.Text))
            {
                MessageBox.Show("Debe ingresar un usuario y contraseña");
            }
            else
            {
                if (int.TryParse(TxtUsuario.Text, out int id))
                {
                    Usuario usuarioLogueado = DatosNegocio.LoguearUsuario(id, TxtContrasenia.Text);

                    if (usuarioLogueado is not null)
                    {
                        FrmMenuPrincipal menuPrincipal = new FrmMenuPrincipal();
                        menuPrincipal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("El usuario o contraseña es incorrecto");
                    }
                }
                else
                {
                    MessageBox.Show("Ingreso datos invalidos");
                }
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLoguearEmpleado_Click_1(object sender, EventArgs e)
        {
            this.TxtUsuario.Text = "95123456";
            this.TxtContrasenia.Text = "MundoPlay123";
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

