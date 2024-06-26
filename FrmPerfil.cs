﻿using System;
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

        private void FrmPerfil_Load(object sender, EventArgs e)
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

        private void criarNovaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form CriarBarraca = Application.OpenForms["FrmAdicionarBarraca"];
            CriarBarraca.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form VerBarraca = Application.OpenForms["FrmVerBarraca"];
            VerBarraca.Show();
        }

        private void fazerPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string nome = lblNome.Text;
            
            string deletarC = "DELETE FROM cliente WHERE nm_cliente = @nome";

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

                } else
                {
                    MessageBox.Show("ERRO ao deletar conta!", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
               
            }
        }

        private void fabricanteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sobreNósToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_Click(object sender, EventArgs e)
        {
           
        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

