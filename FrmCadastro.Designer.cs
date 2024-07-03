namespace Praioou
{
    partial class FrmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastro));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblFundo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNumTel = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtNumTel = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.radBanhista = new System.Windows.Forms.RadioButton();
            this.radBarraqueiro = new System.Windows.Forms.RadioButton();
            this.grpTipoPerfil = new System.Windows.Forms.GroupBox();
            this.grpTipoPerfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(344, 105);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(143, 31);
            this.txtNome.TabIndex = 0;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Snow;
            this.lblNome.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNome.Location = new System.Drawing.Point(211, 112);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(71, 25);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // lblFundo
            // 
            this.lblFundo.BackColor = System.Drawing.Color.Snow;
            this.lblFundo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFundo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFundo.Location = new System.Drawing.Point(155, 18);
            this.lblFundo.Name = "lblFundo";
            this.lblFundo.Size = new System.Drawing.Size(514, 423);
            this.lblFundo.TabIndex = 7;
            this.lblFundo.Text = "    ";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Snow;
            this.lblEmail.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblEmail.Location = new System.Drawing.Point(211, 175);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 25);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(344, 168);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(143, 31);
            this.txtEmail.TabIndex = 1;
            // 
            // lblNumTel
            // 
            this.lblNumTel.AutoSize = true;
            this.lblNumTel.BackColor = System.Drawing.Color.Snow;
            this.lblNumTel.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumTel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblNumTel.Location = new System.Drawing.Point(211, 316);
            this.lblNumTel.Name = "lblNumTel";
            this.lblNumTel.Size = new System.Drawing.Size(95, 25);
            this.lblNumTel.TabIndex = 12;
            this.lblNumTel.Text = "Num. Tel:";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(344, 235);
            this.txtSenha.Multiline = true;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(143, 31);
            this.txtSenha.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Snow;
            this.lblSenha.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblSenha.Location = new System.Drawing.Point(211, 242);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(71, 25);
            this.lblSenha.TabIndex = 14;
            this.lblSenha.Text = "Senha:";
            // 
            // txtNumTel
            // 
            this.txtNumTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTel.Location = new System.Drawing.Point(344, 309);
            this.txtNumTel.Multiline = true;
            this.txtNumTel.Name = "txtNumTel";
            this.txtNumTel.Size = new System.Drawing.Size(143, 31);
            this.txtNumTel.TabIndex = 3;
            this.txtNumTel.TextChanged += new System.EventHandler(this.txtNumTel_TextChanged);
            this.txtNumTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumTel_KeyPress);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.BackColor = System.Drawing.Color.Snow;
            this.lblMensagem.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.Location = new System.Drawing.Point(198, 44);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(392, 21);
            this.lblMensagem.TabIndex = 17;
            this.lblMensagem.Text = "Preencha os campos abaixo para cadastrar o seu perfil :\r\n";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Teal;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnCadastrar.Location = new System.Drawing.Point(202, 379);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(110, 44);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Teal;
            this.btnVoltar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnVoltar.FlatAppearance.BorderSize = 2;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnVoltar.Location = new System.Drawing.Point(537, 379);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(110, 44);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // radBanhista
            // 
            this.radBanhista.AutoSize = true;
            this.radBanhista.Location = new System.Drawing.Point(20, 130);
            this.radBanhista.Name = "radBanhista";
            this.radBanhista.Size = new System.Drawing.Size(66, 17);
            this.radBanhista.TabIndex = 1;
            this.radBanhista.TabStop = true;
            this.radBanhista.Text = "Banhista";
            this.radBanhista.UseVisualStyleBackColor = true;
            // 
            // radBarraqueiro
            // 
            this.radBarraqueiro.AutoSize = true;
            this.radBarraqueiro.Location = new System.Drawing.Point(20, 53);
            this.radBarraqueiro.Name = "radBarraqueiro";
            this.radBarraqueiro.Size = new System.Drawing.Size(79, 17);
            this.radBarraqueiro.TabIndex = 0;
            this.radBarraqueiro.TabStop = true;
            this.radBarraqueiro.Text = "Barraqueiro";
            this.radBarraqueiro.UseVisualStyleBackColor = true;
            // 
            // grpTipoPerfil
            // 
            this.grpTipoPerfil.Controls.Add(this.radBanhista);
            this.grpTipoPerfil.Controls.Add(this.radBarraqueiro);
            this.grpTipoPerfil.Location = new System.Drawing.Point(517, 105);
            this.grpTipoPerfil.Name = "grpTipoPerfil";
            this.grpTipoPerfil.Size = new System.Drawing.Size(114, 195);
            this.grpTipoPerfil.TabIndex = 23;
            this.grpTipoPerfil.TabStop = false;
            this.grpTipoPerfil.Text = "Tipo de Perfil";
            // 
            // FrmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.grpTipoPerfil);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtNumTel);
            this.Controls.Add(this.lblNumTel);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblFundo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.FrmCadastro_Load);
            this.grpTipoPerfil.ResumeLayout(false);
            this.grpTipoPerfil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblFundo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNumTel;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtNumTel;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.RadioButton radBanhista;
        private System.Windows.Forms.RadioButton radBarraqueiro;
        private System.Windows.Forms.GroupBox grpTipoPerfil;
    }
}