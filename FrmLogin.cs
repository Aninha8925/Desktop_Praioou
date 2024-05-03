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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

       
       

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Form principal = Application.OpenForms["FrmPrincipal"];
            principal.Show();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            if (txtNome.Text == string.Empty || txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Você não preencheu alguns dos campos!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } if (Class1.Nome.Contains(txtNome.Text) && Class1.Senha.Contains(txtSenha.Text))
            {
                MessageBox.Show("Login bem-sucedido!", "sucesso!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FrmInicio inicio = new FrmInicio();
                inicio.Show();
                this.Close();
            } else
            {
                MessageBox.Show("Esse Usuário não existe!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }
    }
}
