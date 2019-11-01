using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        string operador;
        double a = 0;
        bool validar = false;
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnNumerador_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txt_valor.Text = txt_valor.Text + bt.Text; 
        }

        private void Btn_limpar_Click(object sender, EventArgs e)
        {
            txt_valor.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
        }

        private void Btn_adicao_Click(object sender, EventArgs e)
        {
            if (txt_valor.Text == "")
            {
                MessageBox.Show("Digite um valor primeiro");
            }
            else
            if (validar == true)
            {
                a = a + Convert.ToDouble(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "+";
                txt_valor.Text = "";
                operador = "+";

            }
            else
            {
                label1.Text = txt_valor.Text + btn_adicao.Text;
                a = Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = "";
                operador = "+";
                validar = true;

            }
        }

        private void Btn_subtracao_Click(object sender, EventArgs e)
        {
            if (txt_valor.Text == "")
            {
                MessageBox.Show("Digite um valor primeiro");
            }
            else
            if (validar == true)
            {
                a = a - Convert.ToDouble(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "-";
                txt_valor.Text = "";
                operador = "-";

            }
            else
            {
                label1.Text = txt_valor.Text + btn_subtracao.Text;
                a = Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = "";
                operador = "-";
                validar = true;

            }

        }

        private void Btn_mutiplicacao_Click(object sender, EventArgs e)
        {
            if (txt_valor.Text == "")
            {
                MessageBox.Show("Digite um valor primeiro");
            }
            else
            if (validar == true)
            {
                a = a * Convert.ToDouble(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "*";
                txt_valor.Text = "";
                operador = "*";

            }
            else
            {
                label1.Text = txt_valor.Text + btn_mutiplicacao.Text;
                a = Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = "";
                operador = "*";
                validar = true;

            }
        }

        private void Btn_divisao_Click(object sender, EventArgs e)
        {
            if (txt_valor.Text == "")
            {
                MessageBox.Show("Digite um valor primeiro");
            }
            else
            if (validar == true)
            {
                a = a / Convert.ToDouble(txt_valor.Text);
                label1.Text = Convert.ToString(a) + "/";
                txt_valor.Text = "";
                operador = "/";

            }
            else
            {
                label1.Text = txt_valor.Text + btn_divisao.Text;
                a = Convert.ToDouble(txt_valor.Text);
                txt_valor.Text = "";
                operador = "/";
                validar = true;

            }
        }

        private void Btn_igual_Click(object sender, EventArgs e)
        {
            switch (operador)
            {
                case"+":
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a + Convert.ToDouble(txt_valor.Text));
                    break;
                case "-":
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a - Convert.ToDouble(txt_valor.Text));
                 break;

                case "*":
               
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a * Convert.ToDouble(txt_valor.Text));
                    break;

                case "/":
               
                label1.Text = label1.Text + txt_valor.Text + "=";
                txt_valor.Text = Convert.ToString(a / Convert.ToDouble(txt_valor.Text));
              
                    break;
            }
        }
        
    }
}
