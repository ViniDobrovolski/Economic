namespace E_conomic
{
    partial class frmEscolhaComparar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscolhaComparar));
            this.btnTipoMes = new System.Windows.Forms.Button();
            this.btnTipoAno = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTipoMes
            // 
            this.btnTipoMes.BackColor = System.Drawing.Color.Lime;
            this.btnTipoMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoMes.ForeColor = System.Drawing.Color.White;
            this.btnTipoMes.Location = new System.Drawing.Point(57, 219);
            this.btnTipoMes.Name = "btnTipoMes";
            this.btnTipoMes.Size = new System.Drawing.Size(172, 76);
            this.btnTipoMes.TabIndex = 0;
            this.btnTipoMes.Text = "Comparar gastos de um tipo durante o mes";
            this.btnTipoMes.UseVisualStyleBackColor = false;
            this.btnTipoMes.Click += new System.EventHandler(this.btnTipoMes_Click);
            // 
            // btnTipoAno
            // 
            this.btnTipoAno.BackColor = System.Drawing.Color.Lime;
            this.btnTipoAno.FlatAppearance.BorderSize = 0;
            this.btnTipoAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipoAno.ForeColor = System.Drawing.Color.White;
            this.btnTipoAno.Location = new System.Drawing.Point(496, 219);
            this.btnTipoAno.Name = "btnTipoAno";
            this.btnTipoAno.Size = new System.Drawing.Size(171, 76);
            this.btnTipoAno.TabIndex = 2;
            this.btnTipoAno.Text = "Comparar gastos de um tipo durante o ano";
            this.btnTipoAno.UseVisualStyleBackColor = false;
            this.btnTipoAno.Click += new System.EventHandler(this.btnTipoAno_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmEscolhaComparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(716, 339);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTipoAno);
            this.Controls.Add(this.btnTipoMes);
            this.Name = "frmEscolhaComparar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparação de gastos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTipoMes;
        private System.Windows.Forms.Button btnTipoAno;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}