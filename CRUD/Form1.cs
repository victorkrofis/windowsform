using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class frmCadastroDeCliente : Form
    {
        //conexão com o banco de dados MySql
        MySqlConnection Conexao;
        string data_source = "datasource = localhost; username=root; password=; database=db_cadastro";


        public frmCadastroDeCliente()
        {
            InitializeComponent();
        }

        private void frmCadastroDeCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtNomeCompleto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validação de campos obrigatorios
                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                     string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                     string.IsNullOrEmpty(txtCPF.Text.Trim()))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.",
                                    "Validação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; //Impede o prosseguimento se algum campo estiver vazio

                }

                //Validação de CPF
                string cpf = txtCPF.Text.Trim();

                if (!isValidCPFLength(cpf))
                {
                    MessageBox.Show("CPF invalido, Certifique-se de que o CPF tenha 11 digitod",
                                    "Validação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; //Impede o prosseguimento se o CPF for invalido
                }

                //Cria a conexao com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();


                //Comando SQL para inserir um novo cliente no banco de dados
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao
                };


                cmd.Prepare();
                cmd.CommandText = "INSERT INTO dadosdocliente(nomecompleto, nomesocial, email, cpf) " + "VALUES(@nomecompleto, @nomesocial, @email, @cpf)";

                //adiciona os parametros com os dados do formularios
                cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@cpf", cpf);

                //executar o comando de inserção no banco
                cmd.ExecuteNonQuery();

                //Menssagem de sucesso
                MessageBox.Show("Contato inserido com sucesso: ",
                                 "Sucesso",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);


            }
            catch (MySqlException ex)
            {
                //Trata os erros relacionados ao SQL
                MessageBox.Show("Erro" + ex.Number + " ocorreu: " + ex.Message,
                                 "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex) 
            {
                //trata outros tipos de erro
                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                //garante que a conexao com o banco sera fechada, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }
            }
        }

        //Função para validar o comprimento e formato do CPF
        private bool isValidCPFLength(string cpf)
        {
            //Remove todos os caracteres não numéricos
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            //Verifica se o CPF tem exatamente 11 dígitos
            return cpf.Length == 11;
        }
    }
}
