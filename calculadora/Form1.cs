using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {

        public decimal Resultado { get; set; }

        public decimal Valor { get; set; }

        private Operacao OperacaoSelecionada { get; set; }

         private enum Operacao
        {
           Adicao,
           Subtracao,
           Multiplicacao,
           Divisao
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0"; 
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "+";
            
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "-";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "X";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(txtResultado.Text);
            txtResultado.Text = "";
            lblOperacao.Text = "/";
        }
private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtResultado.Text.Contains(","))
            txtResultado.Text += ",";
            
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(txtResultado.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(txtResultado.Text);
                    break;  
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(txtResultado.Text);
                    break;

            }
            txtResultado.Text = Convert.ToString(Resultado);
            lblOperacao.Text = "=";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }
    }
}
