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

            if (txtNome.Text == string.Empty || txtEmail.Text == string.Empty || txtNumTel.Text == string.Empty || txtSenha.Text == string.Empty || radBanhista.Checked == false && radBarraqueiro.Checked == false)
            {
                MessageBox.Show("Você não preencheu alguns dos campos!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))
            {
                MessageBox.Show("O email não é válido!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtNumTel.TextLength > 9 || txtNumTel.TextLength < 8)
            {
                MessageBox.Show("O número de telefone não é válido!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                MySqlConnection conn = new MySqlConnection("server=localhost;port=3307;database=db_praioou;uid=root;pwd=root");

                conn.Open();




                if (radBanhista.Checked == true)
                {
                    MySqlCommand cadastrarBanhista = new MySqlCommand("INSERT INTO cliente (nm_cliente, ds_emailC, nmr_telefoneC, ds_senhaC) VALUES (@nome, @email, @numtel, @senha)", conn);
                    MySqlCommand verificanome = new MySqlCommand("SELECT COUNT(*) FROM cliente WHERE nm_cliente = @nome", conn);
                    MySqlCommand verificaemail = new MySqlCommand("SELECT COUNT(*) FROM cliente WHERE ds_emailC = @email", conn);
                    MySqlCommand verificatel = new MySqlCommand("SELECT COUNT(*) FROM cliente WHERE nmr_telefoneC = @numtel", conn);

                    verificanome.Parameters.AddWithValue("@nome", nome);
                    int countnome = Convert.ToInt32(verificanome.ExecuteScalar());
                    if (countnome > 0)
                    {
                        MessageBox.Show("Esse nome já está em uso! Use outro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    verificaemail.Parameters.AddWithValue("@email", email);
                    int countemail = Convert.ToInt32(verificaemail.ExecuteScalar());
                    if (countemail > 0)
                    {
                        MessageBox.Show("Esse email já está em uso! Use outro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    verificatel.Parameters.AddWithValue("@numtel", numtel);
                    int counttel = Convert.ToInt32(verificatel.ExecuteScalar());
                    if (counttel > 0)
                    {
                        MessageBox.Show("Esse número já está em uso! Use outro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }



                    else
                    {
                        conn.Close();
                        conn.Open();


                        cadastrarBanhista.Parameters.AddWithValue("@nome", nome);
                        cadastrarBanhista.Parameters.AddWithValue("@senha", senha);
                        cadastrarBanhista.Parameters.AddWithValue("@email", email);
                        cadastrarBanhista.Parameters.AddWithValue("@numtel", numtel);
                        cadastrarBanhista.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        Form perfil = new FrmPerfil(nome, senha);
                        perfil.Show();
                        this.Close();

                        txtNome.Clear();
                        txtEmail.Clear();
                        txtNumTel.Clear();
                        txtSenha.Clear();
                        radBanhista.Checked = false;
                        radBarraqueiro.Checked = false;

                    }
                }

                else if (radBarraqueiro.Checked == true)
                {
                    MySqlCommand cadastrarBarraqueiro = new MySqlCommand("INSERT INTO barraqueiro (nm_barraqueiro, ds_emailB, ds_senhaB, nmr_telefoneB) VALUES (@nome, @email,@senha, @numtel )", conn);
                    MySqlCommand verificanomeB = new MySqlCommand("SELECT COUNT(*) FROM barraqueiro WHERE nm_barraqueiro = @nome", conn);
                    MySqlCommand verificaemailB = new MySqlCommand("SELECT COUNT(*) FROM barraqueiro WHERE ds_emailB = @email", conn);
                    MySqlCommand verificatelB = new MySqlCommand("SELECT COUNT(*) FROM barraqueiro WHERE nmr_telefoneB = @numtel", conn);

                    verificanomeB.Parameters.AddWithValue("@nome", nome);
                    int countnomeB = Convert.ToInt32(verificanomeB.ExecuteScalar());
                    if (countnomeB > 0)
                    {
                        MessageBox.Show("Esse nome já está em uso! Use outro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    verificaemailB.Parameters.AddWithValue("@email", email);
                    int countemailB = Convert.ToInt32(verificaemailB.ExecuteScalar());
                    if (countemailB > 0)
                    {
                        MessageBox.Show("Esse email já está em uso! Use outro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    verificatelB.Parameters.AddWithValue("@numtel", numtel);
                    int counttelB = Convert.ToInt32(verificatelB.ExecuteScalar());
                    if (counttelB > 0)
                    {
                        MessageBox.Show("Esse número já está em uso! Use outro.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();

                        cadastrarBarraqueiro.Parameters.AddWithValue("@nome", nome);
                        cadastrarBarraqueiro.Parameters.AddWithValue("@senha", senha);
                        cadastrarBarraqueiro.Parameters.AddWithValue("@email", email);
                        cadastrarBarraqueiro.Parameters.AddWithValue("@numtel", numtel);
                        cadastrarBarraqueiro.ExecuteNonQuery();
                        MessageBox.Show("Usuário cadastrado com sucesso!");
                        Form perfilB = new FrmPerfilBarraqueiro(nome, senha);
                        perfilB.Show();
                        this.Close();

                        txtNome.Clear();
                        txtEmail.Clear();
                        txtNumTel.Clear();
                        txtSenha.Clear();
                        radBanhista.Checked = false;
                        radBarraqueiro.Checked = false;
                    }
                }
            }
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
    }
}
