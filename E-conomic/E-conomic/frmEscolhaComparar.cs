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
    public partial class frmEscolhaComparar : Form
    {
        public int idusu = 0;
        public frmEscolhaComparar(int idusuario)
        {
            idusu = idusuario;
            InitializeComponent();
        }

        private void btnTipoMes_Click(object sender, EventArgs e)
        {
            frmComparar f = new frmComparar(idusu,0);
            f.Show();
        }

        private void btnTipoAno_Click(object sender, EventArgs e)
        {
            frmComparar f = new frmComparar(idusu, 1);
            f.Show();
        }
    }
}
