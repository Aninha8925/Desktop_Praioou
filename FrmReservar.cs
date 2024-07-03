using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Praioou
{
    public partial class FrmReservar : Form
    {
        private Dictionary<string, int> carrinho = new Dictionary<string, int>(); // Dicionário para armazenar itens no carrinho
       int Npedido=1;
        public FrmReservar()
        {
            InitializeComponent();
        }

        private void FrmReservar_Load(object sender, EventArgs e)
        {
            LoadBarraqueiros();
        }

        private void LoadBarraqueiros()
        {
            string connString = "server=localhost;port=3307;database=db_praioou;uid=root;pwd=root";
            string query = "SELECT nm_barraqueiro FROM barraqueiro";

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
                                string nomeBarraqueiro = reader["nm_barraqueiro"].ToString();
                                comboBox1.Items.Add(nomeBarraqueiro);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao carregar barraqueiros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void LoadProdutos()
        {
            string connString = "server=localhost;port=3307;database=db_praioou;uid=root;pwd=root";
            string query = "SELECT nm_produto, vl_produto FROM produto";

            lstItens.Items.Clear();  // Limpar a lista antes de adicionar novos itens

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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProdutos();  // Carregar produtos quando um item é selecionado no combo box
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form perfil = Application.OpenForms["FrmPerfil"];
            if (perfil != null)
            {
                perfil.Show();
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstItens.SelectedItem != null)
            {
                string nomeProduto = ExtrairNomeProduto(lstItens.SelectedItem.ToString());

                if (carrinho.ContainsKey(nomeProduto))
                {
                    carrinho[nomeProduto]++;
                    
                }
                else
                {
                    carrinho[nomeProduto] = 1;
                }

                AtualizarListaCarrinho();
            }
        }

        private string ExtrairNomeProduto(string item)
        {
            // Assume que o nome do produto está antes do primeiro espaço
            int indiceEspaco = item.IndexOf(' ');
            if (indiceEspaco >= 0)
            {
                return item.Substring(0, indiceEspaco);
            }
            return item; // Retorna o item inteiro se não encontrar espaço (por segurança)
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstCarrinho.SelectedItem != null)
            {
                string nomeProduto = ExtrairNomeProduto(lstCarrinho.SelectedItem.ToString());

                if (carrinho.ContainsKey(nomeProduto))
                {
                    if (carrinho[nomeProduto] > 1)
                    {
                        carrinho[nomeProduto]--;
                    }
                    else
                    {
                        carrinho.Remove(nomeProduto);
                    }

                    AtualizarListaCarrinho();
                }
            }
        }

        private void AtualizarListaCarrinho()
        {
            lstCarrinho.Items.Clear();
            foreach (var item in carrinho)
            {
                lstCarrinho.Items.Add($"{item.Key} ({item.Value})");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (lstCarrinho.Items.Count == 0 || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Você precisa selecionar um barraqueiro e adicionar itens ao seu carrinho para efetuar uma compra.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // Se passou pela validação, significa que há itens no carrinho e um barraqueiro foi selecionado
            MessageBox.Show("Compra concluída! O pedido será entregue em breve!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpar o carrinho após finalizar o pedido
            lstCarrinho.Items.Clear();
        }

    }
}
