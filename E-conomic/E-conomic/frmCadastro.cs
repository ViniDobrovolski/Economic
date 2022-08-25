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
    public partial class frmCadastro : Form
    {
        public int usu;
        public frmCadastro(int usuariologado)
        {
            usu = usuariologado;
            InitializeComponent();
            carregarCampos();
            textIDusuario.Text = usu.ToString();
        }

        private void carregarCampos()
        {
            Model set = new Model();
            dtoUsuario p = new dtoUsuario();
            p = set.GetUsuarioId(usu);
            textNome.Text = p.nomecompleto.ToString();
            textEmail.Text = p.email.ToString();
            textSenha.Text = p.senha.ToString();
            textTelefone.Text = p.telefone.ToString();
            textRenda.Text = p.rendamensal.ToString();
        }

        public frmCadastro()
        {
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textNome.Text == "" && textSenha.Text == "" && textEmail.Text == "" && textTelefone.Text == "")
            {
                MessageBox.Show("Algum campo está em branco");

                textNome.Focus();

            }

            else
            {
                Model set = new Model();
                DbUsuarios p = new DbUsuarios();
                
                if (textIDusuario.Text == "")
                {
                    
                    p.nomecompleto = textNome.Text;
                    p.email = textEmail.Text;
                    p.senha = textSenha.Text;
                    p.telefone = textTelefone.Text;
                    p.rendamensal = Convert.ToDecimal(textRenda.Text);
                    set.SetUsuario(p);

                }

                else
                {
                    
                    
                    p.id = Convert.ToInt32(textIDusuario.Text);
                    p.nomecompleto = textNome.Text;
                    p.email = textEmail.Text;
                    p.senha = textSenha.Text;
                    p.telefone = textTelefone.Text;
                    p.rendamensal = Convert.ToDecimal(textRenda.Text);
                    set.EditUsuario(p);

                }

                this.Close();
                frmMenuPrincipal m = new frmMenuPrincipal(p.id);
                m.Show();
                

            }
            
        }
    }

    
}
    

