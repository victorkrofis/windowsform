using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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

        private int ?codigo_cliente = null;


        public frmCadastroDeCliente()
        {
            InitializeComponent();
            //Configuração inicial do listview para exibição dos dados do clientes
            lstClientes.View = View.Details; //Define a visualização em "detalhes"
            lstClientes.LabelEdit = true; //Permite editar os titulos das colunas
            lstClientes.AllowColumnReorder = true; //Permite reordenar as colunas
            lstClientes.FullRowSelect = true; // Seleciona a linha inteira ao clicar
            lstClientes.GridLines = true; //Exibe as linhas de grade no ListView

            //Definindo as colunas do ListView
            lstClientes.Columns.Add("Codigo", 100, HorizontalAlignment.Left); //Coluna de codigo
            lstClientes.Columns.Add("Nome completo", 200, HorizontalAlignment.Left); //Coluna de Nome Completo
            lstClientes.Columns.Add("Nome Social", 200, HorizontalAlignment.Left); //Coluna de Nome Social
            lstClientes.Columns.Add("E-mail", 200, HorizontalAlignment.Left); //Coluna de Email
            lstClientes.Columns.Add("CPF", 200, HorizontalAlignment.Left); //Coluna de CPF

            //Carrega os dados dos clientes na interface
             carregar_cliente();
        }


        private void carregar_clientes_com_query(string query)
        {
            try
            {


                //cria conexao com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //PortableExecutableKinds a consulta SQL fornecida
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //se a consulta contem o parametro @q, adiciona o valor da caixa de pesquisa
                if (query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }

                //executa o comando e obtem os resultados
                MySqlDataReader reader = cmd.ExecuteReader();

                //Limpa os itens existentes no ListView antes de adicionar novos
                lstClientes.Items.Clear();

                //Preenche o ListView com os dados do cliente
                while (reader.Read())
                {

                    //cria uma linha para cada cliente com os dados retornados da consulta
                    string[] row =
                    {
                        Convert.ToString(reader.GetInt32(0)),   //codigo
                        reader.GetString(1),                    //Nome Completo
                        reader.GetString(2),                    //Nome Social
                        reader.GetString(3),                    //E-mail
                        reader.GetString(4),                    //CPF
                    };

                    //adiciona linha no ListView
                    lstClientes.Items.Add(new ListViewItem(row));
                }



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

       //Método para carregar todos os clientes no listView (Usando uma consulta sem parametros)
       private void carregar_cliente()
        {
            string query = "SELECT * FROM dadosdocliente ORDER BY idcliente DESC";
            carregar_clientes_com_query(query);
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

                if (codigo_cliente == null)
                {
                    //Insert
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
                else 
                {
                    //Update
                    cmd.CommandText = $"UPDATE `dadosdocliente` SET " +
                        $"nomecompleto = @nomecompleto, " +
                        $"nomesocial = @nomesocial, " +
                        $"email = @email, " +
                        $"cpf = @cpf " +
                        $"WHERE idcliente = @codigo";

                    cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                    cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@codigo", codigo_cliente);


                    //Executa o comando de alteração no banco
                    cmd.ExecuteNonQuery();

                    //Mensagem de suscceso
                    MessageBox.Show($"Os dados com o codigo {codigo_cliente} foram alterados com sucesso!",
                                    "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }


                codigo_cliente = null;



                //Limpa os campos apos o sucesso
                txtNomeCompleto.Text = String.Empty;
                txtNomeSocial.Text = " ";
                txtEmail.Text = " ";
                txtCPF.Text = " ";

                //regarregar os clientes no ListView
                carregar_cliente();

                //muda para a aba de pesquisa
                tbControl.SelectedIndex = 1;

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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dadosdocliente WHERE nomecompleto LIKE @q OR nomesocial LIKE @q ORDER BY idcliente DESC";
            carregar_clientes_com_query(query);
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection clientedaselecao = lstClientes.SelectedItems;
            foreach (ListViewItem item in clientedaselecao)
            {
                codigo_cliente = Convert.ToInt32(item.SubItems[0].Text);

                MessageBox.Show("Codigo do Cliente: " + codigo_cliente.ToString(),
                                "Codigo Selecionado",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);


                txtNomeCompleto.Text = item.SubItems[1].Text;
                txtNomeSocial.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
                txtCPF.Text = item.SubItems[4].Text;
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            codigo_cliente = null;
            txtNomeCompleto.Text = String.Empty;
            txtNomeSocial.Text = " ";
            txtEmail.Text = " ";
            txtCPF.Text = " ";


            txtNomeCompleto.Focus();
        }
    }
}
