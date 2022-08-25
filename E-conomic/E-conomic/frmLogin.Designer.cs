namespace LoginScreen
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BotaoLogin = new System.Windows.Forms.Button();
            this.LimpaCamposLogin = new System.Windows.Forms.Label();
            this.BotaoSair = new System.Windows.Forms.Label();
            this.txtLoginUsuario = new System.Windows.Forms.TextBox();
            this.txtLoginSenha = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(87, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "LOGIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lime;
            this.panel1.Location = new System.Drawing.Point(29, 243);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 1);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lime;
            this.panel2.Location = new System.Drawing.Point(29, 315);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 1);
            this.panel2.TabIndex = 3;
            // 
            // BotaoLogin
            // 
            this.BotaoLogin.BackColor = System.Drawing.Color.Lime;
            this.BotaoLogin.FlatAppearance.BorderSize = 0;
            this.BotaoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoLogin.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoLogin.ForeColor = System.Drawing.Color.White;
            this.BotaoLogin.Location = new System.Drawing.Point(29, 356);
            this.BotaoLogin.Name = "BotaoLogin";
            this.BotaoLogin.Size = new System.Drawing.Size(236, 33);
            this.BotaoLogin.TabIndex = 3;
            this.BotaoLogin.Text = "Entre";
            this.BotaoLogin.UseVisualStyleBackColor = false;
            this.BotaoLogin.Click += new System.EventHandler(this.BotaoLogin_Click);
            // 
            // LimpaCamposLogin
            // 
            this.LimpaCamposLogin.AutoSize = true;
            this.LimpaCamposLogin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LimpaCamposLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpaCamposLogin.ForeColor = System.Drawing.Color.Lime;
            this.LimpaCamposLogin.Location = new System.Drawing.Point(167, 328);
            this.LimpaCamposLogin.Name = "LimpaCamposLogin";
            this.LimpaCamposLogin.Size = new System.Drawing.Size(115, 16);
            this.LimpaCamposLogin.TabIndex = 5;
            this.LimpaCamposLogin.Text = "Limpar Campos";
            this.LimpaCamposLogin.Click += new System.EventHandler(this.LimpaCamposLogin_Click);
            // 
            // BotaoSair
            // 
            this.BotaoSair.AutoSize = true;
            this.BotaoSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoSair.ForeColor = System.Drawing.Color.Lime;
            this.BotaoSair.Location = new System.Drawing.Point(201, 409);
            this.BotaoSair.Name = "BotaoSair";
            this.BotaoSair.Size = new System.Drawing.Size(35, 16);
            this.BotaoSair.TabIndex = 5;
            this.BotaoSair.Text = "Sair";
            this.BotaoSair.Click += new System.EventHandler(this.BotaoSair_Click);
            // 
            // txtLoginUsuario
            // 
            this.txtLoginUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginUsuario.ForeColor = System.Drawing.Color.Lime;
            this.txtLoginUsuario.Location = new System.Drawing.Point(61, 216);
            this.txtLoginUsuario.Multiline = true;
            this.txtLoginUsuario.Name = "txtLoginUsuario";
            this.txtLoginUsuario.Size = new System.Drawing.Size(204, 24);
            this.txtLoginUsuario.TabIndex = 0;
            this.txtLoginUsuario.Text = "Usuario";
            // 
            // txtLoginSenha
            // 
            this.txtLoginSenha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLoginSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginSenha.ForeColor = System.Drawing.Color.Lime;
            this.txtLoginSenha.Location = new System.Drawing.Point(60, 286);
            this.txtLoginSenha.Multiline = true;
            this.txtLoginSenha.Name = "txtLoginSenha";
            this.txtLoginSenha.PasswordChar = '*';
            this.txtLoginSenha.Size = new System.Drawing.Size(204, 24);
            this.txtLoginSenha.TabIndex = 1;
            this.txtLoginSenha.Text = "Senha";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(29, 280);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 208);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 41);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 41);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCadastro.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.ForeColor = System.Drawing.Color.Lime;
            this.btnCadastro.Location = new System.Drawing.Point(42, 406);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastro.TabIndex = 4;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::E_conomic.Properties.Resources.Prancheta_1_cópia_3;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(294, 141);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 447);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtLoginSenha);
            this.Controls.Add(this.txtLoginUsuario);
            this.Controls.Add(this.BotaoSair);
            this.Controls.Add(this.LimpaCamposLogin);
            this.Controls.Add(this.BotaoLogin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BotaoLogin;
        private System.Windows.Forms.Label LimpaCamposLogin;
        private System.Windows.Forms.Label BotaoSair;
        private System.Windows.Forms.TextBox txtLoginUsuario;
        private System.Windows.Forms.TextBox txtLoginSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

