﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alertas
{
    public partial class Alertas : Form
    {
        public Alertas()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAlertaSimples_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Essa é uma mensagem simple", "Com um titulo");
        }

        private void btnAlertaRobusto_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Vamos programar um sistema",           
                                                        "Titulo aqui",                 
                                                         MessageBoxButtons.YesNo,   
                                                         MessageBoxIcon.Question);

            if(resposta == DialogResult.Yes)
            {
                MessageBox.Show("Respondeu que sim");
            } else if (resposta == DialogResult.No)
            {
                MessageBox.Show("Respondeu que não");
            }
        }   
    }
}
