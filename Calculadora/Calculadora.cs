using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        
        private bool operaciones = true;
        private bool punto = true;
        private bool negativo = true;
        private Operacion operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void reiniciar()
        {
            foreach (Control c in tableLayoutPanel2.Controls)
            {
                c.Enabled = true;
            }
            txtOperacion.Text = "";
            punto = true;
            operaciones = true;
        }

        private void deshabilitarOperaciones()
        {

            butAdicion.Enabled = false;
            butSubstraccion.Enabled = false;
            ButMultiplicacion.Enabled = false;
            butDivison.Enabled = false;
            butPotenciacion.Enabled = false;
            operaciones = false;
            negativo = true;
            punto = true;
        }

        private void but0_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "0";
        }

        private void but1_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "1";
        }

        private void but2_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "2";
        }

        private void but3_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "3";
        }

        private void but4_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "4";
        }

        private void but5_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "5";
        }

        private void but6_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "6";
        }

        private void but7_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "7";
        }

        private void but8_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "8";
        }

        private void but9_Click(object sender, EventArgs e)
        {
            txtOperacion.Text += "9";
        }

        private void butPunto_Click(object sender, EventArgs e)
        {
            if (punto)
            {
                if (txtOperacion.Text.Length == 0 || (txtOperacion.Text[txtOperacion.Text.Length - 1] < '0' || txtOperacion.Text[txtOperacion.Text.Length - 1] > '9'))
                {
                    txtOperacion.Text += "0";
                }
                txtOperacion.Text += CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
                punto = false;
                butPunto.Enabled = false;
            }
        }

        private void butPotenciacion_Click(object sender, EventArgs e)
        {
            if (operaciones)
            {
                txtOperacion.Text += "^";
                deshabilitarOperaciones();
                operacion = new Potenciacion();
            }
            
        }

        private void butDivison_Click(object sender, EventArgs e)
        {
            if (operaciones)
            {
                txtOperacion.Text += "/";
                deshabilitarOperaciones();
                operacion = new Division();
            }
        }

        private void ButMultiplicacion_Click(object sender, EventArgs e)
        {
            if (operaciones)
            {
                txtOperacion.Text += "*";
                deshabilitarOperaciones();
                operacion = new Multiplicacion();
            }
        }

        private void butSubstraccion_Click(object sender, EventArgs e)
        {
            if (negativo && (txtOperacion.Text.Length == 0 || (txtOperacion.Text[txtOperacion.Text.Length - 1] != '0' || txtOperacion.Text[txtOperacion.Text.Length - 1] > '9')))
            {
                txtOperacion.Text += "-";
                negativo = false;
            }
            else
            if (operaciones)
            {
                txtOperacion.Text += "-";
                deshabilitarOperaciones();
                operacion = new Resta();
            }
        }

        private void butAdicion_Click(object sender, EventArgs e)
        {
            if (operaciones)
            {
                txtOperacion.Text += "+";
                deshabilitarOperaciones();
                operacion = new Suma();
            }
        }

        private void deshabilitarTodo()
        {
            foreach (Control c in tableLayoutPanel2.Controls)
            {
                c.Enabled = false;
            }
        }

        private void butIgual_Click(object sender, EventArgs e)
        {            
            Match coincidencia;
            string numero = @"-?[\d]+(\,[\d]+)?";
            coincidencia = Regex.Match(txtOperacion.Text, numero);
            decimal[] numeros = new decimal[2];
            int indice = 0;
            while (coincidencia.Success)
            {
                numeros[indice++] = Decimal.Parse(coincidencia.Value);
                coincidencia = coincidencia.NextMatch();
            }
            if (indice == 2)
            {
                try
                {
                    decimal resultado = operacion.Operar(numeros[0], numeros[1]);
                    txtOperacion.Text = resultado.ToString();
                } catch (Exception ex)
                {
                    txtOperacion.Text = ex.Message;
                }
                deshabilitarTodo();
                butReset.Enabled = true;
            }
            

        }

        private void butReset_Click(object sender, EventArgs e)
        {
            reiniciar();
        }

        private void txtOperacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;            
            switch (e.KeyChar)
            {
                case '0':
                    but0_Click(null, null);
                    break;
                case '1':
                    but1_Click(null, null);
                    break;
                case '2':
                    but2_Click(null, null);
                    break;
                case '3':
                    but3_Click(null, null);
                    break;
                case '4':
                    but4_Click(null, null);
                    break;
                case '5':
                    but5_Click(null, null);
                    break;
                case '6':
                    but6_Click(null, null);
                    break;
                case '7':
                    but7_Click(null, null);
                    break;
                case '8':
                    but8_Click(null, null);
                    break;
                case '9':
                    but9_Click(null, null);
                    break;
                case '-':
                    butSubstraccion_Click(null, null);
                    break;
                case '+':
                    butAdicion_Click(null, null);
                    break;
                case '/':
                    butDivison_Click(null, null);
                    break;
                case '*':
                    ButMultiplicacion_Click(null, null);
                    break;
                case '=':
                    butIgual_Click(null, null);
                    break;
                case '^':
                    butPotenciacion_Click(null, null);
                    break;
                case ',':
                case '.':
                    butPunto_Click(null, null);
                    break;
                case (char)13:
                    butIgual_Click(null, null);
                    break;
                case (char)8:
                    if (txtOperacion.Text.Length > 0)
                    {
                        txtOperacion.Text = txtOperacion.Text.Remove(txtOperacion.Text.Length - 1);
                    }
                    break;
                case (char)27:
                    butReset_Click(null, null);
                    break;

            }
            Debug.WriteLine("Tecla presionada: " + e.KeyChar + " = " + (int)e.KeyChar);
            txtOperacion.SelectionStart = txtOperacion.Text.Length;
            txtOperacion.SelectionLength = 0;
        }
    }
}
