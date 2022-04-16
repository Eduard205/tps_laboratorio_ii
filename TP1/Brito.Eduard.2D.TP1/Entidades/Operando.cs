using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        double numero;


        public Operando()
        {
            this.numero = 0;
        }


        public Operando(double numero): this()
        {
            this.numero = numero;
        }


        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }


        private string Numero
        {
            set
            {
                if (ValidarOperando(value) != 0)
                {
                    this.numero = ValidarOperando(value);
                }
            }
        }


        public string BinarioDecimal(string binario)
        {
            double digitoAuxiliar;
            double potencias = binario.Length - 1;
            double numeroEnDecimal = 0;
            string charAuxiliar;
            int numeroFinal;

            if (String.IsNullOrEmpty(binario) == false && EsBinario(binario))
            {
                foreach (char digito in binario)
                {
                    charAuxiliar = digito.ToString();
                    double.TryParse(charAuxiliar, out digitoAuxiliar);
                    numeroEnDecimal += (digitoAuxiliar * Math.Pow(2, potencias));
                    potencias--;
                }
                numeroFinal = (int)numeroEnDecimal;

                return numeroFinal.ToString();
            }

            return "Valor inválido";
        }


        public string DecimalBinario(double numero)
        {
            string valorBinario = string.Empty;
            int resultadoDivision = (int)Math.Abs(numero);

            if (resultadoDivision >= 0)
            {
                do
                {
                    valorBinario = resultadoDivision % 2 + valorBinario;
                    resultadoDivision /= 2;

                } while (resultadoDivision > 0);

                return valorBinario;
            }
            return "valor Invalido";
        }


        public string DecimalBinario(string numero)
        {
            double numeroDouble;
            double.TryParse(numero, out numeroDouble);

            return DecimalBinario(numeroDouble);
        }


        private bool EsBinario(string binario)
        {
            bool retorno = false;

            if (String.IsNullOrEmpty(binario) == false)
            {
                foreach (char digito in binario)
                {
                    if (digito != '1' && digito != '0')
                    {
                        return retorno;
                    }
                }
                retorno = true;
            }
            return retorno;
        }


        public static double operator - (Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }


        public static double operator * (Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }


        public static double operator / (Operando n1, Operando n2)
        {

            if (n2.numero == 0)
            {
                return double.MinValue;
            }
            else
            {
                return n1.numero / n2.numero;
            }
        }


        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }


        private double ValidarOperando(string strNumero)
        {
            double numero;

            if (!double.TryParse(strNumero, out numero))
            {
                numero = 0;
            }
            return numero;
        }


    }
}
