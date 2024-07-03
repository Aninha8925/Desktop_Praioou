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
    public partial class FrmTrabalho : Form
    {


        public FrmTrabalho()
        {
            InitializeComponent();

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form perfilB = Application.OpenForms["FrmPerfilBarraqueiro"];
            if (perfilB != null)
            {
                perfilB.Show();
                this.Close();
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeItens.Text) || string.IsNullOrWhiteSpace(txtValorProduto.Text))
            {
                MessageBox.Show("Preencha os campos para adicionar o item ao seu cardápio!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string nomeProduto = txtNomeItens.Text;
            string valorProduto = txtValorProduto.Text;
            string bdnomeproduto = "";

            string criarproduto = "INSERT INTO produto (nm_produto, vl_produto) VALUES (@nomeProduto, @valorProduto)";
            string verificarproduto = "SELECT nm_produto FROM produto WHERE nm_produto = @nomeProduto";

            using (MySqlConnection conn = new MySqlConnection("server=localhost;port=3307;database=db_praioou;uid=root;pwd=root"))
            {
                try
                {
                    conn.Open();

                    // Verificar se o produto já existe
                    MySqlCommand verificar = new MySqlCommand(verificarproduto, conn);
                    verificar.Parameters.AddWithValue("@nomeProduto", nomeProduto);

                    // Executar o comando de verificação
                    object result = verificar.ExecuteScalar();

                    if (result != null)
                    {
                        MessageBox.Show("Esse produto já existe!!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNomeItens.Clear();
                        txtValorProduto.Clear();
                        return;
                    }

                    // Se o produto não existir, então inserir
                    using (MySqlCommand cmd = new MySqlCommand(criarproduto, conn))
                    {
                        cmd.Parameters.AddWithValue("@nomeProduto", nomeProduto);
                        cmd.Parameters.AddWithValue("@valorProduto", valorProduto);
                        cmd.ExecuteNonQuery();
                        lstItens.Items.Add($"{nomeProduto} R${valorProduto}");
                        txtNomeItens.Clear();
                        txtValorProduto.Clear();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao adicionar produto: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }


        private void txtNomeItens_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas letras e controle (como backspace)
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtValorProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir apenas números, vírgulas, pontos e controle (como backspace)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lblFudo_Click(object sender, EventArgs e)
        {

        }

        private void FrmTrabalho_Load(object sender, EventArgs e)
        {
            LoadProdutos();


        }

        private void LoadProdutos()
        {
            string connString = "server=localhost;port=3307;database=db_praioou;uid=root;pwd=root";
            string query = "SELECT nm_produto, vl_produto FROM produto";

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string nomeProduto = reader["nm_produto"].ToString();
                                string valorProduto = reader["vl_produto"].ToString();
                                lstItens.Items.Add($"{nomeProduto} R${valorProduto}");
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao carregar produtos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {


            if (txtNomeItens.Text == "")
            {
                MessageBox.Show("Escreva o nome do produto que deseja excluir primeiro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MySqlConnection conn = new MySqlConnection("server=localhost;port=3307;database=db_praioou;uid=root;pwd=root");
            string deletarproduto = "DELETE FROM produto WHERE nm_produto = @nomeproduto";
            MySqlCommand deletar = new MySqlCommand(deletarproduto, conn);

            string nomeproduto = txtNomeItens.Text;

            conn.Open();

            if (MessageBox.Show("Você realmente deseja excluir esse produto?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deletar.Parameters.AddWithValue("@nomeproduto", nomeproduto);
                int dr = deletar.ExecuteNonQuery();
                lstItens.Items.Clear();
                txtNomeItens.Clear();
                LoadProdutos();
                MessageBox.Show("O produto foi excluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void lblCount_Click(object sender, EventArgs e)
        {

        }

        private void txtValorProduto_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

