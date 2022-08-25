using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoLogin_Click(object sender, EventArgs e)
        {
            if (txtLoginUsuario.Text=="teste" && txtLoginSenha.Text=="1234")
            {
                new Form2().Show();
                this.Hide();

            }

            else
            {
                MessageBox.Show("Seu nome de usuario ou senha estão errados");
                txtLoginUsuario.Clear();
                txtLoginSenha.Clear();
                txtLoginUsuario.Focus();
            }
        }

        private void LimpaCamposLogin_Click(object sender, EventArgs e)
        {
            txtLoginUsuario.Clear();
            txtLoginSenha.Clear();
            txtLoginUsuario.Focus();
        }

        private void BotaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
