using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praioou
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                string nome = txtNome.Text;
                string senha = txtSenha.Text;
                string bdsenha = "";

                string loginBanhista = "SELECT ds_senhaC FROM cliente WHERE nm_cliente = @nome";
                string loginBarraqueiro = "SELECT ds_senhaB FROM barraqueiro WHERE nm_barraqueiro = @nome";

                try
                {
                    
                    //string connectionString = "server=localhost;port=3306;database=db_praioou;uid=root;pwd=peppapig14";
                    using (MySqlConnection conn = new MySqlConnection("server=localhost;port=3307;database=db_praioou;uid=root;pwd=root"))
                    {
                        conn.Open();

                        // Primeiro tentar login como banhista
                        using (MySqlCommand logarBanhista = new MySqlCommand(loginBanhista, conn))
                        {
                            logarBanhista.Parameters.AddWithValue("@nome", nome);

                            using (MySqlDataReader reader = logarBanhista.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    bdsenha = reader["ds_senhaC"].ToString();
                                    reader.Close(); // Fechar o reader antes de abrir outro

                                    if (senha == bdsenha)
                                    {
                                        MessageBox.Show("Login bem-sucedido!", "Sucesso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        FrmPerfil perfilBanhista = new FrmPerfil(nome, senha);
                                        perfilBanhista.Show();
                                        this.Close();
                                        txtNome.Clear();
                                        txtSenha.Clear();
                                        return;
                                    }
                                }
                                else
                                {
                                    reader.Close(); // Fechar o reader caso não tenha lido nada
                                }
                            }
                        }

                        // Se não encontrou como banhista, tentar como barraqueiro
                        using (MySqlCommand logarBarraqueiro = new MySqlCommand(loginBarraqueiro, conn))
                        {
                            logarBarraqueiro.Parameters.AddWithValue("@nome", nome);

                            using (MySqlDataReader reader = logarBarraqueiro.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    bdsenha = reader["ds_senhaB"].ToString();
                                    reader.Close(); // Fechar o reader antes de qualquer ação

                                    if (senha == bdsenha)
                                    {
                                        MessageBox.Show("Login bem-sucedido!", "Sucesso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        Form perfilBarraqueiro = new FrmPerfilBarraqueiro(nome, senha);
                                        perfilBarraqueiro.Show();
                                        this.Close();
                                        txtNome.Clear();
                                        txtSenha.Clear();
                                        return;
                                    }
                                }
                                else
                                {
                                    reader.Close(); // Fechar o reader caso não tenha lido nada
                                }
                            }
                        }

                        MessageBox.Show("Usuário ou senha incorretos!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Você não preencheu alguns dos campos!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form principal = Application.OpenForms["FrmPrincipal"];
            principal.Show();
            this.Close();
        }
    }
}
