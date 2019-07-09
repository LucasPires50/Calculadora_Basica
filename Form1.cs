using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Basica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            resultado = num1 * num2;

            txtresultado.Text = resultado.ToString();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Declaração das variáveis
            double num1, num2, resultado;
            //num1 e num2 recebe o conteúdo do textbox (txtnum1.text e txtnum2.text)
            //Convert.Todouble é necessário para que seja convertido o conteúdo do textbox para número.
            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);
            //Variável resultado = recebe conteúdo de num1 + num2 e realiza o cálculo.
            resultado = num1 + num2;
            //txtresultado.Text = recebe conteúdo da variável resultado e converte para número.
            txtresultado.Text = resultado.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            resultado = num1 - num2;

            txtresultado.Text = resultado.ToString();
            
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void BntLimpar_Click(object sender, EventArgs e)
        {
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtresultado.Text = "";
        }

        private void BntSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BntDividir_Click(object sender, EventArgs e)
        {
            double num1, num2, resultado;

            num1 = Convert.ToDouble(txtnum1.Text);
            num2 = Convert.ToDouble(txtnum2.Text);

            resultado = num1 / num2;

            txtresultado.Text = resultado.ToString();
        }
    }
}
