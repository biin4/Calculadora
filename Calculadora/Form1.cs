using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form

        
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal valor1 = 0, valor2 = 0;
        string operacao;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            
            if(operacao == "SOMA")
            {
                txtresultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if(operacao == "SUB")
            {
                txtresultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if(operacao == "MULT")
            {
                txtresultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if(operacao == "DIVI")
            {
                txtresultado.Text = Convert.ToString(valor1 / valor2);
            }
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            //txtresultado.Text = txtresultado.Text + "0";
            txtresultado.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            txtresultado.Text = "";
            operacao = "MULT";
            LABEL_OP.Text = "X";
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "1";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "8";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtresultado.Text += "9";
        }

        private void btsubtracao_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            txtresultado.Text = "";
            operacao = "SUB";
            LABEL_OP.Text = "-";
        }

        private void btdivisao_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            txtresultado.Text = "";
            operacao = "DIVI";
            LABEL_OP.Text = "/";
        }

        private void btponto_Click(object sender, EventArgs e)
        {
            txtresultado.Text += ".";
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
            operacao = "";
            LABEL_OP.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void btC_Click(object sender, EventArgs e)
        {
            txtresultado.Text = "";
        }

        private void btadicao_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtresultado.Text, CultureInfo.InvariantCulture);
            txtresultado.Text = "";
            operacao = "SOMA";
            LABEL_OP.Text = "+";

        }
    }
}
