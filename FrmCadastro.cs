using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praioou
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form principal = Application.OpenForms["FrmPrincipal"];
            this.Close();
            principal.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string numtel = txtNumTel.Text;
            string email = txtEmail.Text;

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(numtel) || string.IsNullOrEmpty(senha) || !radBanhista.Checked && !radBarraqueiro.Checked)
            {
                MessageBox.Show("Você não preencheu alguns dos campos!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (!email.Contains("@") || !email.Contains(".com"))
            {
                MessageBox.Show("O email não é válido!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (numtel.Length > 9 || numtel.Length < 8)
            {
                MessageBox.Show("O número de telefone não é válido!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            string connectionString = "server=localhost;port=3307;database=db_praioou;uid=root;pwd=root";
            //string connectionString = "server=localhost;port=3306;database=db_praioou;uid=root;pwd=peppapig14";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    if (IsUserExists(conn, nome, email, numtel))
                    {
                        return;
                    }

                    if (radBanhista.Checked)
                    {
                        RegisterUser(conn, "cliente", nome, email, numtel, senha, "ds_senhaC", "ds_emailC", "nmr_telefoneC", "nm_cliente");
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        Form perfil = new FrmPerfil(nome, senha);
                        perfil.Show();
                    }
                    else if (radBarraqueiro.Checked)
                    {
                        RegisterUser(conn, "barraqueiro", nome, email, numtel, senha, "ds_senhaB", "ds_emailB", "nmr_telefoneB", "nm_barraqueiro");
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        Form perfilB = new FrmPerfilBarraqueiro(nome, senha);
                        perfilB.Show();
                    }

                    this.Close();
                    ClearFields();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool IsUserExists(MySqlConnection conn, string nome, string email, string numtel)
        {
            string[] tables = { "cliente", "barraqueiro" };
            string[] nameColumns = { "nm_cliente", "nm_barraqueiro" };
            string[] emailColumns = { "ds_emailC", "ds_emailB" };
            string[] phoneColumns = { "nmr_telefoneC", "nmr_telefoneB" };

            for (int i = 0; i < tables.Length; i++)
            {
                if (IsFieldExists(conn, tables[i], nameColumns[i], nome))
                {
                    MessageBox.Show("Esse nome já está em uso! Use outro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }

                if (IsFieldExists(conn, tables[i], emailColumns[i], email))
                {
                    MessageBox.Show("Esse email já está em uso! Use outro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }

                if (IsFieldExists(conn, tables[i], phoneColumns[i], numtel))
                {
                    MessageBox.Show("Esse número já está em uso! Use outro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
            }

            return false;
        }

        private bool IsFieldExists(MySqlConnection conn, string tableName, string fieldName, string fieldValue)
        {
            string query = $"SELECT COUNT(*) FROM {tableName} WHERE {fieldName} = @fieldValue";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@fieldValue", fieldValue);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        private void RegisterUser(MySqlConnection conn, string tableName, string nome, string email, string numtel, string senha, string senhaColumn, string emailColumn, string phoneColumn, string nameColumn)
        {
            string query = $"INSERT INTO {tableName} ({nameColumn}, {emailColumn}, {phoneColumn}, {senhaColumn}) VALUES (@nome, @email, @numtel, @senha)";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@numtel", numtel);
                cmd.Parameters.AddWithValue("@senha", senha);
                cmd.ExecuteNonQuery();
            }
        }

        private void ClearFields()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtNumTel.Clear();
            txtSenha.Clear();
            radBanhista.Checked = false;
            radBarraqueiro.Checked = false;
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = true;
        }

        private void txtNumTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void txtNumTel_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
