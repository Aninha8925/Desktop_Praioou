using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praioou
{
    
    public partial class FrmInicio : Form
    {
        string message;
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
           
        }

        private void versãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form versao = new AboutBox1();
            versao.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você realmente quer sair?", "Atenção!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
                Form principal = Application.OpenForms["FrmPrincipal"];
                principal.Show();
            }

        }
    }
}
