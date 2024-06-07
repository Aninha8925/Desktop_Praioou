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

                string loginBanhista = "select ds_senhaC from cliente where nm_cliente = @nome";
                string loginBarraqueiro = "select ds_senhaB from barraqueiro where nm_barraqueiro = @nome";

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
                        }
                    }

                    MessageBox.Show("Usuário ou senha incorretos!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
