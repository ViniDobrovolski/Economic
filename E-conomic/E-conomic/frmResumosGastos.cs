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
    public partial class frmResumosGastos : Form
    {
        public int idusu = 0;
        public frmResumosGastos(int idusuario)
        {
            idusu = idusuario;
            InitializeComponent();
            CarregarCampos();
        }

        private void CarregarCampos()
        {
            Model m = new Model();
            decimal rendaMes = m.GetUsuarioRenda(idusu);
            decimal sobra = m.GetSomaGastosMensais(idusu, DateTime.Now.Month);
            decimal ano = m.GetSomaGastosAnuais(idusu, DateTime.Now.Year);
            textRenda.Text = m.GetUsuarioRenda(idusu).ToString();
            textSaldo.Text = (rendaMes - sobra).ToString();
            textTotalMes.Text = sobra.ToString();
            textTotalAno.Text = ano.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
