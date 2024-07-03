namespace Praioou
{
    partial class FrmPerfilBarraqueiro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPerfilBarraqueiro));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comandaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lab = new System.Windows.Forms.Label();
            this.txtNovaSenha = new System.Windows.Forms.TextBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.lblFudo = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.imgUser = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contaToolStripMenuItem,
            this.ajudaToolStripMenuItem,
            this.comandaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contaToolStripMenuItem
            // 
            this.contaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.contaToolStripMenuItem.Name = "contaToolStripMenuItem";
            this.contaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.contaToolStripMenuItem.Text = "Conta";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versãoToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // versãoToolStripMenuItem
            // 
            this.versãoToolStripMenuItem.Name = "versãoToolStripMenuItem";
            this.versãoToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.versãoToolStripMenuItem.Text = "Versão";
            this.versãoToolStripMenuItem.Click += new System.EventHandler(this.versãoToolStripMenuItem_Click);
            // 
            // comandaToolStripMenuItem
            // 
            this.comandaToolStripMenuItem.Name = "comandaToolStripMenuItem";
            this.comandaToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.comandaToolStripMenuItem.Text = "Área de trabalho";
            this.comandaToolStripMenuItem.Click += new System.EventHandler(this.comandaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(384, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 389);
            this.label1.TabIndex = 16;
            // 
            // lab
            // 
            this.lab.AutoSize = true;
            this.lab.BackColor = System.Drawing.Color.White;
            this.lab.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lab.Location = new System.Drawing.Point(500, 189);
            this.lab.Name = "lab";
            this.lab.Size = new System.Drawing.Size(111, 17);
            this.lab.TabIndex = 28;
            this.lab.Text = "Confirmar Senha";
            // 
            // txtNovaSenha
            // 
            this.txtNovaSenha.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNovaSenha.Location = new System.Drawing.Point(503, 210);
            this.txtNovaSenha.Multiline = true;
            this.txtNovaSenha.Name = "txtNovaSenha";
            this.txtNovaSenha.Size = new System.Drawing.Size(159, 31);
            this.txtNovaSenha.TabIndex = 26;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Teal;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnEditar.FlatAppearance.BorderSize = 2;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnEditar.Location = new System.Drawing.Point(524, 279);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 44);
            this.btnEditar.TabIndex = 24;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblFudo
            // 
            this.lblFudo.BackColor = System.Drawing.Color.Snow;
            this.lblFudo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFudo.Location = new System.Drawing.Point(32, 31);
            this.lblFudo.Name = "lblFudo";
            this.lblFudo.Size = new System.Drawing.Size(736, 389);
            this.lblFudo.TabIndex = 32;
            this.lblFudo.Text = "    ";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(188, 260);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(63, 25);
            this.lblSenha.TabIndex = 36;
            this.lblSenha.Text = "label2";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(188, 216);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 25);
            this.lblNome.TabIndex = 35;
            this.lblNome.Text = "label1";
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Brown;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnExcluir.FlatAppearance.BorderSize = 2;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.Tomato;
            this.btnExcluir.Location = new System.Drawing.Point(165, 314);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(110, 44);
            this.btnExcluir.TabIndex = 34;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click_1);
            // 
            // imgUser
            // 
            this.imgUser.BackColor = System.Drawing.Color.White;
            this.imgUser.Image = ((System.Drawing.Image)(resources.GetObject("imgUser.Image")));
            this.imgUser.Location = new System.Drawing.Point(158, 62);
            this.imgUser.Name = "imgUser";
            this.imgUser.Size = new System.Drawing.Size(135, 131);
            this.imgUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUser.TabIndex = 33;
            this.imgUser.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(500, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 38;
            this.label2.Text = "NovaSenha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(503, 142);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(159, 31);
            this.txtSenha.TabIndex = 37;
            // 
            // FrmPerfilBarraqueiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.imgUser);
            this.Controls.Add(this.lab);
            this.Controls.Add(this.txtNovaSenha);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblFudo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FrmPerfilBarraqueiro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comandaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lab;
        private System.Windows.Forms.TextBox txtNovaSenha;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label lblFudo;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.PictureBox imgUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSenha;
    }
}