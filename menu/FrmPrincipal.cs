using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class FrmPrincipal : Form
    {

        private Form frmAtivo;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FormShow(Form frm)
        {
            ActiveFormClose();
            frmAtivo = frm;
            frm.TopLevel = false;
            pnlForm.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void ActiveFormClose()
        {
            if (frmAtivo != null)
                frmAtivo.Close();
        }

        private void ActiveButton(Button frmAtivo)
        {
            foreach (Control ctrl in pnlPrincipal.Controls)
                ctrl.ForeColor = Color.White;

            frmAtivo.ForeColor = Color.Red;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveButton(btnHome);
            ActiveFormClose();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            ActiveButton(btnProdutos);
            FormShow(new frmProdutos());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ActiveButton(btnClientes);
            FormShow(new FrmClientes());
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            ActiveButton(btnSair);
            ActiveFormClose();
            Application.Exit();
        }
    }
}
