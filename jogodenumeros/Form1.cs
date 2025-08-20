using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogodenumeros
{
    public partial class frmJogoDeNumeros : Form
    {

        int randomNumber;
        int numeroTentativas = 10;
        int palpitedoJogador;
        bool jogoGanho = false;
        string dica;

        public frmJogoDeNumeros()
        {
            InitializeComponent();
        }

        private void frmJogoDeNumeros_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNumber = random.Next(1, 101); //número aleatorio entre 1 e 100
        }

        private void btnTentativas_Click(object sender, EventArgs e)
        {
            //Verifica se o jogo ja foi ganho
            if (jogoGanho)
            {
                txtResultado.Text = "voce ja acertou o numero! Reinicie o jogo para jogar de novo.";
                return;
            }
            //Verifica se o numero de tenativas chegou a 0
            if(numeroTentativas == 0)
            {
                txtResultado.Text = "Voce nao tem mais tentativas. O jogo acabou";
                return;
            }

            //Validação do valor do palpite (entre 1 a 100)
            if(!int.TryParse(txtNumeroInserido.Text, out palpitedoJogador) || palpitedoJogador < 1 || palpitedoJogador > 100 )
            {
                txtResultado.Text = "Por Favor, insira um numero entre 1 e 100";
                return;
            }

            numeroTentativas--;
            lblNumeroTentativas.Text = numeroTentativas.ToString();

            if (palpitedoJogador ==  randomNumber)
            {
                jogoGanho = true;
                dica = "parabens, voce acertou";
            }
            else if (palpitedoJogador < randomNumber)
            {
                dica = "O numero que voce digitou é menor, digite um maior";
            }
            else
            {
                dica = "O numero que voce digitou é maior, digite um menor";
            }

            txtResultado.Text = dica;
        }
    }
}
