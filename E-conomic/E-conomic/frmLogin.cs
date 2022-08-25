using E_conomic;
using E_conomic.Class;
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
        public int idusuariologado;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void BotaoLogin_Click(object sender, EventArgs e)
        {
            Model set = new Model();
            DbUsuarios u = new DbUsuarios();
            u.email = txtLoginUsuario.Text;
            u.senha = txtLoginSenha.Text;

            usuarioLogin login = set.LoginUsuario(u.email,u.senha);

            if (login != null)
            {
                idusuariologado = login.id; 
                new frmMenuPrincipal(idusuariologado).Show();
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

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            
            frmCadastro cad = new frmCadastro();
            cad.Show();
            //this.Close();
        }
    }
}
