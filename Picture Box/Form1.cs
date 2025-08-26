using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_Box
{
    public partial class frmPictureBox : Form
    {
        private string imagemlocalizada;
        public frmPictureBox()
        {
            InitializeComponent();
        }

        private void btnVerImagem_Click(object sender, EventArgs e)
        {
            pbCidade.Image = Image.FromFile(@"C:\Users\victor.soliveira21\Downloads\Sampa.PNG");
            pbCidade.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            try
            {


                //Caixa de dialogo para abrir arquivo
                OpenFileDialog abrirarquivo = new OpenFileDialog();
                abrirarquivo.Filter = "jpg files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
                if (abrirarquivo.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imagemlocalizada = abrirarquivo.FileName;

                    pbAnexarImagem.ImageLocation = imagemlocalizada;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
