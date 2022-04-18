using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        private bool esNumBinario = false;

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
            lblResultado.TabStop = false;
            lstOperaciones.TabStop = false;

        }

        private void txtNumero1_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Solo puede ingresar numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtNumero2_TextChanged(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
                MessageBox.Show("Solo puede ingresar numeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string operador = cmbOperador.Text;
            string num1 = txtNumero1.Text;
            string num2 = txtNumero2.Text;
            double resultado;

            resultado = Operar(num1, num2, operador);

            if (operador == " ")
            {
                operador = "+";
            }
            if (txtNumero1.Text == " ")
            {
                num1 = "0";
            }
            if (txtNumero2.Text == " ")
            {
                num2 = "0";
            }

            lstOperaciones.Items.Add($"{num1} {operador} { num2} = {resultado}");

            lblResultado.Text = resultado.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
          
            if (esNumBinario == false)
            {
                Operando numBinario = new Operando();

                lblResultado.Text = numBinario.DecimalBinario(lblResultado.Text);
                esNumBinario = true;
            }

        } 

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (esNumBinario == true)
            {
                Operando numBinario = new Operando();

                lblResultado.Text = numBinario.BinarioDecimal(lblResultado.Text);
                esNumBinario = false;
            }
        }

        private void Limpiar()
        {
            txtNumero1.Clear();
            txtNumero2.Clear();
            lblResultado.Text = " ";
            cmbOperador.SelectedIndex = 0;

        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando Num1 = new Operando(numero1);
            Operando Num2 = new Operando(numero2);

            char.TryParse(operador, out char auxOperador);

            return Calculadora.Operar(Num1, Num2, auxOperador);

        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir",
                MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
