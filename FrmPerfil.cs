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

namespace Praioou
{
    public partial class FrmPerfil : Form
    {

        public FrmPerfil(string nome, string senha)
        {
            InitializeComponent();
            lblNome.Text = nome;
            lblSenha.Text = senha;
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente quer sair?", "Atenção!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Form principal = Application.OpenForms["FrmPrincipal"];
                this.Dispose();
                principal.Show();

            }
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form versao = new AboutBox1();
            versao.ShowDialog();
        }

     
        private void fazerPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form pedido = new FrmReservar();
            pedido.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string nome = lblNome.Text;

            string deletarC = "DELETE FROM cliente WHERE nm_cliente = @nome";


            //string connectionString = "server=localhost;port=3306;database=db_praioou;uid=root;pwd=peppapig14";
            using (MySqlConnection conn = new MySqlConnection("server=localhost;port=3307;database=db_praioou;uid=root;pwd=root"))
            {
                conn.Open();

                if (MessageBox.Show("Você realmente deseja excluir sua conta?", "Atenção!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {


                    using (MySqlCommand cmdC = new MySqlCommand(deletarC, conn))
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

                string editar = "UPDATE cliente SET ds_senhaC = @novaSenha WHERE nm_cliente = @nome";

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

        private void FrmPerfil_Load(object sender, EventArgs e)
        {

        }
    }
}

    


