using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Praioou
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form principal = Application.OpenForms["FrmPrincipal"];
            principal.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty || txtEmail.Text == string.Empty || txtNumTel.Text == string.Empty || txtSenha.Text == string.Empty || radF.Checked == false && radM.Checked == false || radBanhista.Checked == false && radBarraqueiro.Checked == false)
            {
                MessageBox.Show("Você não preencheu alguns dos campos!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }else if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))
            {
                MessageBox.Show("O email não é válido!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (txtNumTel.TextLength > 9 || txtNumTel.TextLength < 8)
            {
                MessageBox.Show("O número de telefone não é válido!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else if (Class1.Nome.Contains(txtNome.Text) || Class1.Email.Contains(txtEmail.Text) || Class1.NumTel.Contains(txtNumTel.Text))
            {
                MessageBox.Show("Já existe um usuário com esses dados!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                Class1.Nome.Add(txtNome.Text);
                Class1.Email.Add(txtEmail.Text);
                Class1.Senha.Add(txtSenha.Text);
                Class1.NumTel.Add(txtNumTel.Text);
                if (radF.Checked == true)
                {
                    Class1.Sexo.Add(radF.Checked);
                } if (radM.Checked == true)
                {
                    Class1.Sexo.Add(radM.Checked);
                }
                if (radBarraqueiro.Checked == true)
                {
                    Class1.TipoPerfil.Add(radBanhista.Checked);
                }
                if (radM.Checked == true)
                {
                    Class1.TipoPerfil.Add(radBarraqueiro.Checked);
                }

                MessageBox.Show("Seu usuário foi cadastrado!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNome.Clear();
                txtEmail.Clear();
                txtNumTel.Clear();
                txtSenha.Clear();
                radBanhista.Checked = false;
                radBarraqueiro.Checked = false;
                radM.Checked = false;
                radF.Checked = false;
            }
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (char.IsNumber(e.KeyChar))

                e.Handled = true;
        }

        private void txtNumTel_TextChanged(object sender, EventArgs e)
        {
           


        }

        private void txtNumTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
        }

        private void lblFundo_Click(object sender, EventArgs e)
        {

        }
    }
}
