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
    public partial class FrmPerfilBarraqueiro : Form
    {
        public FrmPerfilBarraqueiro(string nome, string senha)
        {
           
            InitializeComponent();
            lblNome.Text = nome;
            lblSenha.Text = senha;
        }

        private void FrmPerfilBarraqueiro_Load(object sender, EventArgs e)
        {

        }

        private void FrmPerfilBarraqueiro_Load_1(object sender, EventArgs e)
        {
            
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string nome = lblNome.Text;

            string deletarB = "DELETE FROM barraqueiro WHERE nm_barraqueiro = @nome";
            using (MySqlConnection conn = new MySqlConnection("server=localhost;port=3307;database=db_praioou;uid=root;pwd=root"))
            {
                conn.Open();

                if (MessageBox.Show("Você realmente deseja excluir sua conta?", "Atenção!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    using (MySqlCommand cmdB = new MySqlCommand(deletarB, conn))
                    {

                        cmdB.Parameters.AddWithValue("@nome", nome);
                        cmdB.ExecuteNonQuery();
                    }
                    MessageBox.Show("Conta excluída com sucesso!", "Sucesso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form inicio = Application.OpenForms["FrmPrincipal"];
                    inicio.Show();
                    this.Dispose();


                    conn.Close();

                }
                else
                {
                    MessageBox.Show("ERRO ao deletar conta!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }

            }

        }

        private void txtEditar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNome_Click(object sender, EventArgs e)
        {
            
        }

        private void txtSenha_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
