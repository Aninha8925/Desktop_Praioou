using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praioou
{
    public partial class FrmPerfilBarraqueiro : Form
    {
        private string NomeBarraqueiro;
        private string SenhaBarraqueiro;



        public FrmPerfilBarraqueiro(string nome, string senha)
        {
            InitializeComponent();
            NomeBarraqueiro = nome;
            SenhaBarraqueiro = senha;
            lblNome.Text = nome;
            lblSenha.Text = senha;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente quer sair?", "Atenção!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form principal = Application.OpenForms["FrmPrincipal"];
                principal.Show();
                this.Dispose();

            }
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form versao = new AboutBox1();
            versao.ShowDialog();
        }



        private void comandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form trabalho = new FrmTrabalho();
            trabalho.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {



            string senha = lblSenha.Text;
            string senhadigi = txtSenha.Text;
            string nome = lblNome.Text;

            if (txtSenha.Text == "" || txtNovaSenha.Text == "")
            {
                MessageBox.Show("Preencha os campos faltantes", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (txtSenha.Text == txtNovaSenha.Text)
            {

                string editar = "UPDATE barraqueiro SET ds_senhaB = @novaSenha WHERE nm_barraqueiro = @nome";

                using (MySqlConnection conn = new MySqlConnection("server=localhost;port=3307;database=db_praioou;uid=root;pwd=root"))
                {
                    conn.Open();

                    MySqlCommand comando = new MySqlCommand(editar, conn);
                    comando.Parameters.AddWithValue("@novaSenha", senhadigi); // Usar a nova senha digitada
                    comando.Parameters.AddWithValue("@nome", nome); // Usar o nome do cliente

                    int linhasAfetadas = comando.ExecuteNonQuery();
                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Senha alterada com sucesso!");
                        lblSenha.Text = senhadigi; // Atualiza o label com a nova senha
                        txtNovaSenha.Clear();

                        // Se FrmPrincipal estiver aberto, mostra-o
                        FrmPrincipal principal = Application.OpenForms.OfType<FrmPrincipal>().FirstOrDefault();
                        if (principal != null)
                            principal.Show();

                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível alterar a senha. Verifique os dados e tente novamente.");
                    }

                    conn.Close();
                }
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente deseja excluir sua conta?", "Atenção!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string nome = lblNome.Text;

                string deletarB = "DELETE FROM barraqueiro WHERE nm_barraqueiro = @nome";


                //string connectionString = "server=localhost;port=3306;database=db_praioou;uid=root;pwd=peppapig14";
                using (MySqlConnection conn = new MySqlConnection("server=localhost;port=3307;database=db_praioou;uid=root;pwd=root"))
                {
                    conn.Open();


                    using (MySqlCommand cmdC = new MySqlCommand(deletarB, conn))
                    {
                        cmdC.Parameters.AddWithValue("@nome", nome);
                        cmdC.ExecuteNonQuery();
                    }
                    MessageBox.Show("Conta excluída com sucesso!", "Sucesso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form inicio = Application.OpenForms["FrmPrincipal"];
                    inicio.Show();
                    this.Dispose();


                    conn.Close();

                
            
        
                }
            }
        }
    }
}
