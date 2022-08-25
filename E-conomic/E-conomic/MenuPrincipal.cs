using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_conomic
{
    public partial class MenuPrincipal : Form
    {
        public int idusuariologado;
        public MenuPrincipal(int usuariologado)
        {

            InitializeComponent();
            idusuariologado = usuariologado;

        }
            
        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            adicionarGastos f = new adicionarGastos(idusuariologado);
            f.Show();
        }

        private void btnAdicionarTipo_Click(object sender, EventArgs e)
        {
            frmTipoGasto f = new frmTipoGasto();
            f.Show();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
