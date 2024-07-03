namespace Praioou
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblBoasVindas = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBoasVindas
            // 
            this.lblBoasVindas.AutoSize = true;
            this.lblBoasVindas.BackColor = System.Drawing.Color.White;
            this.lblBoasVindas.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoasVindas.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lblBoasVindas.Location = new System.Drawing.Point(302, 119);
            this.lblBoasVindas.Name = "lblBoasVindas";
            this.lblBoasVindas.Size = new System.Drawing.Size(204, 32);
            this.lblBoasVindas.TabIndex = 0;
            this.lblBoasVindas.Text = "Seja Bem-Vindo!";
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.Teal;
            this.btnEntrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnEntrar.FlatAppearance.BorderSize = 2;
            this.btnEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnEntrar.Location = new System.Drawing.Point(318, 216);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(167, 49);
            this.btnEntrar.TabIndex = 1;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Teal;
            this.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnCadastrar.FlatAppearance.BorderSize = 2;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.btnCadastrar.Location = new System.Drawing.Point(318, 304);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(167, 49);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar-se";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.lblBoasVindas);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Praioou";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBoasVindas;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnCadastrar;
    }
}