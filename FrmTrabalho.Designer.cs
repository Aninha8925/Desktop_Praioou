namespace Praioou
{
    partial class FrmTrabalho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTrabalho));
            this.lblFudo = new System.Windows.Forms.Label();
            this.txtNomeItens = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.txtValorProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grpAdicionarEditar = new System.Windows.Forms.GroupBox();
            this.grpAdicionarEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFudo
            // 
            this.lblFudo.BackColor = System.Drawing.Color.Snow;
            this.lblFudo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFudo.Location = new System.Drawing.Point(7, 9);
            this.lblFudo.Name = "lblFudo";
            this.lblFudo.Size = new System.Drawing.Size(786, 432);
            this.lblFudo.TabIndex = 7;
            this.lblFudo.Text = "    ";
            this.lblFudo.Click += new System.EventHandler(this.lblFudo_Click);
            // 
            // txtNomeItens
            // 
            this.txtNomeItens.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeItens.Location = new System.Drawing.Point(24, 65);
            this.txtNomeItens.Multiline = true;
            this.txtNomeItens.Name = "txtNomeItens";
            this.txtNomeItens.Size = new System.Drawing.Size(172, 28);
            this.txtNomeItens.TabIndex = 9;
            this.txtNomeItens.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeItens_KeyPress);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Teal;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdicionar.FlatAppearance.BorderSize = 2;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdicionar.Location = new System.Drawing.Point(366, 371);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(126, 50);
            this.btnAdicionar.TabIndex = 10;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // lstItens
            // 
            this.lstItens.FormattingEnabled = true;
            this.lstItens.Location = new System.Drawing.Point(25, 92);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(279, 264);
            this.lstItens.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(21, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cardápio";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Teal;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnVoltar.FlatAppearance.BorderSize = 2;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnVoltar.Location = new System.Drawing.Point(26, 382);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(97, 39);
            this.btnVoltar.TabIndex = 35;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // txtValorProduto
            // 
            this.txtValorProduto.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorProduto.Location = new System.Drawing.Point(244, 65);
            this.txtValorProduto.Multiline = true;
            this.txtValorProduto.Name = "txtValorProduto";
            this.txtValorProduto.Size = new System.Drawing.Size(172, 28);
            this.txtValorProduto.TabIndex = 36;
            this.txtValorProduto.TextChanged += new System.EventHandler(this.txtValorProduto_TextChanged);
            this.txtValorProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorProduto_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(29, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nome do Produto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Location = new System.Drawing.Point(259, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Valor do Produto";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Brown;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnExcluir.FlatAppearance.BorderSize = 2;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Tomato;
            this.btnExcluir.Location = new System.Drawing.Point(603, 371);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(126, 50);
            this.btnExcluir.TabIndex = 40;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // grpAdicionarEditar
            // 
            this.grpAdicionarEditar.Controls.Add(this.txtValorProduto);
            this.grpAdicionarEditar.Controls.Add(this.txtNomeItens);
            this.grpAdicionarEditar.Controls.Add(this.label2);
            this.grpAdicionarEditar.Controls.Add(this.label4);
            this.grpAdicionarEditar.Location = new System.Drawing.Point(327, 160);
            this.grpAdicionarEditar.Name = "grpAdicionarEditar";
            this.grpAdicionarEditar.Size = new System.Drawing.Size(432, 125);
            this.grpAdicionarEditar.TabIndex = 41;
            this.grpAdicionarEditar.TabStop = false;
            // 
            // FrmTrabalho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grpAdicionarEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstItens);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblFudo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmTrabalho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área de trabalho";
            this.Load += new System.EventHandler(this.FrmTrabalho_Load);
            this.grpAdicionarEditar.ResumeLayout(false);
            this.grpAdicionarEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFudo;
        private System.Windows.Forms.TextBox txtNomeItens;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox lstItens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.TextBox txtValorProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox grpAdicionarEditar;
    }
}